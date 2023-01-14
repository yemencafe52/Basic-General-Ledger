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
    public partial class frmAddAccount : Form
    {
        public frmAddAccount()
        {
            InitializeComponent();
            Preparing();
        }

        private bool Preparing()
        {
            comboBox1.SelectedIndex = 0;
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Focus();
                return;
            }

            if (!AccountManager.Add(new Account((int)numericUpDown1.Value, textBox1.Text, 0, 0,(byte)(comboBox1.SelectedIndex+1))))
            {
                MessageBox.Show("تعذر تنفيذ العملية");
                return;
            }

            this.Close();
        }
    }
}
