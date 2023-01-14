using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Microsoft.Reporting;

namespace BasicGL
{
    public partial class frmReportViewer : Form
    {
        public frmReportViewer(Microsoft.Reporting.WinForms.ReportDataSource ds,string rs,Microsoft.Reporting.WinForms.ReportParameter p)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = rs;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.SetParameters(p);
            this.reportViewer1.LocalReport.DataSources.Add(ds);
        }

        public frmReportViewer(Microsoft.Reporting.WinForms.ReportDataSource ds, string rs)
        {
            InitializeComponent();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = rs;
            this.reportViewer1.LocalReport.DataSources.Clear();
        
            this.reportViewer1.LocalReport.DataSources.Add(ds);
        }

        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            //this.reportViewer1.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}