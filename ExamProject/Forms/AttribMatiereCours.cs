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
    public partial class AttribMatiereCours : Form
    {
        private int courId;
        public AttribMatiereCours(int id)
        {
            InitializeComponent();
            courId = id;
        }

        private void AttribMatiereCours_Load(object sender, EventArgs e)
        {
            actualise();
        }

        private void actualise()
        {
            DBExamenContext db = new DBExamenContext();

            cmbMatiere.DataSource = db.matieres.ToList();
            cmbMatiere.DisplayMember = "NomMatiere";
            cmbMatiere.ValueMember = "Id";
            cmbMatiere.SelectedIndex = -1;
            cmbMatiere.Text = "choisir la matiere...";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddMat_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int matiereId = Convert.ToInt32(cmbMatiere.SelectedValue);
                int coursId = this.courId;

                var mat = db.matieres.Include("cours").FirstOrDefault(m => m.Id == matiereId);
                var cours = db.cours.Include("matieres").FirstOrDefault(c => c.Id == coursId);

                if (mat != null && cours != null)
                {
                    if (!mat.cours.Any(c => c.Id == courId))
                    {
                        mat.cours.Add(cours);
                        cours.matieres.Add(mat);
                        db.SaveChanges();
                        MessageBox.Show("Matière ajouté avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Cette matière est déjà attribué à ce cours !");
                    }

                }
                else
                {
                    MessageBox.Show("Erreur lors de l'attribution. Veuillez réessayer.");
                }
            }
        }
    }
}

