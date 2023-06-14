﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DGVPrinterHelper;


namespace Mini_market_system
{
    public partial class usersf : Form
    {
        public usersf()
        {
            InitializeComponent();
        }
        DGVPrinter PRINT = new DGVPrinter();
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label_EXIT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usersf_Load(object sender, EventArgs e)
        {
            lab_date.Text = DateTime.Today.ToShortDateString();
            sellername.Text = "fahad";
            gettable();
            getcategory();
            getselltable();
        }
        DB a = new DB();
        private void getcategory()
        {
            string query = "select * from CATEGORY";
            SqlCommand cmd = new SqlCommand(query, a.Con());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            CBREFERESH.DataSource = dt;
            CBREFERESH.ValueMember = "NAME";
        }
        private void gettable()
        {
            string query = "select PRODUCT_NAME,PRICE from PRODUCT";
            SqlCommand cmd = new SqlCommand(query, a.Con());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DataGridView_category.DataSource = dt;
        }
        private void getselltable()
        {
            string query = "select * from BILL where BILL_DATE='" + lab_date.Text + "'";
            SqlCommand cmd = new SqlCommand(query, a.Con());
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            DataGridView_SELLIST.DataSource = dt;
        }

        private void BTN_PRINT_Click(object sender, EventArgs e)
        {

            PRINT.Title = "MINIMARKET SELL LISTS";
            PRINT.SubTitle = string.Format("DATE: {0}", DateTime.Now.Date);
            PRINT.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            PRINT.PageNumbers = true;
            PRINT.PageNumberInHeader = false;
            PRINT.PorportionalColumns = true;
            PRINT.HeaderCellAlignment = StringAlignment.Near;
            PRINT.Footer = "foxlearn";
            PRINT.FooterSpacing = 15;
            PRINT.printDocument.DefaultPageSettings.Landscape = true;
            PRINT.PrintDataGridView(DataGridView_SELLIST);
        }

        private void button_order_Click(object sender, EventArgs e)
        {
            if (TBNAME.Text == "" || TBQUANTITY.Text == "")
            {
                MessageBox.Show("Missing Informaion", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int total = Convert.ToInt32(TBPRICE.Text) * Convert.ToInt32(TBQUANTITY.Text);
                DataGridViewRow addrow = new DataGridViewRow();
                addrow.CreateCells(GridView_order);
                addrow.Cells[0].Value = ++n;
                addrow.Cells[1].Value = TBNAME.Text;
                addrow.Cells[2].Value = TBPRICE.Text;
                addrow.Cells[3].Value = TBQUANTITY.Text;
                addrow.Cells[4].Value = total;
                GridView_order.Rows.Add(addrow);
                grandtotal += total;
                label_AMOUNT.Text = "RS = " + grandtotal;
            }
        }
        public string getseller()
        {
            return TBNAME.Text;
        }
        private void textBox_TextChanged(object sender, EventArgs e)
        {
            string query = "select * from Bill where ID=" + textBox + " and BILL_DATE=" + lab_date.Text + "";
            int total = Convert.ToInt32(TBPRICE.Text) * Convert.ToInt32(TBQUANTITY.Text);
            DataGridViewRow addrow = new DataGridViewRow();
            addrow.CreateCells(GridView_order);
            addrow.Cells[0].Value = ++n;
            addrow.Cells[1].Value = TBNAME.Text;
            addrow.Cells[2].Value = TBPRICE.Text;
            addrow.Cells[3].Value = TBQUANTITY.Text;
            addrow.Cells[4].Value = total;
            GridView_order.Rows.Add(addrow);
            grandtotal += total;
            label_AMOUNT.Text = "RS = " + grandtotal;
        }
        int grandtotal = 0, n = 0;

        private void label_EXIT_MouseEnter(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Red;
        }

        private void label_EXIT_MouseLeave(object sender, EventArgs e)
        {
            label_EXIT.ForeColor = Color.Goldenrod;
        }

        private void DataGridView_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView_category_Click(object sender, EventArgs e)
        {
            TBNAME.Text = DataGridView_category.SelectedRows[0].Cells[0].Value.ToString();
            TBPRICE.Text = DataGridView_category.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void BTN_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into BILL values(" + TBID.Text + ",'" + sellername.Text + "','" + lab_date.Text + "'," + grandtotal.ToString() + ")";

                SqlCommand cmd = new SqlCommand(query, a.Con());
                a.opencon();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order Added Successfully", "Order Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                a.closecon();
                getselltable();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
