using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class SellerForm : Form
    {
        public SellerForm()
        {
            InitializeComponent();
        }

        private readonly SqlConnection Con = new SqlConnection(Properties.Settings.Default.SqlConnectionString);

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_Sell_ID.Text = DGV_Sell.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Sell_Name.Text = DGV_Sell.Rows[rowIndex].Cells[1].Value.ToString();
            txt_Sell_Age.Text = DGV_Sell.Rows[rowIndex].Cells[2].Value.ToString();
            txt_Sell_Phone.Text = DGV_Sell.Rows[rowIndex].Cells[3].Value.ToString();
            txt_Sell_Pass.Text = DGV_Sell.Rows[rowIndex].Cells[4].Value.ToString();
        }

        private void Populate()
        {
            string query = "Select * from SellerTbl";
            DGV_Sell.DataSource = HelperDataGrid.Get(query).Tables[0];
        }

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            var id = txt_Sell_ID.Text;
            var name = txt_Sell_Name.Text;
            var phone = txt_Sell_Phone.Text;
            var age = txt_Sell_Age.Text;
            var password = txt_Sell_Pass.Text;
            try
            {
                string query = $"insert into SellerTbl values({id},'{name}',{age},'{phone}','{password}')";
                if (HelperDataGrid.InsertOrEdit(query))
                    MessageBox.Show("Added Successfuly");
                Populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_DELETE_Click(object sender, EventArgs e)
        {           
            string query = "delete from SellerTbl where SellerId=" + txt_Sell_ID.Text + "";               
            HelperDataGrid.Delete(query);
            Populate();
        }

        private void Button_EDIT_Click(object sender, EventArgs e)
        {
            var id = txt_Sell_ID.Text;
            var name = txt_Sell_Name.Text;
            var phone = txt_Sell_Phone.Text;
            var age = txt_Sell_Age.Text;
            var password = txt_Sell_Pass.Text;
            try
            {
                if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(age) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    string query = $"update SellerTbl set SellerName='{name}',SellerAge={age},SellerPhone='{phone}',SellerPass='{password}' where SellerId ={id};";
                    if (HelperDataGrid.InsertOrEdit(query))
                        MessageBox.Show("Updated Successfuly");
                    Populate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SellerForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Button_Products_Click(object sender, EventArgs e)
        {
            ProductForm product = new ProductForm();
            product.Show();
            this.Hide();
        }

        private void Button_Categories_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void Button_Selling_Click(object sender, EventArgs e)
        {
            SellingForm selling = new SellingForm();
            selling.Show();
            this.Hide();
        }
    }
}
