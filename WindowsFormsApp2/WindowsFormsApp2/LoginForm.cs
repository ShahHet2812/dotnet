using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void tbusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            tbpass.UseSystemPasswordChar = true;
        }

        private void btsub_Click(object sender, EventArgs e)
        {
            String u = tbusername.Text;
            String p=tbpass.Text;
            if (u == "Admin" && p == "2812")
            {
                this.DialogResult=DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void chpass_CheckedChanged(object sender, EventArgs e)
        {
            if (chpass.Checked == false)
            {
                tbpass.UseSystemPasswordChar=true;
            }
            else
            {
                tbpass.UseSystemPasswordChar=false;
            }
        }
    }
}
