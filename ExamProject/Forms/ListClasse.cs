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
    public partial class ListClasse : Form
    {
        private int coursId;
        public ListClasse(int id)
        {
            InitializeComponent();

            coursId = id;
        }

        private void ListClasse_Load(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                var classes = db.classes
                                .Where(cl => cl.cours.Any(c => c.Id == coursId))
                                .Select(cl => new
                                {
                                    cl.Id,
                                    cl.NomClasse
                                })
                                .ToList();

                if (classes.Any())
                {
                    dataGridViewListClasse.DataSource = classes;
                }
                else
                {
                    MessageBox.Show("Aucune classe trouvée pour ce cours.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }
    }
}