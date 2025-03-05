using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenProjetGestionEtudiant
{
    public partial class ClasseForm : Form
    {
        public ClasseForm()
        {
            InitializeComponent();
        }

        private void ClasseForm_Load(object sender, EventArgs e)
        {
            actualise();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                Classe classe = new Classe();
                classe.NomClasse = txtNom.Text;
                db.classes.Add(classe);
                db.SaveChanges();
                actualise();
                MessageBox.Show("Données ajoutées avec succés!");

            }
        }

        private void actualise()
        {
            DBExamenContext db = new DBExamenContext();
            dataGridViewClasse.DataSource = null;
            dataGridViewClasse.DataSource = db.classes.ToList();
            txtNom.Text = "";
            cmbNiveau.Text = "selectionner";
            cmbSpecialite.Text = "sélectionner";
            dataGridViewClasse.DataSource = db.classes.Select(e => new { Id = e.Id, Nom_Classe = e.NomClasse }).ToList();
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnListCours.Visible = false;
            btnListEtd.Visible = false;
            btnListProfs.Visible = false;
        }

        private void cmbSpecialite_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNom.Text = cmbNiveau.Text + " " + cmbSpecialite.Text;
        }

        private void dataGridViewClasse_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewClasse.Rows.Count)
            {
                btnClear.Enabled = true;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
                btnClear.Visible = true;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;
                btnSave.Enabled = false;
                btnSave.Visible = false;
                btnListEtd.Visible = true;
                btnListProfs.Visible = true;
                btnListCours.Visible = true;
                if (Convert.ToInt32(dataGridViewClasse.Rows[e.RowIndex].Cells["Id"].Value) is int id)
                {
                    using (var db = new DBExamenContext())
                    {
                        Classe cl = db.classes.FirstOrDefault(c => c.Id == id);
                        if (cl != null)
                        {
                            txtId.Text = cl.Id.ToString();
                            txtNom.Text = cl.NomClasse;
                            cmbNiveau.Text = "sélectionnez le niveau...";
                            cmbSpecialite.Text = "sélectionner la spécialité...";
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int id = Convert.ToInt32(txtId.Text);
                Classe cl = db.classes.Find(id);
                if (cl != null)
                {
                    cl.NomClasse = txtNom.Text;
                    db.SaveChanges();
                    actualise();
                    MessageBox.Show("Classe Mise à jour avec succéss", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSave.Enabled = true;
                    btnSave.Visible = true;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                if (MessageBox.Show("Voulez vous vraiment supprimé cette classe ", "Alerte!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(txtId.Text);
                    Classe classe = db.classes.Find(id);
                    if (classe != null)
                    {
                        db.classes.Remove(classe);
                        db.SaveChanges();
                        MessageBox.Show("Classe supprimée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualise();
                    }
                }
            }
        }

        private void btnListEtd_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int idClasse = Convert.ToInt32(txtId.Text);
                ListEtudiantForm listeForm = new ListEtudiantForm(idClasse);
                listeForm.ShowDialog();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            txtNom.Text = string.Empty;
            cmbNiveau.SelectedIndex = -1;
            cmbSpecialite.SelectedIndex = -1;
        }

        private void btnListCours_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int idClasse = Convert.ToInt32(txtId.Text);
                ListCoursForm listeForm = new ListCoursForm(idClasse);
                listeForm.ShowDialog();
            }
        }

        private void btnListProfs_Click(object sender, EventArgs e)
        {

        }
    }
}