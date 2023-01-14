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
    public partial class frmISReport : Form
    {
        public frmISReport()
        {
            InitializeComponent();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptTBTempTable", (DataTable)Reports.GetTB()), "BasicGL.rptTB.rdlc", new Microsoft.Reporting.WinForms.ReportParameter("p", dateTimePicker1.Value.ToString("yyyy/MM")));
            frv.Show();
        }
    }
}
