using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foo_Enterprises
{
    public partial class Form1 : Form
    {
        int c1 = 1;
        int c2 = 1;
        int c3 = 1;
        int c4 = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var customer = new BusinessLayer.FooEnterprises.Customer();
            var product = new BusinessLayer.FooEnterprises.Product();
            var invoice = new BusinessLayer.FooEnterprises.CustomerProduct();
            customer.FirstName = FirstName.Text;
            customer.LastName = LastName.Text;
            customer.Save();
            product.ProductName = ProductName.Text;
            product.WholesaleCost = Convert.ToDecimal(wholesalecost.Text);
            product.SaleCost = Convert.ToDecimal(SaleCost.Text);
            product.Save();
            invoice.CustomerId = customer.CustomerId;
            invoice.ProductId = product.ProductId;
            invoice.Save();
            MessageBox.Show("Data Added Successfully");
            Show_Click(sender,e);
            Clear_textBoxes();
        }

        private void Clear_textBoxes()
        {
            FirstName.Clear();
            LastName.Clear();
            ProductName.Clear();
            wholesalecost.Clear();
            SaleCost.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
           

            var invoice = new BusinessLayer.FooEnterprises.CustomerProduct(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            var customer = new BusinessLayer.FooEnterprises.Customer(invoice.CustomerId);
            var product = new BusinessLayer.FooEnterprises.Product(invoice.ProductId);
           
            customer.FirstName = FirstName.Text;
            customer.LastName = LastName.Text;
            customer.Save();
            product.ProductName = ProductName.Text;
            product.WholesaleCost = Convert.ToDecimal(wholesalecost.Text);
            product.SaleCost = Convert.ToDecimal(SaleCost.Text);
            product.Save();
            MessageBox.Show("Data Updated Successfully");
            Clear_textBoxes();
            Show_Click(sender, e);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var invoice = new BusinessLayer.FooEnterprises.CustomerProduct(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            var customer = new BusinessLayer.FooEnterprises.Customer(invoice.CustomerId);
            var product = new BusinessLayer.FooEnterprises.Product(invoice.ProductId);
            invoice.Delete();
            customer.Delete();
            product.Delete();
            MessageBox.Show("Data Deleted Successfully");
            Clear_textBoxes();
            Show_Click(sender, e);
            
        }
 
        private void Show_Click(object sender, EventArgs e)
        {
            var customers = new BusinessLayer.FooEnterprises.Customers();
            var products = new BusinessLayer.FooEnterprises.Products();
            var purchases = new BusinessLayer.FooEnterprises.CustomerProducts();
            customers.GetAll();
            products.GetAll();
            purchases.GetAll();
            int n = 0;
            
            foreach (BusinessLayer.FooEnterprises.Customer customer in customers)
            {
                if (c1 <= customers.Count())
                {
                    CustomersGV.Rows.Add();
                    c1++;
                }
                  
                CustomersGV.Rows[n].Cells[0].Value = customer.CustomerId;
                CustomersGV.Rows[n].Cells[1].Value = customer.FirstName;
                CustomersGV.Rows[n].Cells[2].Value = customer.LastName;
                n++;
            }
            n = 0;
            foreach (BusinessLayer.FooEnterprises.Product product in products)
            {
                if (c2 <= products.Count())
                {
                    ProductGV.Rows.Add();
                    c2++;
                }
                
                ProductGV.Rows[n].Cells[0].Value = product.ProductId;
                ProductGV.Rows[n].Cells[1].Value = product.ProductName;
                ProductGV.Rows[n].Cells[2].Value = product.WholesaleCost;
                ProductGV.Rows[n].Cells[3].Value = product.SaleCost;
                n++;
            }
            n = 0;
            foreach (BusinessLayer.FooEnterprises.CustomerProduct purchase in purchases)
            {
                if (c3 <= purchases.Count())
                {
                    CustomerProductGV.Rows.Add();
                    c3++;
                }

                CustomerProductGV.Rows[n].Cells[0].Value = purchase.CustomerProductId;
                CustomerProductGV.Rows[n].Cells[1].Value = purchase.CustomerId;
                CustomerProductGV.Rows[n].Cells[2].Value = purchase.ProductId;
                
                n++;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Foo Enterprises");

        }

        private void TBCustomers_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomersGV_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void CustomersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var purchases = new BusinessLayer.FooEnterprises.CustomerProducts();
            var customers = new BusinessLayer.FooEnterprises.Customers();
            
            if (e.RowIndex >= 0)
            {
                int prk = Convert.ToInt32(CustomersGV.SelectedCells[0].Value);
                purchases.GetByCustomerId(prk);

                foreach (BusinessLayer.FooEnterprises.CustomerProduct purchase in purchases)
                {
                    if (c4 <= purchases.Count())
                    {
                        
                        dataGridView1.Rows.Add();
                        c4++;
                    }
                    dataGridView1.Rows[0].Cells[0].Value = purchase.CustomerProductId;
                    dataGridView1.Rows[0].Cells[1].Value = purchase.FCustomerId.FirstName;
                    dataGridView1.Rows[0].Cells[2].Value = purchase.FCustomerId.LastName;
                    dataGridView1.Rows[0].Cells[3].Value = purchase.FProductId.ProductName;
                    dataGridView1.Rows[0].Cells[4].Value = purchase.FProductId.WholesaleCost;
                    dataGridView1.Rows[0].Cells[5].Value = purchase.FProductId.SaleCost;
                     
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                    FirstName.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    LastName.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    ProductName.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    wholesalecost.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    SaleCost.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
            }

        }
    }
}
