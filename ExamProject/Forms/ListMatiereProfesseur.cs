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
    public partial class ListMatiereProfesseur : Form
    {
        private int professeurId;
        public ListMatiereProfesseur(int id)
        {
            InitializeComponent();
            professeurId = id;

        }

        private void ListMatiereProfesseur_Load(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                var matieres = db.matieres
                                  .Where(m => m.professeurs.Any(p => p.Id == professeurId))
                                  .Select(m => new
                                  {
                                      m.Id,
                                      m.NomMatiere
                                  })
                                  .ToList();

                if (matieres.Any())
                {
                    dataGridViewMatiereProfesseurs.DataSource = matieres;
                }
                else
                {
                    MessageBox.Show("Aucune matière trouvée pour ce professeur.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}