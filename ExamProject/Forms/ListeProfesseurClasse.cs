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
    public partial class ListeProfesseurClasse : Form
    {
        private int ClassId;
        public ListeProfesseurClasse(int id)
        {
            InitializeComponent();
            this.ClassId = id;
        }

        private void ListeProfesseurClasse_Load(object sender, EventArgs e)
        {
            using (var db = new DBExamenContext())
            {
                var classe = db.classes.Include("professeurs").FirstOrDefault(c => c.Id == ClassId);

                if (classe != null)
                {
                    var professeursListe = classe.professeurs.Select(p => new
                    {
                        p.Id,
                        p.Nom,
                        p.Prenom,
                        p.Telephone,
                        p.Email
                    }).ToList();

                    dataGridViewProfesseurClasse.DataSource = professeursListe;
                }
                else
                {
                    MessageBox.Show("Aucune classe trouvée avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}