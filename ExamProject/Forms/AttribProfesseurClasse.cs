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
    public partial class AttribProfesseurClasse : Form
    {
        private int professeurId;
        public AttribProfesseurClasse(int id)
        {
            InitializeComponent();
            professeurId = id;
        }

        private void actualise()
        {
            DBExamenContext db = new DBExamenContext();

            cmbClasse.DataSource = db.classes.ToList();
            cmbClasse.DisplayMember = "NomClasse";
            cmbClasse.ValueMember = "Id";
            cmbClasse.SelectedIndex = -1;
            cmbClasse.Text = "choisir la classe...";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AttribProfesseurClasse_Load(object sender, EventArgs e)
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
                int classeId = Convert.ToInt32(cmbClasse.SelectedValue);
                int professeurId = this.professeurId;

                var classe = db.classes.Include("professeurs").FirstOrDefault(c => c.Id == classeId);
                var professeur = db.professeurs.Include("classes").FirstOrDefault(p => p.Id == professeurId);

                if (classe != null && professeur != null)
                {

                    if (!professeur.classes.Any(c => c.Id == classeId))
                    {
                        professeur.classes.Add(classe);
                        classe.professeurs.Add(professeur);
                        db.SaveChanges();
                        MessageBox.Show("Classe attribuée au professeur avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Cette classe est déjà attribuée à ce professeur !");
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