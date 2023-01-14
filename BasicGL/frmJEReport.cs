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
    public partial class frmJEReport : Form
    {
        public frmJEReport()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptTempTable", (DataTable)Reports.GetJEDocument((uint)numericUpDown1.Value)), "BasicGL.rptJE.rdlc");
            frv.Show();
        }
    }
}
