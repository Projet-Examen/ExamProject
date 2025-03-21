using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenProjetGestionEtudiant;
using ExamProject.Entity;

namespace ExamProject.Forms
{
    public partial class ConnexionForm : Form
    {
        private Utilisateur currentUser;
        private string otpCode;
        OtpCodesImpl OtpCodesImpl = new OtpCodesImpl();
        public ConnexionForm()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '•';
        }

        private void ConnexionForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerifierCredentials(txtNomUser.Text, txtPassword.Text);
        }

        private void VerifierCredentials(string username, string password)
        {
            using (var db = new DBExamenContext())
            {
                var user = db.utilisateurs.FirstOrDefault(u => u.NomUtilisateur == username);
                try
                {
                    
                    if (user != null && BCrypt.Net.BCrypt.Verify(password, user.MotDePasse))
                    {
                        currentUser = user;
                        HomeForm homeForm = new HomeForm(currentUser);
                        this.Hide();
                        homeForm.Show();
                        //string phoneNumber = currentUser.Telephone;
                        //if (!phoneNumber.StartsWith("+221"))
                        //{
                        //    phoneNumber = "+221" + phoneNumber;
                        //}
                        //otpCode = OtpCodesImpl.GenerateOTP(user.Id);


                        //if (otpCode != null)
                        //{
                        //    OtpCodesImpl.SendOTP(phoneNumber, otpCode);

                        //    // Ouvrir le formulaire de vérification OTP
                        //    using (var otpForm = new OTPCodeForm(currentUser))
                        //    {
                        //        if (otpForm.ShowDialog() == DialogResult.OK)
                        //        {
                        //            // Authentification à deux facteurs réussie
                        //            MessageBox.Show("Authentification réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //            // Ouvrir le formulaire principal
                        //            HomeForm homeForm = new HomeForm(currentUser);
                        //            this.Hide();
                        //            homeForm.Show();
                        //        }
                        //        else
                        //        {
                        //            // L'authentification à deux facteurs a échoué ou a été annulée
                        //            MessageBox.Show("L'authentification à deux facteurs a échoué ou a été annulée.",
                        //                           "Échec de l'A2F", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //        }
                        //    }
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Erreur lors de la génération du code OTP.", "Erreur A2F", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                    }
                    else
                    {
                        MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect", "Échec de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Une erreur est survenue : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
