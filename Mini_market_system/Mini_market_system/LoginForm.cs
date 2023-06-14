using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Mini_market_system
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        DB a = new DB();
        public static string NAME;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public static string Name1;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
         
            if (Tname.Text == "" || Tpass.Text == "")
            {
                MessageBox.Show("Enter Usernamr or Passward", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (combo_role.SelectedIndex > -1)
                {
                    if (combo_role.SelectedItem.ToString() == "ADMIN")
                    {
                        if (Tname.Text == "admin" && Tpass.Text == "admin123")
                        {
                            Product p = new Product();
                            p.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are Admin"+ "Please Enter Correct Id and Passward","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        string query = "select * from SELLER WHERE NAME='" + Tname.Text + "'and PASSWARD='" + Tpass.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, a.Con());
                        SqlDataAdapter adap = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        adap.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            Name= Tname.Text;
                            usersf s=new usersf();
                            s.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Wrong Usernamr or Passward", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select Role", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label_EXIT_MouseEnter(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Red;
        }


        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Goldenrod;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Goldenrod;
        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Tname.Clear();
            Tpass.Clear();
        }

        private void combo_role_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
