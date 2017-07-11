namespace Foo_Enterprises
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.SaleCost = new System.Windows.Forms.TextBox();
            this.Show = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fooEnterprisesDataSet = new Foo_Enterprises.FooEnterprisesDataSet();
            this.customerTableAdapter = new Foo_Enterprises.FooEnterprisesDataSetTableAdapters.CustomerTableAdapter();
            this.customerProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fooEnterprisesDataSet1 = new Foo_Enterprises.FooEnterprisesDataSet1();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fooEnterprisesDataSet2 = new Foo_Enterprises.FooEnterprisesDataSet2();
            this.customerProductTableAdapter = new Foo_Enterprises.FooEnterprisesDataSet1TableAdapters.CustomerProductTableAdapter();
            this.productTableAdapter = new Foo_Enterprises.FooEnterprisesDataSet2TableAdapters.ProductTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ProductGV = new System.Windows.Forms.DataGridView();
            this.TBCustomers = new System.Windows.Forms.TabPage();
            this.CustomersGV = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TCFooEnterprises = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CustomerProductGV = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wholesalecost = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).BeginInit();
            this.TBCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            this.TCFooEnterprises.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerProductGV)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(130, 101);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Sale Cost";
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(130, 140);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 7;
            // 
            // ProductName
            // 
            this.ProductName.Location = new System.Drawing.Point(130, 179);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(100, 20);
            this.ProductName.TabIndex = 8;
            this.ProductName.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // SaleCost
            // 
            this.SaleCost.Location = new System.Drawing.Point(130, 257);
            this.SaleCost.Name = "SaleCost";
            this.SaleCost.Size = new System.Drawing.Size(100, 20);
            this.SaleCost.TabIndex = 10;
            this.SaleCost.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Show
            // 
            this.Show.Location = new System.Drawing.Point(663, 347);
            this.Show.Name = "Show";
            this.Show.Size = new System.Drawing.Size(75, 23);
            this.Show.TabIndex = 13;
            this.Show.Text = "Show";
            this.Show.UseVisualStyleBackColor = true;
            this.Show.Click += new System.EventHandler(this.Show_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(516, 347);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 23);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(369, 347);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(75, 23);
            this.Update.TabIndex = 15;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(222, 347);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 16;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.button5_Click);
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.fooEnterprisesDataSet;
            // 
            // fooEnterprisesDataSet
            // 
            this.fooEnterprisesDataSet.DataSetName = "FooEnterprisesDataSet";
            this.fooEnterprisesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // customerProductBindingSource
            // 
            this.customerProductBindingSource.DataMember = "CustomerProduct";
            this.customerProductBindingSource.DataSource = this.fooEnterprisesDataSet1;
            // 
            // fooEnterprisesDataSet1
            // 
            this.fooEnterprisesDataSet1.DataSetName = "FooEnterprisesDataSet1";
            this.fooEnterprisesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.fooEnterprisesDataSet2;
            // 
            // fooEnterprisesDataSet2
            // 
            this.fooEnterprisesDataSet2.DataSetName = "FooEnterprisesDataSet2";
            this.fooEnterprisesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerProductTableAdapter
            // 
            this.customerProductTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column16,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(608, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(329, 247);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(647, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(252, 29);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fetching specific record";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ProductGV);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(345, 275);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Products";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ProductGV
            // 
            this.ProductGV.AllowUserToAddRows = false;
            this.ProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column11,
            this.Column15});
            this.ProductGV.Location = new System.Drawing.Point(0, 6);
            this.ProductGV.Name = "ProductGV";
            this.ProductGV.ReadOnly = true;
            this.ProductGV.Size = new System.Drawing.Size(370, 263);
            this.ProductGV.TabIndex = 0;
            // 
            // TBCustomers
            // 
            this.TBCustomers.Controls.Add(this.CustomersGV);
            this.TBCustomers.Location = new System.Drawing.Point(4, 22);
            this.TBCustomers.Name = "TBCustomers";
            this.TBCustomers.Padding = new System.Windows.Forms.Padding(3);
            this.TBCustomers.Size = new System.Drawing.Size(345, 275);
            this.TBCustomers.TabIndex = 0;
            this.TBCustomers.Text = "Customers";
            this.TBCustomers.UseVisualStyleBackColor = true;
            this.TBCustomers.Click += new System.EventHandler(this.TBCustomers_Click);
            // 
            // CustomersGV
            // 
            this.CustomersGV.AllowUserToAddRows = false;
            this.CustomersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column6,
            this.Column7});
            this.CustomersGV.Location = new System.Drawing.Point(3, 3);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.ReadOnly = true;
            this.CustomersGV.Size = new System.Drawing.Size(367, 269);
            this.CustomersGV.TabIndex = 17;
            this.CustomersGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellClick);
            this.CustomersGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.CustomersGV.SelectionChanged += new System.EventHandler(this.CustomersGV_SelectionChanged);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Customer ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "First Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Last Name";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // TCFooEnterprises
            // 
            this.TCFooEnterprises.Controls.Add(this.TBCustomers);
            this.TCFooEnterprises.Controls.Add(this.tabPage3);
            this.TCFooEnterprises.Controls.Add(this.tabPage1);
            this.TCFooEnterprises.Location = new System.Drawing.Point(246, 25);
            this.TCFooEnterprises.Name = "TCFooEnterprises";
            this.TCFooEnterprises.SelectedIndex = 0;
            this.TCFooEnterprises.Size = new System.Drawing.Size(353, 301);
            this.TCFooEnterprises.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CustomerProductGV);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(345, 275);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Cutomer Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CustomerProductGV
            // 
            this.CustomerProductGV.AllowUserToAddRows = false;
            this.CustomerProductGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerProductGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14});
            this.CustomerProductGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerProductGV.Location = new System.Drawing.Point(3, 3);
            this.CustomerProductGV.Name = "CustomerProductGV";
            this.CustomerProductGV.ReadOnly = true;
            this.CustomerProductGV.Size = new System.Drawing.Size(339, 269);
            this.CustomerProductGV.TabIndex = 0;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Customer Product ID";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Customer ID";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Product ID";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Product Id";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Product Name";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Sale Cost";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // wholesalecost
            // 
            this.wholesalecost.Location = new System.Drawing.Point(130, 218);
            this.wholesalecost.Name = "wholesalecost";
            this.wholesalecost.Size = new System.Drawing.Size(100, 20);
            this.wholesalecost.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Whole Sale Cost";
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Whole Sale Cost";
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Customer Product ID";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "First Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Last Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Products";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Whole Sale Cost";
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Sale Cost";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 406);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wholesalecost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Show);
            this.Controls.Add(this.SaleCost);
            this.Controls.Add(this.ProductName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.TCFooEnterprises);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fooEnterprisesDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGV)).EndInit();
            this.TBCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            this.TCFooEnterprises.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerProductGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox SaleCost;
        private System.Windows.Forms.Button Show;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Add;
        private FooEnterprisesDataSet fooEnterprisesDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private FooEnterprisesDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private FooEnterprisesDataSet1 fooEnterprisesDataSet1;
        private System.Windows.Forms.BindingSource customerProductBindingSource;
        private FooEnterprisesDataSet1TableAdapters.CustomerProductTableAdapter customerProductTableAdapter;
        private FooEnterprisesDataSet2 fooEnterprisesDataSet2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private FooEnterprisesDataSet2TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView ProductGV;
        private System.Windows.Forms.TabPage TBCustomers;
        private System.Windows.Forms.DataGridView CustomersGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TabControl TCFooEnterprises;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView CustomerProductGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.TextBox wholesalecost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

