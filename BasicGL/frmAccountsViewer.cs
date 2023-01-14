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
    public partial class frmAccountsViewer : Form
    {

        private Account account = null;
        private bool forSelect = false;

        internal Account GetSelectedAccount
        {
            get
            {
                return this.account;
            }
        }

        public frmAccountsViewer()
        {
            InitializeComponent();
            Print(AccountManager.GetALL());
        }

        public frmAccountsViewer(bool forSelect)
        {
            InitializeComponent();
            this.forSelect = forSelect;

            Print(AccountManager.GetALL());

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmAddAccount fap = new frmAddAccount();
            fap.ShowDialog();

            Print(AccountManager.GetALL());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            //if (AccountManager.GetALL().Count > 0)
            //{
            //    //frmAddTransction fat = new frmAddTransction();
            //    //fat.ShowDialog();
            //    //Print(AccountManager.GetALL());
            //}
            //else
            //{
            //    MessageBox.Show("لا يوجد اسماء");
            //}
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword fcp = new frmChangePassword();
            fcp.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAboutBox fab = new frmAboutBox();
            fab.ShowDialog();
        }

        private void Print(List<Account> accounts)
        {
            listView1.Items.Clear();

            for (int i = 0; i < accounts.Count; i++)
            {
                ListViewItem lvi = new ListViewItem(accounts[i].GetNumber.ToString());
                lvi.SubItems.Add(accounts[i].GetName);
                //vi.SubItems.Add(accounts[i].Debit.ToString("#0.#0"));
                //lvi.SubItems.Add(accounts[i].Credit.ToString("#0.#0"));

                listView1.Items.Add(lvi);

            }

            toolStripStatusLabel2.Text = accounts.Count.ToString();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(toolStripTextBox1.Text))
            {
                Print(AccountManager.GetALL());
                toolStripTextBox1.Focus();
                return;
            }

            Print(AccountManager.Search(toolStripTextBox1.Text));
            toolStripTextBox1.Focus();
        }
           
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //DialogResult r=  sfd.ShowDialog();
            //if (r == DialogResult.OK)
            //{
            //    if (!clsUtilities.Backup(sfd.FileName + ".bak"))
            //    {
            //        MessageBox.Show("تعذر تنفيذ العملية");
            //    }
            //}

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (forSelect)
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    int index = listView1.SelectedItems[0].Index;
                    int num = int.Parse(listView1.Items[index].Text);
                    account = new Account(num);

                    this.Close();
                    //frmDetiels fd = new frmDetiels(p);
                    //fd.ShowDialog();
                }
            }
        }
    }

    
}
