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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void tbprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbqty.Items.Add("1");
            cbqty.Items.Add("2");
            cbqty.Items.Add("3");
            cbqty.Items.Add("4");
            LoginForm log = new LoginForm();
            if (log.ShowDialog() != DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Form is now visible");
            }

        }

        private void cbqty_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        bool ValidateName()
        {

            if (tbname.Text.Length == 0)  //OR if (String.IsNullOrEmpty(tbname))
            {
                MessageBox.Show("Name can't be empty.");
                return false;
            }
            if (tbname.Text.Length < 6)
            {
                MessageBox.Show("Character must be atleast 6 letter");
                return false;
            }
            if (tbname.Text.Any(Char.IsDigit))
            {
                MessageBox.Show("Name can't be Number");
                return false;
            }
            else
            {
                return true;
            }
        }
        bool ValidateNumber()
        {
            if (tbnumber.Text.Length == 0)
            {
                MessageBox.Show("Number can't be Empty.");
                return false;
            }
            if (tbnumber.Text.Length < 3)
            {
                MessageBox.Show("Number must be atleast 4 digits.");
                return false;
            }
            if (tbnumber.Text.All(Char.IsDigit) == false)
            {
                MessageBox.Show("all number must be numeric.");
                return false;
            }
            else
            {
                return true;
            }
        }
        bool Price()
        {
            return Double.TryParse(tbprice.Text,out double price);
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (ValidateName() && ValidateNumber() && Price() && cbqty.SelectedIndex!=-1 && (rbelec.Checked || rbgame.Checked))
            {
                MessageBox.Show("Validation Successful");
            }
            else
            {
                MessageBox.Show("Enter field Carefully");
            }
        }
    }
}