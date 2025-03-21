using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenProjetGestionEtudiant;
using ExamProject.Entity;

namespace ExamProject.Forms
{
    public partial class OTPCodeForm : Form
    {
        private DBExamenContext db;
        private Utilisateur currentUser;
        private Timer expirationTimer;
        private OtpCodesImpl otpCodesImpl;
        public OTPCodeForm(Utilisateur user)
        {
            InitializeComponent();
            this.currentUser = user;
            this.db = new DBExamenContext();
            this.otpCodesImpl = new OtpCodesImpl();

            // Initialiser le timer pour l'expiration
            expirationTimer = new Timer();
            expirationTimer.Interval = 1000;
            expirationTimer.Tick += timer1_Tick;
        }

        private void OTPCodeForm_Load(object sender, EventArgs e)
        {

        }

        private void StartExpirationTimer()
        {
            // Récupérer le code OTP le plus récent pour l'utilisateur
            var otpCode = db.otpcodes
                .Where(o => o.IdUtilisateur == currentUser.Id)
                .OrderByDescending(o => o.DateExpiration)
                .FirstOrDefault();

            if (otpCode != null)
            {
                TimeSpan timeLeft = otpCode.DateExpiration - DateTime.Now;
                UpdateTimerDisplay(timeLeft);
            }
        }


        private void btnVerifier_Click(object sender, EventArgs e)
        {
            string saisieCode = txtOTPCode.Text.Trim();
            if (string.IsNullOrEmpty(saisieCode))
            {
                MessageBox.Show("Veuillez saisir le code de vérification", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Utiliser la méthode de vérification OTP de la classe OtpCodesImpl
            bool isValid = otpCodesImpl.VerifyOTP(currentUser.Id, saisieCode);

            if (isValid)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                txtOTPCode.Clear();
                txtOTPCode.Focus();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnRenvoyer_Click(object sender, EventArgs e)
        {
            var anciensOTPs = db.otpcodes.Where(o => o.IdUtilisateur == currentUser.Id);
            foreach (var ancienOTP in anciensOTPs)
            {
                db.otpcodes.Remove(ancienOTP);
            }
            db.SaveChanges();

            // Générer et envoyer un nouveau code
            string newOtpCode = otpCodesImpl.GenerateOTP(currentUser.Id);
            otpCodesImpl.SendOTP(currentUser.Telephone, newOtpCode);

            // Réinitialiser le timer
            StartExpirationTimer();

            // Réactiver le bouton de vérification
            btnVerifier.Enabled = true;

            MessageBox.Show("Un nouveau code de vérification a été envoyé.", "Code renvoyé", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void OTPCodeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Arrêter le timer lors de la fermeture du formulaire
            expirationTimer?.Stop();
        }



        private void OTPVerificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Arrêter le timer lors de la fermeture du formulaire
            expirationTimer.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var otpCode = db.otpcodes
                .Where(o => o.IdUtilisateur == currentUser.Id)
                .OrderByDescending(o => o.DateExpiration)
                .FirstOrDefault();

            if (otpCode != null)
            {
                TimeSpan timeLeft = otpCode.DateExpiration - DateTime.Now;

                if (timeLeft.TotalSeconds <= 0)
                {
                    expirationTimer.Stop();
                    labelExpiration.Text = "Code expiré";
                    labelExpiration.ForeColor = Color.Red;
                    btnVerifier.Enabled = false;
                }
                else
                {
                    //UpdateTimerDisplay(timeLeft);
                }
            }
        }

        private void UpdateTimerDisplay(TimeSpan timeLeft)
        {
            labelExpiration.Text = $"Expire dans: {timeLeft.Minutes:D2}:{timeLeft.Seconds:D2}";
        }

        private string MasquerNumero(string numero)
        {
            if (string.IsNullOrEmpty(numero) || numero.Length < 4)
                return numero;

            return "..." + numero.Substring(numero.Length - 4);
        }

    }
}
