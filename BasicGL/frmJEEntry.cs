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
    public partial class frmJEEntry : Form
    {
        public frmJEEntry()
        {
            InitializeComponent();
            PreParing();
        }

        private bool PreParing()
        {
            DisableALL();
            ClearALL();
            button3.Enabled = true;
            button7.Enabled = true;

            return false;
        }

        private void DisableALL()
        {
            numericUpDown1.Enabled = false;
            numericUpDown2.Enabled = false;
            numericUpDown3.Enabled = false;
            numericUpDown4.Enabled = false;
            numericUpDown5.Enabled = false;
            numericUpDown6.Enabled = false;
            numericUpDown7.Enabled = false;
            numericUpDown8.Enabled = false;

            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

            //listView1.Enabled = false;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;

            groupBox2.Enabled = false;
            dateTimePicker1.Enabled = false;
        
        }

        private void ClearALL()
        {
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            listView1.Items.Clear();

            dateTimePicker1.Value = DateTime.Now;

        }

        private void Display(Document document)
        {
            PreParing();

            numericUpDown1.Value = document.Number;
            numericUpDown2.Value = (decimal)document.Amount;
            dateTimePicker1.Value = document.Date;
            textBox1.Text = document.Descrption;

            List<ListViewItem> l = new List<ListViewItem>();
            for(int i=0;i<document.GetTransctions.Count;i++)
            {
                ListViewItem lvi = new ListViewItem(document.GetTransctions[i].GetAccountNumber.ToString());
                Account acc = new Account(document.GetTransctions[i].GetAccountNumber);
                lvi.SubItems.Add(acc.GetName);
                lvi.SubItems.Add(document.GetTransctions[i].GetDescrption);
                lvi.SubItems.Add(document.GetTransctions[i].GetDebit.ToString("#0.#0"));
                lvi.SubItems.Add(document.GetTransctions[i].GetCredit.ToString("#0.#0"));
                //listView1.Items.Add(lvi);
                l.Add(lvi);
            }

            listView1.Items.AddRange(l.ToArray());
            Calc0();

            button3.Enabled = true;
            button7.Enabled = true;
            button9.Enabled = true;

        }

        private void Search()
        {
            DisableALL();
            ClearALL();
            numericUpDown1.Enabled = true;
            numericUpDown1.Focus();
            button8.Enabled = true;
        }

        private void Add()
        {
            DisableALL();
            ClearALL();

            button4.Enabled = true;
            button8.Enabled = true;

            groupBox2.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;

            numericUpDown1.Enabled = true;
            numericUpDown2.Enabled = true;


            numericUpDown3.Enabled = true;
            numericUpDown4.Enabled = true;
            numericUpDown5.Enabled = true;

            textBox1.Enabled = true;
            textBox2.Enabled = true;

            listView1.Enabled = true;
            dateTimePicker1.Enabled = true;

            numericUpDown1.Value = DocumentManager.GenerateNewDocumentNumber();
            numericUpDown3.Focus();

        }

        private void Update()
        {

        }

        private void Delete()
        {

        }

        private void Cancel()
        {
            PreParing();
        }

        private void Save()
        {
            if(numericUpDown7.Value != numericUpDown8.Value)
            {
                numericUpDown2.Focus();
                return;
            }

            if (numericUpDown2.Value != numericUpDown8.Value)
            {
                numericUpDown2.Focus();
                return;
            }

            List<Transction> t = new List<Transction>();

            for(int i = 0;i<listView1.Items.Count;i++)
            {
                t.Add(new Transction(0,int.Parse(listView1.Items[i].Text), (listView1.Items[i].SubItems[2].Text), double.Parse((listView1.Items[i].SubItems[3].Text)), double.Parse((listView1.Items[i].SubItems[4].Text)), (uint)numericUpDown1.Value));
            }

            Document doc = new Document((uint)numericUpDown1.Value, dateTimePicker1.Value, (double)numericUpDown2.Value, textBox1.Text, t);

            if(!(DocumentManager.Add(doc)))
            {
                MessageBox.Show("تعذر تنفيذ العملية");
                return;
            }

            Display(doc);
        }

        private void Print()
        {
            frmReportViewer frv = new frmReportViewer(new Microsoft.Reporting.WinForms.ReportDataSource("rptTempTable", (DataTable)Reports.GetJEDocument((uint)numericUpDown1.Value)), "BasicGL.rptJE.rdlc");
            frv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void numericUpDown3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F9)
            {
                frmAccountsViewer fav = new frmAccountsViewer(true);
                fav.ShowDialog();

                if(fav.GetSelectedAccount != null)
                {
                    if(fav.GetSelectedAccount.GetNumber > 0)
                    {
                        numericUpDown3.Value = fav.GetSelectedAccount.GetNumber;
                        textBox3.Text = fav.GetSelectedAccount.GetName;
                    }
                }
            }
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown5.Value = 0;

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown4.Value = 0;
        }

        private void ClearEntry()
        {
            numericUpDown3.Value = 0;
            textBox2.Text = "";
            textBox3.Text = "";
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!(numericUpDown3.Value > 0))
            {
                numericUpDown3.Focus();
                return;
            }

            if((!(numericUpDown4.Value>0))&&(!(numericUpDown5.Value>0)))
            {
                numericUpDown4.Focus();
                return;
            }

            Account acc = new Account((int)numericUpDown3.Value);

            if (!(acc.GetNumber > 0))
            {
                numericUpDown3.Focus();
                return;
            }

            ListViewItem lvi = new ListViewItem(acc.GetNumber.ToString());
            lvi.SubItems.Add(acc.GetName);
            lvi.SubItems.Add(textBox2.Text);
            lvi.SubItems.Add(numericUpDown4.Value.ToString());
            lvi.SubItems.Add(numericUpDown5.Value.ToString());
            listView1.Items.Add(lvi);
            Calc0();

            listView1.EnsureVisible(listView1.Items.Count - 1);

            ClearEntry();
            numericUpDown3.Focus();

        }

        private void numericUpDown3_Leave(object sender, EventArgs e)
        {
            Account acc = new Account((int)numericUpDown3.Value);

            if ((acc.GetNumber > 0))
            {
                textBox3.Text = acc.GetName;
            }
        }

        private void Calc0()
        {

            double tdebit = 0;
            double tcredit = 0;
            int count = listView1.Items.Count;

            for (int i=0;i<count;i++)
            {
                tdebit += double.Parse(listView1.Items[i].SubItems[3].Text);
                tcredit += double.Parse(listView1.Items[i].SubItems[4].Text);
            }

            numericUpDown6.Value = count;
            numericUpDown7.Value = (decimal)tdebit;
            numericUpDown8.Value = (decimal)tcredit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(listView1.Items.Count>0)
            {
                if(listView1.SelectedItems.Count>0)
                {
                    listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                    Calc0();
                }
            }
        }

        private void numericUpDown1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Document doc = new Document((uint)numericUpDown1.Value);
                if(doc.Number>0)
                {
                    Display(doc);
                }
            }
        }
    }
}
