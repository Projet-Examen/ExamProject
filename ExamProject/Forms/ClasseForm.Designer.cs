using System.Windows.Forms;

namespace ExamenProjetGestionEtudiant
{
    partial class ClasseForm:Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClasseForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnListProfs = new System.Windows.Forms.Button();
            this.btnListCours = new System.Windows.Forms.Button();
            this.btnListEtd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbSpecialite = new System.Windows.Forms.ComboBox();
            this.cmbNiveau = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewClasse = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 562);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnListProfs);
            this.groupBox1.Controls.Add(this.btnListCours);
            this.groupBox1.Controls.Add(this.btnListEtd);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.cmbSpecialite);
            this.groupBox1.Controls.Add(this.cmbNiveau);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(395, 532);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formulaire";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(282, 351);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(106, 39);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Effacer";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnListProfs
            // 
            this.btnListProfs.Location = new System.Drawing.Point(195, 446);
            this.btnListProfs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListProfs.Name = "btnListProfs";
            this.btnListProfs.Size = new System.Drawing.Size(194, 39);
            this.btnListProfs.TabIndex = 12;
            this.btnListProfs.Text = "Liste professeurs";
            this.btnListProfs.UseVisualStyleBackColor = true;
            this.btnListProfs.Click += new System.EventHandler(this.btnListProfs_Click);
            // 
            // btnListCours
            // 
            this.btnListCours.Location = new System.Drawing.Point(10, 446);
            this.btnListCours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListCours.Name = "btnListCours";
            this.btnListCours.Size = new System.Drawing.Size(178, 39);
            this.btnListCours.TabIndex = 11;
            this.btnListCours.Text = "Liste des cours";
            this.btnListCours.UseVisualStyleBackColor = true;
            this.btnListCours.Click += new System.EventHandler(this.btnListCours_Click);
            // 
            // btnListEtd
            // 
            this.btnListEtd.Location = new System.Drawing.Point(10, 398);
            this.btnListEtd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnListEtd.Name = "btnListEtd";
            this.btnListEtd.Size = new System.Drawing.Size(378, 39);
            this.btnListEtd.TabIndex = 10;
            this.btnListEtd.Text = "Liste des étudiants";
            this.btnListEtd.UseVisualStyleBackColor = true;
            this.btnListEtd.Click += new System.EventHandler(this.btnListEtd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(140, 351);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 39);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Supprimer";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(10, 351);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 39);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Modifier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(10, 305);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(378, 39);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Ajouter";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbSpecialite
            // 
            this.cmbSpecialite.FormattingEnabled = true;
            this.cmbSpecialite.Items.AddRange(new object[] {
            "Génie Logiciel",
            "IAGE",
            "Réseaux Informatique",
            "Multimédia",
            "Finance Compta",
            "BAFA"});
            this.cmbSpecialite.Location = new System.Drawing.Point(223, 208);
            this.cmbSpecialite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSpecialite.Name = "cmbSpecialite";
            this.cmbSpecialite.Size = new System.Drawing.Size(172, 34);
            this.cmbSpecialite.TabIndex = 6;
            this.cmbSpecialite.SelectedIndexChanged += new System.EventHandler(this.cmbSpecialite_SelectedIndexChanged);
            // 
            // cmbNiveau
            // 
            this.cmbNiveau.FormattingEnabled = true;
            this.cmbNiveau.Items.AddRange(new object[] {
            "L1",
            "L2",
            "L3",
            "M1",
            "M2",
            "Doctorat"});
            this.cmbNiveau.Location = new System.Drawing.Point(16, 208);
            this.cmbNiveau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbNiveau.Name = "cmbNiveau";
            this.cmbNiveau.Size = new System.Drawing.Size(172, 34);
            this.cmbNiveau.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(182, 36);
            this.txtId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(141, 35);
            this.txtId.TabIndex = 4;
            this.txtId.Visible = false;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(16, 118);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.ReadOnly = true;
            this.txtNom.Size = new System.Drawing.Size(372, 35);
            this.txtNom.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(223, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Spécialité";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Niveau";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la classe";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewClasse);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(405, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 562);
            this.panel2.TabIndex = 1;
            // 
            // dataGridViewClasse
            // 
            this.dataGridViewClasse.AllowUserToAddRows = false;
            this.dataGridViewClasse.AllowUserToDeleteRows = false;
            this.dataGridViewClasse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClasse.Location = new System.Drawing.Point(7, 15);
            this.dataGridViewClasse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridViewClasse.Name = "dataGridViewClasse";
            this.dataGridViewClasse.ReadOnly = true;
            this.dataGridViewClasse.RowHeadersWidth = 51;
            this.dataGridViewClasse.RowTemplate.Height = 24;
            this.dataGridViewClasse.Size = new System.Drawing.Size(475, 532);
            this.dataGridViewClasse.TabIndex = 0;
            this.dataGridViewClasse.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewClasse_RowHeaderMouseDoubleClick);
            // 
            // ClasseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ClasseForm";
            this.Text = "Gestion Classes";
            this.Load += new System.EventHandler(this.ClasseForm_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClasse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbSpecialite;
        private System.Windows.Forms.ComboBox cmbNiveau;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewClasse;
        private System.Windows.Forms.Button btnListProfs;
        private System.Windows.Forms.Button btnListCours;
        private System.Windows.Forms.Button btnListEtd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
    }
}