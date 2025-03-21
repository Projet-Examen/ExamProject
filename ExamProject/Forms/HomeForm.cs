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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ExamenProjetGestionEtudiant
{
    public partial class HomeForm : Form
    {
        private Utilisateur utilisateur;

        public HomeForm(Utilisateur user)
        {
            InitializeComponent();
            utilisateur = user;
        }

        //public HomeForm()
        //{
        //    InitializeComponent();
        //}

        private void HomeForm_Load(object sender, EventArgs e)
        {
            tabPage1.Text = "Dashboard";

            // Créer une liste pour stocker les nœuds à conserver selon le rôle
            List<string> noeudsAutorises = new List<string>();

            // Définir les nœuds autorisés selon le rôle de l'utilisateur
            switch (utilisateur.Role)
            {
                case "Agent":
                    // Ajouter ici les nœuds spécifiques à l'Agent
                    noeudsAutorises.Add("NoeudAgent");
                    // Vous pouvez ajouter d'autres nœuds autorisés pour l'Agent si nécessaire
                    break;

                case "DE":
                    // Ajouter ici les nœuds spécifiques au DE
                    noeudsAutorises.Add("NoeudDE");
                    // Vous pouvez ajouter d'autres nœuds autorisés pour le DE si nécessaire
                    break;

                case "Admin":
                    // L'Admin a accès à tous les nœuds, donc on ne filtre pas
                    // On peut simplement retourner pour ne pas effectuer la suppression
                    return;

                default:
                    // Pour tout autre rôle non défini, ne rien faire ou définir un comportement par défaut
                    break;
            }

            // Si nous avons une liste de nœuds autorisés (c'est-à-dire que l'utilisateur n'est pas Admin)
            if (noeudsAutorises.Count > 0)
            {
                // Créer une liste temporaire pour stocker les nœuds à supprimer
                List<TreeNode> noeudsASupprimer = new List<TreeNode>();

                // Parcourir tous les nœuds et ajouter ceux qui ne sont pas autorisés à la liste de suppression
                foreach (TreeNode node in treeView1.Nodes)
                {
                    if (!noeudsAutorises.Contains(node.Name))
                    {
                        noeudsASupprimer.Add(node);
                    }
                }

                // Supprimer tous les nœuds non autorisés
                foreach (TreeNode nodeToRemove in noeudsASupprimer)
                {
                    treeView1.Nodes.Remove(nodeToRemove);
                }
            }
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
                case "NoeudRapportEtudiants":
                    LoadFormInPanel(new FormEtudiantClasseRapport());
                    break;
                case "NoeudRapportMeilleurEtudiant":
                    LoadFormInPanel(new FormMeilleurEtudiants());
                    break;
                case "NoeudRapportBulletin":
                    LoadFormInPanel(new FormBulletin2());
                    break;
            }
        }

        private void btnDeconnexion_Click(object sender, EventArgs e)
        {
            this.Close();
            ConnexionForm frm = new ConnexionForm();
            frm.Show();
        }
    }
}