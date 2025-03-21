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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Gestion des users");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Espace Administrateur", new System.Windows.Forms.TreeNode[] {
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
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Espace DE", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Gestion des étudiants");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Enregistrement des notes");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Espace Agent", new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode14});
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDeconnexion = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelMain);
            this.tabPage1.Controls.Add(this.panelSidebar);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(1149, 512);
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
            this.panelMain.Size = new System.Drawing.Size(806, 502);
            this.panelMain.TabIndex = 1;
            // 
            // panelSidebar
            // 
            this.panelSidebar.Controls.Add(this.panel1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(4, 5);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(335, 502);
            this.panelSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnDeconnexion);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 496);
            this.panel1.TabIndex = 2;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Red;
            this.btnDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeconnexion.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeconnexion.ForeColor = System.Drawing.Color.Snow;
            this.btnDeconnexion.Location = new System.Drawing.Point(0, 447);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(331, 49);
            this.btnDeconnexion.TabIndex = 0;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseCompatibleTextRendering = true;
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            this.btnDeconnexion.Click += new System.EventHandler(this.btnDeconnexion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(331, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.Color.Navy;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(4, 207);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "NoeudGestionUser";
            treeNode1.Text = "Gestion des users";
            treeNode2.Name = "NoeudAdmin";
            treeNode2.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode2.Text = "Espace Administrateur";
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
            treeNode12.Text = "Espace DE";
            treeNode13.Name = "NoeudGestionEtudiant";
            treeNode13.Text = "Gestion des étudiants";
            treeNode14.Name = "NoeudEnregNote";
            treeNode14.Text = "Enregistrement des notes";
            treeNode15.Name = "NoeudAgent";
            treeNode15.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode15.Text = "Espace Agent";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode12,
            treeNode15});
            this.treeView1.Size = new System.Drawing.Size(320, 226);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1157, 548);
            this.tabControl1.TabIndex = 0;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
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
            this.tabPage1.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabPage tabPage1;
        private Panel panelMain;
        private Panel panelSidebar;
        private Button btnDeconnexion;
        private TreeView treeView1;
        private TabControl tabControl1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}