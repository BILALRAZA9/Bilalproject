namespace Mini_market_system
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_EXIT = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CBREFERESH = new System.Windows.Forms.ComboBox();
            this.CBCATEGORY = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.BTNREFERESH = new System.Windows.Forms.Button();
            this.GridView_PROD = new Guna.UI2.WinForms.Guna2DataGridView();
            this.BTNDELETE = new System.Windows.Forms.Button();
            this.BTNUPDATE = new System.Windows.Forms.Button();
            this.BTNADD = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TBQUANTITY = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TBPRICE = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TBNAME = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXTID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNSELLER = new System.Windows.Forms.Button();
            this.BTNCATEGORY = new System.Windows.Forms.Button();
            this.BTNSELLING = new System.Windows.Forms.Button();
            this.BTNLOGOUT = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PROD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.TID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(192, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 605);
            this.panel1.TabIndex = 0;
            // 
            // TID
            // 
            this.TID.BorderRadius = 18;
            this.TID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TID.DefaultText = "";
            this.TID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TID.DisabledState.Parent = this.TID;
            this.TID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TID.FocusedState.Parent = this.TID;
            this.TID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TID.HoverState.Parent = this.TID;
            this.TID.Location = new System.Drawing.Point(130, 41);
            this.TID.Name = "TID";
            this.TID.PasswordChar = '\0';
            this.TID.PlaceholderText = "";
            this.TID.SelectedText = "";
            this.TID.ShadowDecoration.Parent = this.TID;
            this.TID.Size = new System.Drawing.Size(200, 28);
            this.TID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label_EXIT
            // 
            this.label_EXIT.AutoSize = true;
            this.label_EXIT.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_EXIT.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_EXIT.Location = new System.Drawing.Point(1079, -9);
            this.label_EXIT.Name = "label_EXIT";
            this.label_EXIT.Size = new System.Drawing.Size(27, 30);
            this.label_EXIT.TabIndex = 8;
            this.label_EXIT.Text = "X";
            this.label_EXIT.Click += new System.EventHandler(this.label_EXIT_Click);
            this.label_EXIT.MouseEnter += new System.EventHandler(this.label_EXIT_MouseEnter_1);
            this.label_EXIT.MouseLeave += new System.EventHandler(this.label_EXIT_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gold;
            this.panel2.Controls.Add(this.CBREFERESH);
            this.panel2.Controls.Add(this.CBCATEGORY);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.BTNREFERESH);
            this.panel2.Controls.Add(this.GridView_PROD);
            this.panel2.Controls.Add(this.BTNDELETE);
            this.panel2.Controls.Add(this.BTNUPDATE);
            this.panel2.Controls.Add(this.BTNADD);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.TBQUANTITY);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.TBPRICE);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.TBNAME);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TXTID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(192, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(896, 605);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // CBREFERESH
            // 
            this.CBREFERESH.FormattingEnabled = true;
            this.CBREFERESH.Location = new System.Drawing.Point(452, 58);
            this.CBREFERESH.Name = "CBREFERESH";
            this.CBREFERESH.Size = new System.Drawing.Size(243, 36);
            this.CBREFERESH.TabIndex = 18;
            this.CBREFERESH.Text = "-select category-";
            this.CBREFERESH.SelectionChangeCommitted += new System.EventHandler(this.CBREFERESH_SelectionChangeCommitted);
            // 
            // CBCATEGORY
            // 
            this.CBCATEGORY.FormattingEnabled = true;
            this.CBCATEGORY.Location = new System.Drawing.Point(144, 256);
            this.CBCATEGORY.Name = "CBCATEGORY";
            this.CBCATEGORY.Size = new System.Drawing.Size(194, 36);
            this.CBCATEGORY.TabIndex = 17;
            this.CBCATEGORY.Text = "-select category-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Display", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(234, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(291, 47);
            this.label7.TabIndex = 16;
            this.label7.Text = "MANAGE PRODUCT";
            // 
            // BTNREFERESH
            // 
            this.BTNREFERESH.FlatAppearance.BorderSize = 0;
            this.BTNREFERESH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNREFERESH.Location = new System.Drawing.Point(701, 56);
            this.BTNREFERESH.Name = "BTNREFERESH";
            this.BTNREFERESH.Size = new System.Drawing.Size(96, 39);
            this.BTNREFERESH.TabIndex = 14;
            this.BTNREFERESH.Text = "Refresh";
            this.BTNREFERESH.UseVisualStyleBackColor = true;
            this.BTNREFERESH.Click += new System.EventHandler(this.BTNREFERESH_Click);
            // 
            // GridView_PROD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridView_PROD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView_PROD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.GridView_PROD.BackgroundColor = System.Drawing.Color.White;
            this.GridView_PROD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView_PROD.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridView_PROD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView_PROD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView_PROD.ColumnHeadersHeight = 24;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView_PROD.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridView_PROD.EnableHeadersVisualStyles = false;
            this.GridView_PROD.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridView_PROD.Location = new System.Drawing.Point(373, 110);
            this.GridView_PROD.Name = "GridView_PROD";
            this.GridView_PROD.RowHeadersVisible = false;
            this.GridView_PROD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridView_PROD.Size = new System.Drawing.Size(503, 480);
            this.GridView_PROD.TabIndex = 13;
            this.GridView_PROD.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridView_PROD.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridView_PROD.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridView_PROD.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridView_PROD.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridView_PROD.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridView_PROD.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridView_PROD.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.GridView_PROD.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridView_PROD.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView_PROD.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.GridView_PROD.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.GridView_PROD.ThemeStyle.HeaderStyle.Height = 24;
            this.GridView_PROD.ThemeStyle.ReadOnly = false;
            this.GridView_PROD.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.GridView_PROD.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.GridView_PROD.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridView_PROD.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridView_PROD.ThemeStyle.RowsStyle.Height = 22;
            this.GridView_PROD.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.GridView_PROD.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.GridView_PROD.Click += new System.EventHandler(this.GridView_PROD_Click);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.FlatAppearance.BorderSize = 0;
            this.BTNDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDELETE.Location = new System.Drawing.Point(242, 321);
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(96, 39);
            this.BTNDELETE.TabIndex = 12;
            this.BTNDELETE.Text = "DELETE";
            this.BTNDELETE.UseVisualStyleBackColor = true;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNUPDATE
            // 
            this.BTNUPDATE.FlatAppearance.BorderSize = 0;
            this.BTNUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNUPDATE.Location = new System.Drawing.Point(131, 321);
            this.BTNUPDATE.Name = "BTNUPDATE";
            this.BTNUPDATE.Size = new System.Drawing.Size(96, 39);
            this.BTNUPDATE.TabIndex = 11;
            this.BTNUPDATE.Text = "UPDATE";
            this.BTNUPDATE.UseVisualStyleBackColor = true;
            this.BTNUPDATE.Click += new System.EventHandler(this.BTNUPDATE_Click);
            // 
            // BTNADD
            // 
            this.BTNADD.FlatAppearance.BorderSize = 0;
            this.BTNADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNADD.Location = new System.Drawing.Point(29, 321);
            this.BTNADD.Name = "BTNADD";
            this.BTNADD.Size = new System.Drawing.Size(96, 39);
            this.BTNADD.TabIndex = 10;
            this.BTNADD.Text = "ADD";
            this.BTNADD.UseVisualStyleBackColor = true;
            this.BTNADD.Click += new System.EventHandler(this.BTNADD_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "CATEGORY";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // TBQUANTITY
            // 
            this.TBQUANTITY.BorderRadius = 18;
            this.TBQUANTITY.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBQUANTITY.DefaultText = "";
            this.TBQUANTITY.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBQUANTITY.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBQUANTITY.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBQUANTITY.DisabledState.Parent = this.TBQUANTITY;
            this.TBQUANTITY.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBQUANTITY.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBQUANTITY.FocusedState.Parent = this.TBQUANTITY;
            this.TBQUANTITY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBQUANTITY.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBQUANTITY.HoverState.Parent = this.TBQUANTITY;
            this.TBQUANTITY.Location = new System.Drawing.Point(138, 208);
            this.TBQUANTITY.Name = "TBQUANTITY";
            this.TBQUANTITY.PasswordChar = '\0';
            this.TBQUANTITY.PlaceholderText = "";
            this.TBQUANTITY.SelectedText = "";
            this.TBQUANTITY.ShadowDecoration.Parent = this.TBQUANTITY;
            this.TBQUANTITY.Size = new System.Drawing.Size(200, 28);
            this.TBQUANTITY.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 28);
            this.label5.TabIndex = 6;
            this.label5.Text = "QUANTITY";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TBPRICE
            // 
            this.TBPRICE.BorderRadius = 18;
            this.TBPRICE.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBPRICE.DefaultText = "";
            this.TBPRICE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBPRICE.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBPRICE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBPRICE.DisabledState.Parent = this.TBPRICE;
            this.TBPRICE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBPRICE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBPRICE.FocusedState.Parent = this.TBPRICE;
            this.TBPRICE.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBPRICE.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBPRICE.HoverState.Parent = this.TBPRICE;
            this.TBPRICE.Location = new System.Drawing.Point(138, 160);
            this.TBPRICE.Name = "TBPRICE";
            this.TBPRICE.PasswordChar = '\0';
            this.TBPRICE.PlaceholderText = "";
            this.TBPRICE.SelectedText = "";
            this.TBPRICE.ShadowDecoration.Parent = this.TBPRICE;
            this.TBPRICE.Size = new System.Drawing.Size(200, 28);
            this.TBPRICE.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRICE";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TBNAME
            // 
            this.TBNAME.BorderRadius = 18;
            this.TBNAME.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBNAME.DefaultText = "";
            this.TBNAME.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TBNAME.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TBNAME.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBNAME.DisabledState.Parent = this.TBNAME;
            this.TBNAME.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TBNAME.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBNAME.FocusedState.Parent = this.TBNAME;
            this.TBNAME.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TBNAME.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TBNAME.HoverState.Parent = this.TBNAME;
            this.TBNAME.Location = new System.Drawing.Point(138, 110);
            this.TBNAME.Name = "TBNAME";
            this.TBNAME.PasswordChar = '\0';
            this.TBNAME.PlaceholderText = "";
            this.TBNAME.SelectedText = "";
            this.TBNAME.ShadowDecoration.Parent = this.TBNAME;
            this.TBNAME.Size = new System.Drawing.Size(200, 28);
            this.TBNAME.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // TXTID
            // 
            this.TXTID.BorderRadius = 18;
            this.TXTID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TXTID.DefaultText = "";
            this.TXTID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TXTID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TXTID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTID.DisabledState.Parent = this.TXTID;
            this.TXTID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TXTID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTID.FocusedState.Parent = this.TXTID;
            this.TXTID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXTID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TXTID.HoverState.Parent = this.TXTID;
            this.TXTID.Location = new System.Drawing.Point(138, 67);
            this.TXTID.Name = "TXTID";
            this.TXTID.PasswordChar = '\0';
            this.TXTID.PlaceholderText = "";
            this.TXTID.SelectedText = "";
            this.TXTID.ShadowDecoration.Parent = this.TXTID;
            this.TXTID.Size = new System.Drawing.Size(200, 28);
            this.TXTID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // BTNSELLER
            // 
            this.BTNSELLER.FlatAppearance.BorderSize = 0;
            this.BTNSELLER.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSELLER.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSELLER.ForeColor = System.Drawing.Color.Gold;
            this.BTNSELLER.Location = new System.Drawing.Point(36, 33);
            this.BTNSELLER.Name = "BTNSELLER";
            this.BTNSELLER.Size = new System.Drawing.Size(122, 39);
            this.BTNSELLER.TabIndex = 17;
            this.BTNSELLER.Text = "SELLER";
            this.BTNSELLER.UseVisualStyleBackColor = true;
            this.BTNSELLER.Click += new System.EventHandler(this.BTNSELLER_Click);
            // 
            // BTNCATEGORY
            // 
            this.BTNCATEGORY.FlatAppearance.BorderSize = 0;
            this.BTNCATEGORY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCATEGORY.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCATEGORY.ForeColor = System.Drawing.Color.Gold;
            this.BTNCATEGORY.Location = new System.Drawing.Point(36, 97);
            this.BTNCATEGORY.Name = "BTNCATEGORY";
            this.BTNCATEGORY.Size = new System.Drawing.Size(122, 39);
            this.BTNCATEGORY.TabIndex = 18;
            this.BTNCATEGORY.Text = "CATEGORY";
            this.BTNCATEGORY.UseVisualStyleBackColor = true;
            this.BTNCATEGORY.Click += new System.EventHandler(this.BTNCATEGORY_Click);
            // 
            // BTNSELLING
            // 
            this.BTNSELLING.FlatAppearance.BorderSize = 0;
            this.BTNSELLING.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNSELLING.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNSELLING.ForeColor = System.Drawing.Color.Gold;
            this.BTNSELLING.Location = new System.Drawing.Point(36, 167);
            this.BTNSELLING.Name = "BTNSELLING";
            this.BTNSELLING.Size = new System.Drawing.Size(122, 39);
            this.BTNSELLING.TabIndex = 19;
            this.BTNSELLING.Text = "SELLING";
            this.BTNSELLING.UseVisualStyleBackColor = true;
            this.BTNSELLING.Click += new System.EventHandler(this.BTNSELLING_Click);
            // 
            // BTNLOGOUT
            // 
            this.BTNLOGOUT.FlatAppearance.BorderSize = 0;
            this.BTNLOGOUT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLOGOUT.Font = new System.Drawing.Font("Sitka Display", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLOGOUT.ForeColor = System.Drawing.Color.Gold;
            this.BTNLOGOUT.Location = new System.Drawing.Point(36, 599);
            this.BTNLOGOUT.Name = "BTNLOGOUT";
            this.BTNLOGOUT.Size = new System.Drawing.Size(122, 39);
            this.BTNLOGOUT.TabIndex = 20;
            this.BTNLOGOUT.Text = "LOGOUT";
            this.BTNLOGOUT.UseVisualStyleBackColor = true;
            this.BTNLOGOUT.Click += new System.EventHandler(this.BTNLOGOUT_Click);
            this.BTNLOGOUT.MouseEnter += new System.EventHandler(this.BTNLOGOUT_MouseEnter);
            this.BTNLOGOUT.MouseLeave += new System.EventHandler(this.BTNLOGOUT_MouseLeave);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.BTNLOGOUT);
            this.Controls.Add(this.BTNSELLING);
            this.Controls.Add(this.BTNCATEGORY);
            this.Controls.Add(this.BTNSELLER);
            this.Controls.Add(this.label_EXIT);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sitka Display", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PROD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox TID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_EXIT;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox TXTID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox TBQUANTITY;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox TBPRICE;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox TBNAME;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DataGridView GridView_PROD;
        private System.Windows.Forms.Button BTNDELETE;
        private System.Windows.Forms.Button BTNUPDATE;
        private System.Windows.Forms.Button BTNADD;
        private System.Windows.Forms.Button BTNREFERESH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BTNSELLER;
        private System.Windows.Forms.Button BTNCATEGORY;
        private System.Windows.Forms.Button BTNSELLING;
        private System.Windows.Forms.Button BTNLOGOUT;
        private System.Windows.Forms.ComboBox CBREFERESH;
        private System.Windows.Forms.ComboBox CBCATEGORY;
    }
}