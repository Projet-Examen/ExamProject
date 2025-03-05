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
    public partial class AjoutNoteForm : Form
    {
        public AjoutNoteForm()
        {
            InitializeComponent();
        }

        private void AjoutNoteForm_Load(object sender, EventArgs e)
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
            dataGridViewEtd.DataSource = db.etudiants.Select(e => new { e.Id, e.Matricule, e.Nom, e.Prenom, e.DateNaissance, e.Sexe, e.classe.NomClasse }).ToList();
            cmbMatiere.DataSource = db.matieres.ToList();
            cmbMatiere.DisplayMember = "NomMatiere";
            cmbMatiere.ValueMember = "Id";
            cmbMatiere.SelectedIndex = -1;
            cmbMatiere.Text = "Sélectionner la matière...";
            groupBox1.Visible = false;
        }

        private void dataGridViewEtd_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewEtd.Rows.Count)
            {
                groupBox1.Visible = true;
                if (Convert.ToInt32(dataGridViewEtd.Rows[e.RowIndex].Cells["Id"].Value) is int id)
                {
                    using (var db = new DBExamenContext())
                    {
                        Etudiant etd = db.etudiants.FirstOrDefault(c => c.Id == id);
                        if (etd != null)
                        {
                            txtId.Text = etd.Id.ToString();
                        }
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cmbMatiere.SelectedIndex = -1;
            txtNote.Text = string.Empty;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbMatiere.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtNote.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var db = new DBExamenContext())
            {
                int idEtudiant = int.Parse(txtId.Text);
                int idMatiere = (int)cmbMatiere.SelectedValue;
                float note;

                if (!float.TryParse(txtNote.Text, out note))
                {
                    MessageBox.Show("Veuillez saisir une note valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Notes nouvelleNote = new Notes
                {
                    IdEtudiant = idEtudiant,
                    IdMatiere = idMatiere,
                    Note = note
                };

                db.notes.Add(nouvelleNote);

                Etudiant etudiant = db.etudiants.Include("notes").FirstOrDefault(et => et.Id == idEtudiant);
                if (etudiant != null)
                {
                    etudiant.notes.Add(nouvelleNote);
                }

                db.SaveChanges();
                MessageBox.Show("Note enregistrée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                actualise();
                //cmbMatiere.SelectedIndex = -1;
                //txtNote.Text = "";
                //txtId.Text = "";
            }
        }

        private void cmbClasse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbClasse.SelectedIndex == -1)
                return;

            using (var db = new DBExamenContext())
            {

                //int idClasse = Convert.ToInt32(cmbClasse.SelectedValue);
                string classeName = cmbClasse.Text;

                var etudiantsFiltrés = db.etudiants
                    .Where(et => et.classe.NomClasse == classeName)
                    .Select(et => new
                    { et.Id, et.Matricule, et.Nom, et.Prenom, et.DateNaissance, et.Sexe, et.classe.NomClasse }).ToList();
                dataGridViewEtd.DataSource = etudiantsFiltrés;
            }
        }
    }
}