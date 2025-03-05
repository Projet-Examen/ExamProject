using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamProject.Forms;

namespace ExamenProjetGestionEtudiant
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "📊 Dashboard";
            tabPage2.Text = "Liste ";
        }

        private void LoadFormInPanel(Form form)
        {

            panelMain.Controls.Clear();
            form.TopLevel = false;
            //form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            panelMain.Controls.Add(form);
            panelMain.Tag = form;
            form.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)

        {
            switch (e.Node.Name)
            {
                case "NoeudGestionUser":
                    LoadFormInPanel(new UtilisateurForm());
                    break;

                case "NoeudGestionClasse":
                    LoadFormInPanel(new ClasseForm());
                    break;
                case "NoeudGestionEtudiant":
                    LoadFormInPanel(new EtudiantForm());
                    break;
                case "NoeudGestionCours":
                    LoadFormInPanel(new CoursForm());
                    break;

                case "NoeudGestionMatieres":
                    LoadFormInPanel(new MatiereForm());
                    break;
                case "NoeudGestionProfesseur":
                    LoadFormInPanel(new ProfesseurForm());
                    break;
                case "NoeudEnregNote":
                    LoadFormInPanel(new AjoutNoteForm());
                    break;


            }
        }
    }
}