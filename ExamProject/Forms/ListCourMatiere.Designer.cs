namespace ExamProject.Forms
{
    partial class ListCourMatiere
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
            this.dataGridViewCours = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCours)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCours
            // 
            this.dataGridViewCours.AllowUserToAddRows = false;
            this.dataGridViewCours.AllowUserToDeleteRows = false;
            this.dataGridViewCours.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCours.Location = new System.Drawing.Point(12, 100);
            this.dataGridViewCours.Name = "dataGridViewCours";
            this.dataGridViewCours.ReadOnly = true;
            this.dataGridViewCours.RowHeadersWidth = 51;
            this.dataGridViewCours.RowTemplate.Height = 24;
            this.dataGridViewCours.Size = new System.Drawing.Size(776, 338);
            this.dataGridViewCours.TabIndex = 0;
            // 
            // ListCourMatiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCours);
            this.Name = "ListCourMatiere";
            this.Text = "Liste des cours associés à cette matière";
            this.Load += new System.EventHandler(this.ListCourMatiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCours)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCours;
    }
}