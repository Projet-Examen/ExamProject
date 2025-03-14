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

namespace ExamProject.Forms
{
    public partial class FormEtudiantClasseRapport : Form
    {
        public FormEtudiantClasseRapport()
        {
            InitializeComponent();
        }

        private void FormEtudiantClasseRapport_Load(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load(@"C:\Users\HP\source\repos\ExamProject\ExamProject\EtudiantClass.rpt");
            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
