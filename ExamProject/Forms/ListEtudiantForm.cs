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
    public partial class ListEtudiantForm : Form
    {
        private int classeId;
        public ListEtudiantForm(int id)
        {
            InitializeComponent();
            classeId = id;
        }



        private void ListEtudiantForm_Load(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                var etudiants = db.etudiants
                                  .Where(et => et.IdClasse == classeId)
                                  .Select(et => new
                                  {
                                      et.Id,
                                      et.Matricule,
                                      et.Nom,
                                      et.Prenom,
                                      et.Sexe,
                                      et.DateNaissance
                                  })
                                  .ToList();


                if (etudiants.Any())
                {
                    dataGridViewListEtd.DataSource = etudiants;
                }
                else
                {
                    MessageBox.Show("Aucun étudiant trouvé pour cette classe.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}