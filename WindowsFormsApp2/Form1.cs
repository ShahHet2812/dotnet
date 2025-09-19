using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        NpgsqlConnection con;
        string constring = "Host=localhost;Port=5432;Username=postgres;Password=ljiet;Database=Het";
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
            string updatequery = "Update MANAGE set pname=@pname,pnumber=@pnumber,price=@price,quantity=@quantity,category=@category,membership=@membership,buydate=@buydate";
            NpgsqlCommand cmd=new NpgsqlCommand(updatequery,con);
            cmd.Parameters.AddWithValue("@id",int.Parse(lbid.Text));
            cmd.Parameters.AddWithValue("@pname", tbname.Text);
            cmd.Parameters.AddWithValue("@pnumber", long.Parse(tbnumber.Text));
            cmd.Parameters.AddWithValue("@price", double.Parse(tbprice.Text));
            cmd.Parameters.AddWithValue("@quantity", int.Parse(cbqty.SelectedItem.ToString()));
            cmd.Parameters.AddWithValue("@category", rbelec.Checked ? "Electronics" : "Gaming");
            cmd.Parameters.AddWithValue("@membership", chprime.Checked);
            cmd.Parameters.AddWithValue("@buydate", dtp.Value);
            int x = cmd.ExecuteNonQuery();
            if (x > 0)
            {
                MessageBox.Show("Data Updated Successfully");
            }
            else
            {
                MessageBox.Show("Data can't be updated");
            }
            //LoadData();
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
            DbConnect();
            LoadData();

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
                MessageBox.Show("All number must be numeric.");
                return false;
            }
            else
            {
                return true;
            }
        }
        bool Price()
        {
            return Double.TryParse(tbprice.Text, out double price);
        }

        private void btsubmit_Click(object sender, EventArgs e)
        {
            if (ValidateName() && ValidateNumber() && Price() && cbqty.SelectedIndex != -1 && (rbelec.Checked || rbgame.Checked))
            {
                MessageBox.Show("Validation Successful");
                String insertquery = "INSERT INTO MANAGE(pname,pnumber,price,quantity,category,membership,buydate)values(@pname,@pnumber,@price,@quantity,@category,@membership,@buydate)";
                NpgsqlCommand cmd=new NpgsqlCommand(insertquery,con);
                cmd.Parameters.AddWithValue("@pname",tbname.Text);
                cmd.Parameters.AddWithValue("@pnumber", long.Parse(tbnumber.Text));
                cmd.Parameters.AddWithValue("@price", double.Parse(tbprice.Text));
                cmd.Parameters.AddWithValue("@quantity", int.Parse(cbqty.SelectedItem.ToString()));
                cmd.Parameters.AddWithValue("@category", rbelec.Checked?"Electronics":"Gaming");
                cmd.Parameters.AddWithValue("@membership", chprime.Checked);
                cmd.Parameters.AddWithValue("@buydate", dtp.Value);

                int x = cmd.ExecuteNonQuery();
                if (x > 0)
                {
                    MessageBox.Show("Data Filled Successfully");
                }
                else
                {
                    MessageBox.Show("Data can't be filled");
                }
            }
            else
            {
                MessageBox.Show("Enter field Carefully");
            }
            LoadData();
        }
        void DbConnect()
        {
            try
            {
                con = new NpgsqlConnection(constring);
                con.Open();
                MessageBox.Show("Postgres Connection Successful");
            }
            catch
            {
                MessageBox.Show("Connection Failed");
            }
        }
        void LoadData()
        {
            con.Close();
            try
            {
                con.Open();
                string displayquery = "Select * from MANAGE";
                NpgsqlDataAdapter da=new NpgsqlDataAdapter(displayquery,con);
                DataTable dt=new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch
            {
                MessageBox.Show("Data Fetching Failed");
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgv.Rows[e.RowIndex];
                lbid.Text = r.Cells[0].Value.ToString();
                tbname.Text = r.Cells[1].Value.ToString();
                tbnumber.Text = r.Cells[2].Value.ToString();
                tbprice.Text = r.Cells[3].Value.ToString();
                cbqty.Text = r.Cells[4].Value.ToString();
                string c = r.Cells[5].Value.ToString();
                if (c == "Electronics")
                {
                    rbelec.Checked = true;
                }
                else
                {
                    rbgame.Checked = true;
                }
                Boolean p1 = Convert.ToBoolean(r.Cells[6].Value);
                if (p1 == true)
                {
                    chprime.Checked = true;
                }
                else
                {
                    chprime.Checked = false;
                }
                dtp.Text = r.Cells[7].Value.ToString();
            }
        }

    }
}