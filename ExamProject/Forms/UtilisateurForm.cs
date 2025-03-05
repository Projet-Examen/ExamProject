
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenProjetGestionEtudiant
{
    public partial class UtilisateurForm : Form
    {
        public UtilisateurForm()
        {
            InitializeComponent();
        }

        private void UtilisateurForm_Load(object sender, EventArgs e)
        {
            actualise();
        }

        private void actualise()
        {
            DBExamenContext db = new DBExamenContext();
            dataGridViewUser.DataSource = null;
            dataGridViewUser.DataSource = db.utilisateurs.ToList();
            txtNomUt.Text = string.Empty;
            txtMotDePasse.Text = string.Empty;
            txtTel.Text = string.Empty;
            cmbRole.SelectedIndex = -1;
            cmbRole.Text = "sélectionnez...";
            dataGridViewUser.DataSource = db.utilisateurs.Select(e => new { e.Id, e.NomUtilisateur, e.MotDePasse, e.Telephone, e.Role }).ToList();
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnSave.Visible = true;
        }

        private bool ValidationChamps()
        {
            bool estValide = true;
            if (String.IsNullOrEmpty(txtNomUt.Text))
            {

                errorProviderNomUser.SetError(txtNomUt, "Ce champ est obligatoire");
                estValide = false;
            }
            else
            {
                errorProviderNomUser.SetError(txtNomUt, "");
            }



            string patternTel = @"^(70|75|76|77|78)\d{7}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTel.Text, patternTel) || String.IsNullOrEmpty(txtTel.Text))
            {

                errorProviderTel.SetError(txtTel, "Le numéro incorrect!");
            }
            else
            {
                errorProviderTel.SetError(txtTel, "");
            }

            string password = txtMotDePasse.Text;


            string pattern = @"^(?=.*[A-Z])(?=.*[\W_]).+$";

            if (!Regex.IsMatch(password, pattern) || String.IsNullOrEmpty(password))
            {

                errorProviderPassword.SetError(txtMotDePasse, "Le mot de passe doit contenir au moins une majuscule et un caractère spécial !");
                estValide = false;
            }
            else
            {
                errorProviderPassword.SetError(txtMotDePasse, "");
            }


            return estValide;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidationChamps())
            {
                MessageBox.Show("Veuillez corriger les erreurs avant d'ajouter l'utilisateur.", "Erreur de validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (var db = new DBExamenContext())
            {
                try
                {
                    Utilisateur ut = new Utilisateur();
                    ut.NomUtilisateur = txtNomUt.Text;
                    string passwordHash = BCrypt.Net.BCrypt.HashPassword(txtMotDePasse.Text);
                    ut.MotDePasse = passwordHash;
                    ut.Role = cmbRole.Text;
                    ut.Telephone = txtTel.Text;
                    db.utilisateurs.Add(ut);
                    db.SaveChanges();
                    actualise();
                    MessageBox.Show("Utilisateur ajouté avec succés!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewUser.Rows.Count)
            {
                btnClear.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Visible = false;
                labelPassword.Visible = false;
                txtMotDePasse.Visible = false;
                btnResetPwd.Visible = true;
                if (Convert.ToInt32(dataGridViewUser.Rows[e.RowIndex].Cells["Id"].Value) is int id)
                {
                    using (var db = new DBExamenContext())
                    {
                        Utilisateur ut = db.utilisateurs.FirstOrDefault(u => u.Id == id);
                        if (ut != null)
                        {
                            txtId.Text = ut.Id.ToString();
                            txtNomUt.Text = ut.NomUtilisateur;
                            txtMotDePasse.Text = ut.MotDePasse;
                            cmbRole.Text = ut.Role;
                            txtTel.Text = ut.Telephone;
                        }
                        else
                        {
                            MessageBox.Show("Étudiant introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                try
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Utilisateur ut = db.utilisateurs.Find(id);
                    if (ut != null)
                    {
                        ut.NomUtilisateur = txtNomUt.Text;

                        ut.Role = cmbRole.Text;
                        ut.Telephone = txtTel.Text;
                        db.SaveChanges();
                        actualise();
                        btnSave.Visible = true;
                        btnResetPwd.Visible = false;
                        MessageBox.Show("Utilisateur Mise à jour avec succéss", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNomUt.Text = string.Empty;
                        txtMotDePasse.Text = string.Empty;
                        txtTel.Text = string.Empty;
                        cmbRole.Text = "sélectionnez le rôle...";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous vraiment supprimé cet utilisateur ", "Alerte!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (var db = new DBExamenContext())
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Utilisateur ut = db.utilisateurs.Find(id);
                    if (ut != null)
                    {
                        db.utilisateurs.Remove(ut);
                        db.SaveChanges();
                        btnSave.Enabled = true;
                        btnResetPwd.Visible = false;
                        MessageBox.Show("Utilisateur supprimée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualise();
                    }
                }
            }
        }

        private void btnResetPwd_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int id = Convert.ToInt32(txtId.Text);
                Utilisateur ut = db.utilisateurs.Find(id);
                if (ut != null)
                {
                    ResetPasswordForm resetForm = new ResetPasswordForm(id);
                    resetForm.ShowDialog();
                    actualise();
                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMotDePasse.Text = string.Empty;
            txtNomUt.Text = string.Empty;
            txtTel.Text = string.Empty;
            cmbRole.Text = string.Empty;
            btnSave.Enabled = true;
            btnResetPwd.Visible = false;
            actualise();
        }

        private void txtNomUt_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNomUt.Text))
            {
                e.Cancel = true;
                errorProviderNomUser.SetError(txtNomUt, "Ce champ est obligatoire");
            }
            else
            {
                errorProviderNomUser.SetError(txtNomUt, "");
            }
        }

        private void txtTel_Validating(object sender, CancelEventArgs e)
        {
            string pattern = @"^(70|75|76|77|78)\d{7}$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtTel.Text, pattern) || String.IsNullOrEmpty(txtTel.Text))
            {
                e.Cancel = true;
                errorProviderTel.SetError(txtTel, "Le numéro incorrect!");
            }
            else
            {
                errorProviderTel.SetError(txtTel, "");
            }
        }

        private void txtMotDePasse_Validating(object sender, CancelEventArgs e)
        {
            string password = txtMotDePasse.Text;


            string pattern = @"^(?=.*[A-Z])(?=.*[\W_]).+$";

            if (!Regex.IsMatch(password, pattern) || String.IsNullOrEmpty(password))
            {
                e.Cancel = true;
                txtMotDePasse.Focus();
                errorProviderPassword.SetError(txtMotDePasse, "Le mot de passe doit contenir au moins une majuscule et un caractère spécial !");
            }
            else
            {
                errorProviderPassword.SetError(txtMotDePasse, "");
            }
        }

        private void txtTel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
