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

namespace ExamenProjetGestionEtudiant
{
    public partial class CoursForm : Form
    {
        public CoursForm()
        {
            InitializeComponent();
        }

        private void CoursForm_Load(object sender, EventArgs e)
        {
            actualise();
        }

        private void actualise()
        {
            DBExamenContext db = new DBExamenContext();
            dataGridViewCours.DataSource = null;
            dataGridViewCours.DataSource = db.cours.ToList();
            txtNomCours.Text = "";
            txtDescription.Text = "";

            dataGridViewCours.DataSource = db.cours.Select(e => new { e.Id, e.NomCours, e.Description }).ToList();
            btnUpdate.Visible = false;
            btnAddMat.Visible = false;
            btnAtribCoursClasse.Visible = false;
            btnListeClasse.Visible = false;
            btnListMat.Visible = false;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                Cours cour = new Cours();
                cour.NomCours = txtNomCours.Text;
                cour.Description = txtDescription.Text;
                db.cours.Add(cour);
                db.SaveChanges();
                actualise();
                MessageBox.Show("Données ajoutées avec succés!");

            }
        }

        private void dataGridViewCours_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewCours.Rows.Count)
            {
                btnUpdate.Visible = true;
                btnAddMat.Visible = true;
                btnAtribCoursClasse.Visible = true;
                btnListeClasse.Visible = true;
                btnListMat.Visible = true;
                btnSave.Enabled = false;
                btnSave.Visible = false;

                if (Convert.ToInt32(dataGridViewCours.Rows[e.RowIndex].Cells["Id"].Value) is int id)
                {
                    using (var db = new DBExamenContext())
                    {
                        Cours cour = db.cours.FirstOrDefault(c => c.Id == id);
                        if (cour != null)
                        {
                            txtId.Text = cour.Id.ToString();
                            txtNomCours.Text = cour.NomCours;
                            txtDescription.Text = cour.Description;
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
                Cours cour = db.cours.Find(id);
                if (cour != null)
                {
                    cour.NomCours = txtNomCours.Text;
                    cour.Description = txtDescription.Text;
                    db.SaveChanges();
                    actualise();
                    MessageBox.Show("Cour Mise à jour avec succéss", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //btnSave.Enabled = true;
                    btnSave.Visible = true;
                }
            }
        }

        private void btnListeClasse_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int idCour = Convert.ToInt32(txtId.Text);
                ListClasse forme = new ListClasse(idCour);
                forme.ShowDialog();
            }
        }




        private void btnAtribCoursClasse_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int idCour = Convert.ToInt32(txtId.Text);
                AttribCourClasseForm form = new AttribCourClasseForm(idCour);
                form.ShowDialog();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddMat_Click(object sender, EventArgs e)
        {
            int coursId = Convert.ToInt32(txtId.Text);

            AttribMatiereCours form = new AttribMatiereCours(coursId);
            form.ShowDialog();

        }

        private void btnListMat_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int idCours = Convert.ToInt32(txtId.Text);
                ListMatiereForm listeMatiere = new ListMatiereForm(idCours);
                listeMatiere.ShowDialog();
            }

        }
    }
}