using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ExamProject.Forms
{
    public partial class FormMeilleurEtudiants : Form
    {
        public FormMeilleurEtudiants()
        {
            InitializeComponent();
        }
        private void LoadMeilleursEtudiants()
        {
            try
            {
                ReportDocument report = new ReportDocument();
                report.Load(@"C:\Users\HP\source\repos\ExamProject\ExamProject\RapportMeilleursEtudiants.rpt");

                TableLogOnInfo logonInfo = new TableLogOnInfo();
                logonInfo.ConnectionInfo.ServerName = "DESKTOP-KP72K0I";
                logonInfo.ConnectionInfo.DatabaseName = "ExamProjectDB";
                logonInfo.ConnectionInfo.IntegratedSecurity = true;

                foreach (Table table in report.Database.Tables)
                {
                    table.ApplyLogOnInfo(logonInfo);
                }

                crystalReportViewer1.ReportSource = report;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement du rapport : " + ex.Message);
            }
        }


        private void FormMeilleurEtudiants_Load(object sender, EventArgs e)
        {
            LoadMeilleursEtudiants();

        }
    }
}
