using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace BasicGL
{
    public partial class frmBSReport : Form
    {
        public frmBSReport()
        {
            InitializeComponent();
            PreParing();
        }

        private bool PreParing()
        {
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = dateTimePicker1.Value;
            return true;
        }

        private void frmBSReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptBSTempTable", (DataTable)Reports.GetBS(dateTimePicker1.Value)), "BasicGL.rptBS.rdlc");
                        frv.Show();
                        break;
                    }
                case 1:
                    {
                        frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptISTempTable", (DataTable)Reports.GetIS(dateTimePicker1.Value)), "BasicGL.rptIS.rdlc");
                        frv.Show();
                        break;
                    }
            }
        }
    }
}
