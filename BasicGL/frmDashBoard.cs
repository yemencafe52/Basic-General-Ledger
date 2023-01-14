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
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel2.Text = DateTime.Now.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox fa = new frmAboutBox();
            fa.ShowDialog();
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeNode tn = treeView1.SelectedNode;
            if(tn != null)
            {
                if(tn.Tag != null)
                {
                    int i = 0;

                    if (int.TryParse(tn.Tag.ToString(),out i))
                    {

                        switch (i)
                        {
                            case 1:
                                {
                                    break;
                                }
                            case 10:
                                {
                                    frmAccountsViewer fav = new frmAccountsViewer();
                                    fav.Show();
                                    break;
                                }
                            case 11:
                                {
                                    frmJEEntry fee = new frmJEEntry();
                                    fee.MdiParent = this;
                                    fee.Show();
                                    break;
                                }
                            case 12:
                                {
                                    frmJEReport fjr = new frmJEReport();
                                    fjr.Show();
                                    break;
                                }
                            case 13:
                                {
                                    frmDR fdr = new frmDR();
                                    fdr.Show();
                                    break;
                                }
                            case 14:
                                {
                                    frmDAS fd = new frmDAS();
                                    fd.Show();
                                    break;
                                }
                            case 15:
                                {
                                    frmISReport fi = new frmISReport();
                                    fi.Show();
                                    break;
                                }
                            case 16:
                                {
                                    frmBSReport fbsr = new frmBSReport();
                                    fbsr.Show();
                                    break;
                                }

                            case 17:
                                {
                                    frmChangePassword fcp = new frmChangePassword();
                                    fcp.Show();
                                    break;
                                }

                        }
                    }


                }
            }
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            DialogResult r = sfd.ShowDialog();
            if (r == DialogResult.OK)
            {
                if (!clsUtilities.Backup(sfd.FileName + ".bak"))
                {
                    MessageBox.Show("تعذر تنفيذ العملية");
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
