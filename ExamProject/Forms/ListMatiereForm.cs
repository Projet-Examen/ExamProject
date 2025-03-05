using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace ExamenProjetGestionEtudiant
{
    public partial class ListMatiereForm : Form
    {
        private int coursId;
        public ListMatiereForm(int id)
        {
            InitializeComponent();
            coursId = id;
        }

        private void ListMatiereForm_Load(object sender, EventArgs e)
        {

            using (var db = new DBExamenContext())
            {
                var matieres = db.matieres
                                 .Where(m => m.cours.Any(c => c.Id == coursId)) 
                                 .Select(m => new
                                 {
                                     m.Id,
                                     m.NomMatiere
                                 })
                                 .ToList();

                if (matieres.Any())
                {
                    dataGridViewListMatiere.DataSource = matieres; 
                }
                else
                {
                    MessageBox.Show("Aucune matière trouvée pour ce cours.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}