using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamProject.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace ExamenProjetGestionEtudiant
{
    public partial class EtudiantForm : Form
    {
        public EtudiantForm()
        {
            InitializeComponent();
        }

        private void EtudiantForm_Load(object sender, EventArgs e)
        {
            actualise();
        }

        private void actualise()
        {
            DBExamenContext db = new DBExamenContext();
            dataGridViewEtudiant.DataSource = null;
            dataGridViewEtudiant.DataSource = db.classes.ToList();
            cmbClasse.DataSource = db.classes.ToList();
            cmbClasse.DisplayMember = "NomClasse";
            cmbClasse.ValueMember = "Id";
            cmbClasse.SelectedIndex = -1;
            cmbClasse.Text = "choisir la classe...";
            dataGridViewEtudiant.DataSource = db.etudiants.Select(e => new { Id = e.Id, Matricule = e.Matricule, Nom = e.Nom, Prenom = e.Prenom, Date_Naissance = e.DateNaissance, Sexe = e.Sexe, Adresse = e.Adresse, Tel = e.Telephone, Email = e.Email, Classe = e.classe.NomClasse }).ToList();

            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnListNote.Visible = false;
            btnSave.Enabled = true;
            btnSave.Visible = true;
        }

        private string GenererMatricule(string nomClasse)
        {
            // Formater le nom de la classe
            string[] mots = nomClasse.Split(' ');
            string codeClasse = mots[0]; // Premier mot complet
            if (mots.Length > 1)
            {
                for (int i = 1; i < mots.Length; i++)
                {
                    if (i == 1 || i == 2) // On prend les initiales des deux mots suivants
                        codeClasse += mots[i][0];
                }
            }

            Random random = new Random();
            int randomId = random.Next(1000, 9999); // Générer un ID entre 1000 et 9999
            return $"ET@{codeClasse}{randomId}";
        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                try
                {
                    if (cmbClasse.SelectedIndex == -1)
                    {
                        MessageBox.Show("Veuillez sélectionner une classe.");
                        return;
                    }

                    Etudiant etd = new Etudiant();
                    etd.Matricule = txtMatricule.Text;
                    etd.Nom = txtNom.Text;
                    etd.Prenom = txtPrenom.Text;
                    etd.DateNaissance = dateTimeN.Value.Date;
                    etd.Sexe = radioButtonM.Checked ? "M" : "F";
                    etd.Adresse = txtAdresse.Text;
                    etd.Email = txtEmail.Text;
                    etd.Telephone = txtTel.Text;
                    etd.IdClasse = Convert.ToInt32(cmbClasse.SelectedValue);
                    //etd.classe = db.classes.FirstOrDefault(c => c.Id == etd.IdClasse);
                    etd.classe = db.classes.Include("etudiants").FirstOrDefault(c => c.Id == etd.IdClasse);

                    if (etd.classe != null)
                    {
                        etd.classe.etudiants.Add(etd);
                    }
                    db.etudiants.Add(etd);
                    db.SaveChanges();
                    MessageBox.Show("Classe ajouté avec succéss", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualise();
                    clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridViewEtudiant_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewEtudiant.Rows.Count)
            {
                btnClear.Enabled = true;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
                btnClear.Visible = true;
                btnDelete.Visible = true;
                btnListNote.Visible = true;
                btnEdit.Visible = true;
                btnSave.Enabled = false;
                btnSave.Visible = false;
                if (Convert.ToInt32(dataGridViewEtudiant.Rows[e.RowIndex].Cells["Id"].Value) is int id)
                {
                    using (var db = new DBExamenContext())
                    {
                        Etudiant etd = db.etudiants.FirstOrDefault(c => c.Id == id);
                        if (etd != null)
                        {
                            txtId.Text = etd.Id.ToString();
                            txtMatricule.Text = etd.Matricule;
                            txtAdresse.Text = etd.Adresse;
                            txtEmail.Text = etd.Email;
                            txtTel.Text = etd.Telephone;
                            txtNom.Text = etd.Nom;
                            txtPrenom.Text = etd.Prenom;
                            dateTimeN.Value = etd.DateNaissance;
                            if (etd.Sexe == "M")
                            {
                                radioButtonM.Checked = true;
                                radioButtonF.Checked = false;
                            }
                            else
                            {
                                radioButtonM.Checked = false; radioButtonF.Checked = true;
                            }
                            Classe classe = db.classes.FirstOrDefault(c => c.Id == etd.IdClasse);
                            if (classe != null)
                            {
                                cmbClasse.Text = classe.NomClasse;
                            }
                        }
                    }
                }
            }
        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {

            txtMatricule.Text = GenererMatricule(cmbClasse.Text);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int id = Convert.ToInt32(txtId.Text);
                Etudiant etd = db.etudiants.Find(id);
                if (etd != null)
                {

                    etd.Matricule = txtMatricule.Text;
                    etd.Nom = txtNom.Text;
                    etd.Prenom = txtPrenom.Text;
                    etd.DateNaissance = dateTimeN.Value.Date;
                    etd.Sexe = radioButtonM.Checked ? "M" : "F";
                    etd.Adresse = txtAdresse.Text;
                    etd.Email = txtEmail.Text;
                    etd.Telephone = txtTel.Text;
                    etd.IdClasse = Convert.ToInt32(cmbClasse.SelectedValue);
                    etd.classe = db.classes.FirstOrDefault(c => c.Id == etd.IdClasse);
                    if (etd.classe != null)
                    {
                        etd.classe.etudiants.Add(etd);
                    }
                    int ancienneClasseId = etd.IdClasse;

                    if (ancienneClasseId != etd.IdClasse)
                    {

                        Classe ancienneClasse = db.classes.FirstOrDefault(c => c.Id == ancienneClasseId);
                        if (ancienneClasse != null)
                        {
                            ancienneClasse.etudiants.Remove(etd);
                        }
                    }
                    db.SaveChanges();
                    MessageBox.Show("Etudiant mise à jour avec succés", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    actualise();
                    clear();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                if (MessageBox.Show("Voulez vous vraiment supprimé cet étudiant ", "Alerte!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Etudiant etd = db.etudiants.Find(id);
                    if (etd != null)
                    {
                        db.etudiants.Remove(etd);
                        db.SaveChanges();
                        MessageBox.Show("Etudiant supprimée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualise();
                        clear();
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtMatricule.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            cmbClasse.SelectedIndex = -1;
            radioButtonM.Checked = false;
            radioButtonF.Checked = false;
        }

        private void btnListNote_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int idEtd = Convert.ToInt32(txtId.Text);
                ListNoteEtd list = new ListNoteEtd(idEtd);
                list.ShowDialog();
            }
        }
    }
}