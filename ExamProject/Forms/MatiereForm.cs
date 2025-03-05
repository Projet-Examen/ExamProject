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

namespace ExamProject.Forms
{
    public partial class MatiereForm : Form
    {
        public MatiereForm()
        {
            InitializeComponent();
        }

        private void MatiereForm_Load(object sender, EventArgs e)
        {
            actualise();
        }

        private void actualise()
        {
            DBExamenContext db = new DBExamenContext();
            dataGridViewMatiere.DataSource = null;
            dataGridViewMatiere.DataSource = db.matieres.ToList();
            txtNomMat.Text = "";
            dataGridViewMatiere.DataSource = db.matieres.Select(e => new { e.Id,  e.NomMatiere }).OrderBy(e => e.Id).ToList();
            btnClear.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnListCours.Visible = false;
            btnSave.Visible = true;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                Matiere mat = new Matiere();
                mat.NomMatiere = txtNomMat.Text;
                db.matieres.Add(mat);
                db.SaveChanges();
                actualise();
                MessageBox.Show("Données ajoutées avec succés!");

            }
        }

        private void dataGridViewMatiere_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewMatiere.Rows.Count)
            {
                btnClear.Visible = true;
                btnDelete.Visible = true;
                btnEdit.Visible = true;
                btnListCours.Visible = true;
                btnSave.Visible = false;
                if (Convert.ToInt32(dataGridViewMatiere.Rows[e.RowIndex].Cells["Id"].Value) is int id)
                {
                    using (var db = new DBExamenContext())
                    {
                        Matiere mat = db.matieres.FirstOrDefault(m => m.Id == id);
                        if (mat != null)
                        {
                            txtId.Text = mat.Id.ToString();
                            txtNomMat.Text = mat.NomMatiere;
                        }
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int id = Convert.ToInt32(txtId.Text);
                Matiere mat = db.matieres.Find(id);
                if (mat != null)
                {
                    mat.NomMatiere = txtNomMat.Text;
                    db.SaveChanges();
                    actualise();
                    MessageBox.Show("Matière Mise à jour avec succéss", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   
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
                    Matiere mat = db.matieres.Find(id);
                    if (mat != null)
                    {
                        db.matieres.Remove(mat);
                        db.SaveChanges();
                        actualise();
                        MessageBox.Show("Matière supprimé avec succéss", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
        }

        private void btnListCours_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int matId = Convert.ToInt32(txtId.Text);
                ListCourMatiere listeForm = new ListCourMatiere(matId);
                listeForm.ShowDialog();
            }
        }
    }
}
