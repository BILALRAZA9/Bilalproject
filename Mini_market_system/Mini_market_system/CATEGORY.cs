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
    public partial class CATEGORY : Form
    {
        
        public CATEGORY()
        {
            InitializeComponent();
        }
        DB a= new DB();
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void gettable()
        {
            string query = "select * from CATEGORY";
            SqlCommand cmd = new SqlCommand(query, a.Con());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            GridView_category.DataSource = dt;
        }
        private void clear()
        {
            TBID.Clear();
            TBNAME.Clear();
            TBDISCRIPTION.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into CATEGORY values("+TBID.Text+",'" + TBNAME.Text + "','" + TBDISCRIPTION.Text + "')";
                
                SqlCommand cmd = new SqlCommand(query,a.Con());
                a.opencon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.closecon();
                gettable();
                clear();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CATEGORY_Load(object sender, EventArgs e)
        {
            gettable();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (TBID.Text == "" || TBNAME.Text == "" || TBDISCRIPTION.Text == "")
                {
                    MessageBox.Show("Missing Informaion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "update CATEGORY set NAME='" + TBNAME.Text + "',DESCRIPTION='" + TBDISCRIPTION.Text + "'WHERE ID=" + TBID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, a.Con());
                    a.opencon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Updated Successfully", "Updated Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void GridView_category_Click(object sender, EventArgs e)
        {
            TBID.Text = GridView_category.SelectedRows[0].Cells[0].Value.ToString();
            TBNAME.Text= GridView_category.SelectedRows[0].Cells[1].Value.ToString();
            TBDISCRIPTION.Text= GridView_category.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void label_EXIT_MouseEnter(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Red;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Goldenrod;
        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            p.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SELLER s = new SELLER();
            s.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SELLINGFORM ss = new SELLINGFORM();
            ss.Show();
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

        private void button8_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete CATEGORY WHERE ID=" + TBID.Text + "";
                SqlCommand cmd = new SqlCommand(query, a.Con());
                a.opencon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.closecon();
                gettable();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
