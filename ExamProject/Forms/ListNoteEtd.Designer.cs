﻿using System.Windows.Forms;

namespace ExamProject.Forms
{
    partial class ListNoteEtd : Form
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
            this.dataGridViewListNote = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListNote)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewListNote
            // 
            this.dataGridViewListNote.AllowUserToAddRows = false;
            this.dataGridViewListNote.AllowUserToDeleteRows = false;
            this.dataGridViewListNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewListNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewListNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListNote.Location = new System.Drawing.Point(28, 97);
            this.dataGridViewListNote.Name = "dataGridViewListNote";
            this.dataGridViewListNote.ReadOnly = true;
            this.dataGridViewListNote.RowHeadersWidth = 51;
            this.dataGridViewListNote.RowTemplate.Height = 24;
            this.dataGridViewListNote.Size = new System.Drawing.Size(747, 320);
            this.dataGridViewListNote.TabIndex = 0;
            // 
            // ListNoteEtd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewListNote);
            this.Name = "ListNoteEtd";
            this.Text = "Liste des notes de l\'étudiant";
            this.Load += new System.EventHandler(this.ListNoteEtd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListNote)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListNote;
    }
}