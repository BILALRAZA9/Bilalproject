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
    public partial class Product : Form
    {
        public Product()
        {
            InitializeComponent();
        }
        DB a = new DB();
        private void Product_Load(object sender, EventArgs e)
        {
            getcategory();
            gettable();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label_EXIT_MouseEnter_1(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Red;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Goldenrod;
        }

        private void BTNLOGOUT_MouseEnter(object sender, EventArgs e)
        {
            BTNLOGOUT.ForeColor = Color.Red;
        }

        private void BTNLOGOUT_MouseLeave(object sender, EventArgs e)
        {
            BTNLOGOUT.ForeColor = Color.Goldenrod;
        }

        private void BTNLOGOUT_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void getcategory()
        {
            string query = "select * from CATEGORY";
            SqlCommand cmd = new SqlCommand(query, a.Con());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            CBCATEGORY.DataSource = dt;
            CBCATEGORY.ValueMember = "NAME";
            CBREFERESH.DataSource = dt;
            CBREFERESH.ValueMember = "NAME";
        }
        private void gettable()
        {
            string query = "select * from PRODUCT";
            SqlCommand cmd = new SqlCommand(query, a.Con());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            GridView_PROD.DataSource = dt;
        }
        private void clear()
        {
            TXTID.Clear();
            TBNAME.Clear();
            TBPRICE.Clear();
            TBQUANTITY.Clear();
            
        }
        private void BTNCATEGORY_Click(object sender, EventArgs e)
        {
            CATEGORY c = new CATEGORY();
            c.Show();
            this.Hide();
        }

        private void BTNADD_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into PRODUCT(PRODUCTID,PRODUCT_NAME,QUANTITY,PRICE,CATEGORY) values(" + TXTID.Text + ",'" + TBNAME.Text + "','" + TBQUANTITY.Text + "','" + TBPRICE.Text + "','" + CBCATEGORY.Text + "')";

                SqlCommand cmd = new SqlCommand(query, a.Con());
                a.opencon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Add Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.closecon();
                gettable();
                clear();            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BTNUPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                if (TXTID.Text == "" || TBNAME.Text == "" || TBPRICE.Text == "" || TBQUANTITY.Text==""|| CBCATEGORY.Text == "")
                {
                    MessageBox.Show("Missing Informaion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "update PRODUCT set PRODUCT_NAME='" + TBNAME.Text+"',PRICE='"+TBPRICE.Text+"',QUANTITY='"+TBQUANTITY.Text+"',CATEGORY='"+CBCATEGORY.Text+"' WHERE PRODUCTID='"+TXTID.Text+"'";
                    SqlCommand cmd = new SqlCommand(query, a.Con());
                    a.opencon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Updated Successfully", "Updated Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void GridView_PROD_Click(object sender, EventArgs e)
        {

            TXTID.Text = GridView_PROD.SelectedRows[0].Cells[0].Value.ToString();
            TBNAME.Text = GridView_PROD.SelectedRows[0].Cells[1].Value.ToString();
            TBPRICE.Text = GridView_PROD.SelectedRows[0].Cells[2].Value.ToString();
            TBQUANTITY.Text = GridView_PROD.SelectedRows[0].Cells[3].Value.ToString();
            CBCATEGORY.SelectedValue= GridView_PROD.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if(TXTID.Text=="")
                {
                    MessageBox.Show("Missing Informaion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string query = "delete PRODUCT WHERE PRODUCTID=" + TXTID.Text + "";
                    SqlCommand cmd = new SqlCommand(query, a.Con());
                    a.opencon();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("product Deleted Successfully", "Delete Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BTNREFERESH_Click(object sender, EventArgs e)
        {
            gettable();
        }

        private void CBREFERESH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string query = "select * from PRODUCT where CATEGORY='"+CBREFERESH.SelectedValue.ToString()+"'";
            SqlCommand cmd = new SqlCommand(query, a.Con());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            GridView_PROD.DataSource = dt;
        }

        private void BTNSELLING_Click(object sender, EventArgs e)
        {
            SELLINGFORM S = new SELLINGFORM();
            S.Show();
            this.Hide();
        }

        private void BTNSELLER_Click(object sender, EventArgs e)
        {
            SELLER s = new SELLER();
            s.Show();
            this.Hide();
        }
    }
}
