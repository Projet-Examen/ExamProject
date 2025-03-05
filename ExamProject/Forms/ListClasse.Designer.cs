namespace ExamenProjetGestionEtudiant
{
    partial class ListClasse
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
            this.dataGridViewListClasse = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListClasse)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewListClasse);
            this.panel1.Location = new System.Drawing.Point(11, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 341);
            this.panel1.TabIndex = 0;
            // 
            // dataGridViewListClasse
            // 
            this.dataGridViewListClasse.AllowUserToAddRows = false;
            this.dataGridViewListClasse.AllowUserToDeleteRows = false;
            this.dataGridViewListClasse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListClasse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListClasse.Location = new System.Drawing.Point(44, 33);
            this.dataGridViewListClasse.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListClasse.Name = "dataGridViewListClasse";
            this.dataGridViewListClasse.ReadOnly = true;
            this.dataGridViewListClasse.RowHeadersWidth = 62;
            this.dataGridViewListClasse.RowTemplate.Height = 28;
            this.dataGridViewListClasse.Size = new System.Drawing.Size(615, 290);
            this.dataGridViewListClasse.TabIndex = 0;
            // 
            // ListClasse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListClasse";
            this.Text = "ListClasse";
            this.Load += new System.EventHandler(this.ListClasse_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListClasse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewListClasse;
    }
}