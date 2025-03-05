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
    public partial class AttribCourClasseForm : Form
    {
        private int courId;
        public AttribCourClasseForm(int id)
        {
            InitializeComponent();
            courId = id;
        }

        private void AttribCourClasseForm_Load(object sender, EventArgs e)
        {
            actualise();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAttrib_Click(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                int classeId = Convert.ToInt32(cmbClasse.SelectedValue);
                int coursId = this.courId;

                var classe = db.classes.Include("cours").FirstOrDefault(c => c.Id == classeId);
                var cours = db.cours.Include("classes").FirstOrDefault(c => c.Id == coursId);

                if (classe != null && cours != null)
                {
                    if (!classe.cours.Any(c => c.Id == courId))
                    {
                        classe.cours.Add(cours);
                        cours.classes.Add(classe);
                        db.SaveChanges();
                        MessageBox.Show("Cours attribué avec succès !");
                    }
                    else
                    {
                        MessageBox.Show("Ce cours est déjà attribué à cette classe !");
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