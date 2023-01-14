using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicGL
{
    public partial class frmDR : Form
    {
        public frmDR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptJETempTable", (DataTable)Reports.GetJE(dateTimePicker1.Value)), "BasicGL.rptDailyTransctions.rdlc",new Microsoft.Reporting.WinForms.ReportParameter("p",dateTimePicker1.Value.ToString("yyyy/MM/dd")));
            frv.Show();
        }
    }
}
