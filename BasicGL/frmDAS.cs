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
    public partial class frmDAS : Form
    {
        public frmDAS()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptDASTempTable", (DataTable)Reports.GetDAS((int)numericUpDown1.Value)), "BasicGL.rptDAS.rdlc");
            frv.Show();
        }
    }
}
