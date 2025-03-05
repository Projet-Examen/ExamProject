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
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Gestion des users");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Admin", new System.Windows.Forms.TreeNode[] {
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Classes");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Cours");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Matières");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Professeurs");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Genérer les relevés de notes d\'un étudiant");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Générer la liste des étudiants par classe");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Générer la liste des meilleurs étudiants par classe");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Rapports", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Gestion", new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode19,
            treeNode20,
            treeNode21,
            treeNode25});
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("DE", new System.Windows.Forms.TreeNode[] {
            treeNode26});
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Gestion des étudiants");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Enregistrement des notes");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Agent", new System.Windows.Forms.TreeNode[] {
            treeNode28,
            treeNode29});
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
            this.panelSidebar.Controls.Add(this.panelDeconnexion);
            this.panelSidebar.Controls.Add(this.treeView1);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(4, 5);
            this.panelSidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(335, 502);
            this.panelSidebar.TabIndex = 0;
            // 
            // panelDeconnexion
            // 
            this.panelDeconnexion.BackColor = System.Drawing.Color.Black;
            this.panelDeconnexion.Controls.Add(this.btnDeconnexion);
            this.panelDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDeconnexion.Location = new System.Drawing.Point(0, 465);
            this.panelDeconnexion.Name = "panelDeconnexion";
            this.panelDeconnexion.Size = new System.Drawing.Size(335, 37);
            this.panelDeconnexion.TabIndex = 1;
            // 
            // btnDeconnexion
            // 
            this.btnDeconnexion.BackColor = System.Drawing.Color.Firebrick;
            this.btnDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDeconnexion.Location = new System.Drawing.Point(-1, 0);
            this.btnDeconnexion.Name = "btnDeconnexion";
            this.btnDeconnexion.Size = new System.Drawing.Size(336, 37);
            this.btnDeconnexion.TabIndex = 0;
            this.btnDeconnexion.Text = "Déconnexion";
            this.btnDeconnexion.UseCompatibleTextRendering = true;
            this.btnDeconnexion.UseVisualStyleBackColor = false;
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView1.BackColor = System.Drawing.SystemColors.ControlText;
            this.treeView1.ForeColor = System.Drawing.SystemColors.Window;
            this.treeView1.LineColor = System.Drawing.Color.White;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            treeNode16.Name = "NoeudGestionUser";
            treeNode16.Text = "Gestion des users";
            treeNode17.Name = "NoeudAdmin";
            treeNode17.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode17.Text = "Admin";
            treeNode18.Name = "NoeudGestionClasse";
            treeNode18.Text = "Classes";
            treeNode19.Name = "NoeudGestionCours";
            treeNode19.Text = "Cours";
            treeNode20.Name = "NoeudGestionMatieres";
            treeNode20.Text = "Matières";
            treeNode21.Name = "NoeudGestionProfesseur";
            treeNode21.Text = "Professeurs";
            treeNode22.Name = "Nœud11";
            treeNode22.Text = "Genérer les relevés de notes d\'un étudiant";
            treeNode23.Name = "Nœud12";
            treeNode23.Text = "Générer la liste des étudiants par classe";
            treeNode24.Name = "Nœud13";
            treeNode24.Text = "Générer la liste des meilleurs étudiants par classe";
            treeNode25.Name = "Nœud10";
            treeNode25.Text = "Rapports";
            treeNode26.Name = "Nœud5";
            treeNode26.Text = "Gestion";
            treeNode27.Name = "NoeudDE";
            treeNode27.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode27.Text = "DE";
            treeNode28.Name = "NoeudGestionEtudiant";
            treeNode28.Text = "Gestion des étudiants";
            treeNode29.Name = "NoeudEnregNote";
            treeNode29.Text = "Enregistrement des notes";
            treeNode30.Name = "NoeudAgent";
            treeNode30.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode30.Text = "Agent";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode17,
            treeNode27,
            treeNode30});
            this.treeView1.Size = new System.Drawing.Size(335, 460);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(1149, 512);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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