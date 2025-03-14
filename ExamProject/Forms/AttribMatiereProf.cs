using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenProjetGestionEtudiant
{
    public partial class AttribMatiereProf : Form
    {
        private int profId;
        public AttribMatiereProf(int id)
        {
            InitializeComponent();
            profId = id;
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

        private void AttribMatiereProf_Load(object sender, EventArgs e)
        {
            actualise();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAttrib_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int matiereId = Convert.ToInt32(cmbMatiere.SelectedValue);
                int professeurId = this.profId;

                var professeur = db.professeurs.Include("matieres").FirstOrDefault(p => p.Id == professeurId);
                var matiere = db.matieres.Include("professeurs").FirstOrDefault(m => m.Id == matiereId);

                if (professeur != null && matiere != null)
                {
                    if (!professeur.matieres.Any(m => m.Id == matiereId))
                    {
                        professeur.matieres.Add(matiere);
                        matiere.professeurs.Add(professeur);
                        db.SaveChanges();
                        MessageBox.Show("Matière attribuée au professeur avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Cette matière est déjà attribuée à ce professeur !");
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