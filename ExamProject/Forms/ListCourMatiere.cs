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
    public partial class ListCourMatiere : Form
    {
        private int matId;
        public ListCourMatiere(int id)
        {
            InitializeComponent();
            matId = id;
        }

        private void ListCourMatiere_Load(object sender, EventArgs e)
        {
            ChargerCours();
        }

        private void ChargerCours()
        {
            using (var db = new DBExamenContext())
            {
                var matiere = db.matieres.Include("cours").FirstOrDefault(c => c.Id == matId);

                if (matiere != null)
                {

                    var coursListe = matiere.cours.Select(c => new
                    {
                        c.Id,
                        c.NomCours,
                        c.Description
                    }).ToList();

                    dataGridViewCours.DataSource = coursListe;
                }
                else
                {
                    MessageBox.Show("Aucune matière trouvée avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
