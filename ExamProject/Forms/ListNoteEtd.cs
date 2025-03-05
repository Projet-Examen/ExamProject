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
    public partial class ListNoteEtd : Form
    {
        private int idEtd;
        public ListNoteEtd(int id)
        {
            InitializeComponent();
            idEtd = id;
        }

        private void ListNoteEtd_Load(object sender, EventArgs e)
        {
            chargeNoteEtd();
        }

        private void chargeNoteEtd()
        {
            using(var db = new DBExamenContext())
            {
                int idEtd = this.idEtd;
                var notes = db.notes
                                  .Where(n => n.IdEtudiant == idEtd)
                                  .Select(n => new
                                  {
                                      n.Id,
                                      n.matiere.NomMatiere,
                                      n.Note

                                  })
                                  .ToList();


                if (notes.Any())
                {
                    dataGridViewListNote.DataSource = notes;
                }
                else
                {
                    MessageBox.Show("Aucune note trouvé pour cet étudiant.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
