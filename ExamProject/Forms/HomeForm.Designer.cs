using System.Windows.Forms;

namespace ExamenProjetGestionEtudiant
{

    partial class HomeForm : Form

    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Gestion des users");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Admin", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Classes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Cours");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Matières");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Professeurs");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Genérer les relevés de notes d\'un étudiant");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Générer la liste des étudiants par classe");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Générer la liste des meilleurs étudiants par classe");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Rapports", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Gestion", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("DE", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Gestion des étudiants");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Enregistrement des notes");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Agent", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panelDeconnexion = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelDeconnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1157, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelMain);
            this.tabPage1.Controls.Add(this.panelSidebar);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1149, 509);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.DarkGray;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(339, 5);
            this.panelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(806, 499);
            this.panelMain.TabIndex = 1;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.panelDeconnexion);
            this.panelSidebar.Controls.Add(this.treeView1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(4, 5);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(335, 499);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelDeconnexion
            // 
            this.panelDeconnexion.BackColor = System.Drawing.Color.Black;
            this.panelDeconnexion.Controls.Add(this.btnDeconnexion);
            this.panelDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeconnexion.Location = new System.Drawing.Point(0, 462);
            this.panelDeconnexion.Name = "panelDeconnexion";
            this.panelDeconnexion.Size = new System.Drawing.Size(335, 37);
            this.panelDeconnexion.TabIndex = 1;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Red;
            this.btnDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeconnexion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.Color.Snow;
            this.btnDeconnexion.Location = new System.Drawing.Point(-1, -8);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(336, 54);
            this.btnDeconnexion.TabIndex = 0;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseCompatibleTextRendering = true;
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(-4, -5);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NoeudGestionUser";
            treeNode1.Text = "Gestion des users";
            treeNode2.Name = "NoeudAdmin";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.Text = "Admin";
            treeNode3.Name = "NoeudGestionClasse";
            treeNode3.Text = "Classes";
            treeNode4.Name = "NoeudGestionCours";
            treeNode4.Text = "Cours";
            treeNode5.Name = "NoeudGestionMatieres";
            treeNode5.Text = "Matières";
            treeNode6.Name = "NoeudGestionProfesseur";
            treeNode6.Text = "Professeurs";
            treeNode7.Name = "NoeudRapportBulletin";
            treeNode7.Text = "Genérer les relevés de notes d\'un étudiant";
            treeNode8.Name = "NoeudRapportEtudiants";
            treeNode8.Text = "Générer la liste des étudiants par classe";
            treeNode9.Name = "NoeudRapportMeilleurEtudiant";
            treeNode9.Text = "Générer la liste des meilleurs étudiants par classe";
            treeNode10.Name = "Nœud10";
            treeNode10.Text = "Rapports";
            treeNode11.Name = "Nœud5";
            treeNode11.Text = "Gestion";
            treeNode12.Name = "NoeudDE";
            treeNode12.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode12.Text = "DE";
            treeNode13.Name = "NoeudGestionEtudiant";
            treeNode13.Text = "Gestion des étudiants";
            treeNode14.Name = "NoeudEnregNote";
            treeNode14.Text = "Enregistrement des notes";
            treeNode15.Name = "NoeudAgent";
            treeNode15.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode15.Text = "Agent";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode12,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(335, 457);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1149, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1157, 548);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HomeForm";
            this.Text = "Gestion Scolaire";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelDeconnexion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TreeView treeView1;
        private Panel panelDeconnexion;
        private Button btnDeconnexion;
    }
}