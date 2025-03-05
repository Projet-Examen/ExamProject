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
    public partial class ListCoursForm : Form
    {
        private int classeId;
        public ListCoursForm(int id)
        {
            InitializeComponent();
            classeId = id;
        }

        private void ListCoursForm_Load(object sender, EventArgs e)
        {
            ChargerCours();
        }

        private void ChargerCours()
        {
            using (var db = new DBExamenContext())
            {
                var classe = db.classes.Include("cours").FirstOrDefault(c => c.Id == classeId);

                if (classe != null)
                {

                    var coursListe = classe.cours.Select(c => new
                    {
                        c.Id,
                        c.NomCours,
                        c.Description
                    }).ToList();

                    dataGridViewListCours.DataSource = coursListe;
                }
                else
                {
                    MessageBox.Show("Aucune classe trouvée avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}