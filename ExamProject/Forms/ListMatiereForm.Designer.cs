using System.Windows.Forms;

namespace ExamenProjetGestionEtudiant
{
    partial class ListMatiereForm : Form
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
            this.dataGridViewListMatiere = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListMatiere)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridViewListMatiere);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(711, 361);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dataGridViewListMatiere
            // 
            this.dataGridViewListMatiere.AllowUserToAddRows = false;
            this.dataGridViewListMatiere.AllowUserToDeleteRows = false;
            this.dataGridViewListMatiere.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListMatiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListMatiere.Location = new System.Drawing.Point(3, 34);
            this.dataGridViewListMatiere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewListMatiere.Name = "dataGridViewListMatiere";
            this.dataGridViewListMatiere.ReadOnly = true;
            this.dataGridViewListMatiere.RowHeadersWidth = 62;
            this.dataGridViewListMatiere.RowTemplate.Height = 28;
            this.dataGridViewListMatiere.Size = new System.Drawing.Size(708, 327);
            this.dataGridViewListMatiere.TabIndex = 0;
            // 
            // ListMatiereForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ListMatiereForm";
            this.Text = "ListMatiereForm";
            this.Load += new System.EventHandler(this.ListMatiereForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListMatiere)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewListMatiere;
    }
}