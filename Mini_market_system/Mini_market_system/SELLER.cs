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
    public partial class SELLER : Form
    {
        public SELLER()
        {
            InitializeComponent();
        }
        DB a = new DB();
        private void gettable()
        {
            string query = "select * from SELLER";
            SqlCommand cmd = new SqlCommand(query, a.Con());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            GridView_SELLER.DataSource = dt;
        }
        private void clear()
        {
            TBID.Clear();
            TBNAME.Clear();
            TBAGE.Clear();
            TBPHONE.Clear();
            TBPASSWARD.Clear();

        }
        private void GridView_PROD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Product P = new Product();
            P.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CATEGORY C = new CATEGORY();
            C.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SELLINGFORM S = new SELLINGFORM();
            S.Show();
            this.Hide();
        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_EXIT_MouseEnter(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Red;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Goldenrod;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Red;
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.ForeColor = Color.Goldenrod;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBID.Text == "")
                {
                    MessageBox.Show("Missing Informaion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "delete SELLER WHERE SELLERID=" + TBID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, a.Con());
                    a.opencon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SELLER Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    a.closecon();
                    gettable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void SELLER_Load(object sender, EventArgs e)
        {
            gettable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into SELLER(SELLERID,NAME,AGE,PHONE,PASSWARD) values(" + TBID.Text + ",'" + TBNAME.Text + "'," + TBAGE.Text + "," + TBPHONE.Text + ",'" + TBPASSWARD.Text + "')";

                SqlCommand cmd = new SqlCommand(query, a.Con());
                a.opencon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("SELLER Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.closecon();
                gettable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBID.Text == "" || TBNAME.Text == "" || TBAGE.Text == "" || TBPHONE.Text == "" || TBPASSWARD.Text == "")
                {
                    MessageBox.Show("Missing Informaion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "update SELLER set NAME='" + TBNAME.Text + "',AGE='" + TBAGE.Text + "',PHONE='" + TBPHONE.Text + "',PASSWARD='" + TBPASSWARD.Text + "'WHERE SELLERID=" + TBID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, a.Con());
                    a.opencon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("SELLER Updated Successfully", "Updated Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    a.closecon();
                    gettable();
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GridView_SELLER_Click(object sender, EventArgs e)
        {
            TBID.Text = GridView_SELLER.SelectedRows[0].Cells[0].Value.ToString();
            TBNAME.Text = GridView_SELLER.SelectedRows[0].Cells[1].Value.ToString();
            TBAGE.Text = GridView_SELLER.SelectedRows[0].Cells[2].Value.ToString();
            TBPHONE.Text = GridView_SELLER.SelectedRows[0].Cells[3].Value.ToString();
            TBPASSWARD.Text = GridView_SELLER.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
