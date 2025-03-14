namespace ExamenProjetGestionEtudiant
{
    partial class ListMatiereProfesseur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewMatiereProfesseurs = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatiereProfesseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewMatiereProfesseurs);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewMatiereProfesseurs
            // 
            this.dataGridViewMatiereProfesseurs.AllowUserToAddRows = false;
            this.dataGridViewMatiereProfesseurs.AllowUserToDeleteRows = false;
            this.dataGridViewMatiereProfesseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatiereProfesseurs.Location = new System.Drawing.Point(19, 22);
            this.dataGridViewMatiereProfesseurs.Name = "dataGridViewMatiereProfesseurs";
            this.dataGridViewMatiereProfesseurs.ReadOnly = true;
            this.dataGridViewMatiereProfesseurs.RowHeadersWidth = 62;
            this.dataGridViewMatiereProfesseurs.RowTemplate.Height = 28;
            this.dataGridViewMatiereProfesseurs.Size = new System.Drawing.Size(732, 388);
            this.dataGridViewMatiereProfesseurs.TabIndex = 0;
            // 
            // ListMatiereProfesseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ListMatiereProfesseur";
            this.Text = "ListMatiereProfesseur";
            this.Load += new System.EventHandler(this.ListMatiereProfesseur_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatiereProfesseurs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewMatiereProfesseurs;
    }
}