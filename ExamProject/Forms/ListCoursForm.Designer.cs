using System.Windows.Forms;

namespace ExamenProjetGestionEtudiant
{
    partial class ListCoursForm : Form
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
            this.dataGridViewListCours = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListCours
            // 
            this.dataGridViewListCours.AllowUserToAddRows = false;
            this.dataGridViewListCours.AllowUserToDeleteRows = false;
            this.dataGridViewListCours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListCours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListCours.Location = new System.Drawing.Point(21, 102);
            this.dataGridViewListCours.Name = "dataGridViewListCours";
            this.dataGridViewListCours.ReadOnly = true;
            this.dataGridViewListCours.RowHeadersWidth = 51;
            this.dataGridViewListCours.RowTemplate.Height = 24;
            this.dataGridViewListCours.Size = new System.Drawing.Size(767, 321);
            this.dataGridViewListCours.TabIndex = 0;
            // 
            // ListCoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewListCours);
            this.Name = "ListCoursForm";
            this.Text = "Liste des cours de cette classe";
            this.Load += new System.EventHandler(this.ListCoursForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListCours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListCours;
    }
}