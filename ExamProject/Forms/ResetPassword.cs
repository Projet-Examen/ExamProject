using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProjetGestionEtudiant
{
    public partial class ResetPasswordForm : Form
    {
        private int utilisateurId;
        public ResetPasswordForm(int id)
        {
            InitializeComponent();
            utilisateurId = id;
        }

        private void ResetPasswordForm_Load(object sender, EventArgs e)
        {

        }

        private bool ValidationChamps()
        {
            bool estValide = true;

            if (string.IsNullOrEmpty(txtAncienPassword.Text))
            {
                errorProviderAncienPwd.SetError(txtAncienPassword, "Veuillez entrer votre ancien mot de passe !");
                estValide = false;
            }
            else
            {
                errorProviderAncienPwd.SetError(txtAncienPassword, "");
            }


            string pattern = @"^(?=.*[A-Z])(?=.*[\W_]).+$";
            if (string.IsNullOrEmpty(txtNewPassword.Text) || !Regex.IsMatch(txtNewPassword.Text, pattern))
            {
                errorProviderNewPwd.SetError(txtNewPassword, "Le mot de passe doit contenir au moins une majuscule et un caractère spécial !");
                estValide = false;
            }
            else
            {
                errorProviderNewPwd.SetError(txtNewPassword, "");
            }

            if (txtNewPassword.Text != txtConfirmNewPassword.Text)
            {
                errorProviderConfirmPwd.SetError(txtConfirmNewPassword, "Les mots de passe ne correspondent pas !");
                estValide = false;
            }
            else
            {
                errorProviderConfirmPwd.SetError(txtConfirmNewPassword, "");
            }

            return estValide;
        }


        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            if (!ValidationChamps())
            {
                MessageBox.Show("Veuillez corriger les erreurs avant de mettre à jour le mot de passe.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBExamenContext())
            {
                Utilisateur ut = db.utilisateurs.Find(utilisateurId);
                if (ut != null)
                {
                    //if (string.IsNullOrEmpty(txtAncienPassword.Text) || string.IsNullOrEmpty(txtNewPassword.Text) || string.IsNullOrEmpty(txtConfirmNewPassword.Text))
                    //{
                    //    MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}

                    //if (!BCrypt.Net.BCrypt.Verify(txtAncienPassword.Text, ut.MotDePasse.ToString()))
                    //{
                    //    MessageBox.Show("Mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}

                    //if (txtNewPassword.Text != txtConfirmNewPassword.Text)
                    //{
                    //    MessageBox.Show("Les nouveaux mots de passe ne correspondent pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}

                    ut.MotDePasse = BCrypt.Net.BCrypt.HashPassword(txtNewPassword.Text);
                    db.SaveChanges();
                    MessageBox.Show("Mot de passe mis à jour avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAncienPassword_Validating(object sender, CancelEventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                Utilisateur ut = db.utilisateurs.Find(utilisateurId);
                if (string.IsNullOrWhiteSpace(txtAncienPassword.Text))
                {
                    errorProviderAncienPwd.SetError(txtAncienPassword, "Veuillez entrer votre ancien mot de passe !");
                    e.Cancel = true;
                }
                else if ((!BCrypt.Net.BCrypt.Verify(txtAncienPassword.Text, ut.MotDePasse.ToString())))
                {
                    errorProviderAncienPwd.SetError(txtAncienPassword, "Mot de passe incorrect!");
                    e.Cancel = true;
                }
                else
                {
                    errorProviderAncienPwd.SetError(txtAncienPassword, "");
                }
            }

        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*[\W_]).+$";

            if (string.IsNullOrEmpty(txtNewPassword.Text))
            {
                errorProviderNewPwd.SetError(txtNewPassword, "Veuillez entrer un nouveau mot de passe !");
                e.Cancel = true;
            }
            else if (!Regex.IsMatch(txtNewPassword.Text, pattern))
            {
                errorProviderNewPwd.SetError(txtNewPassword, "Le mot de passe doit contenir au moins une majuscule et un caractère spécial !");
                e.Cancel = true;
            }
            else
            {
                errorProviderNewPwd.SetError(txtNewPassword, "");
            }
        }

        private void txtConfirmNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmNewPassword.Text))
            {
                errorProviderConfirmPwd.SetError(txtConfirmNewPassword, "Veuillez confirmer le mot de passe !");
                e.Cancel = true;
            }
            else if (txtConfirmNewPassword.Text != txtNewPassword.Text)
            {
                errorProviderConfirmPwd.SetError(txtConfirmNewPassword, "Les mots de passe ne correspondent pas !");
                e.Cancel = true;
            }
            else
            {
                errorProviderConfirmPwd.SetError(txtConfirmNewPassword, "");
            }
        }
    }
}