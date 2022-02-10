using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Supermarket
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        private readonly SqlConnection Con = new SqlConnection(Properties.Settings.Default.SqlConnectionString);        

        private void Button_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into ProductTbl values(" + CatIdTbl.Text + ",'" + CatNameTbl.Text + "'," + CatDescTbl.Text + "')";
                if (HelperDataGrid.InsertOrEdit(query))
                    MessageBox.Show("Added Successfuly");
                Populate();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Populate()
        {          
            string query = "Select * from CategoryTbl";
            CatDGV.DataSource = HelperDataGrid.Get(query).Tables[0];
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            Populate(); 
        }

        private void CatDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            CatIdTbl.Text = CatDGV.Rows[rowIndex].Cells[0].Value.ToString();
            CatNameTbl.Text = CatDGV.Rows[rowIndex].Cells[1].Value.ToString();
            CatDescTbl.Text = CatDGV.Rows[rowIndex].Cells[2].Value.ToString();

        }

        private void Button_DELETE_Click(object sender, EventArgs e)
        {
            try
            {             
                string query = "delete from CategoryTbl where CatId=" + CatIdTbl.Text + "";
                HelperDataGrid.Delete(query);
                Populate();
                MessageBox.Show("Category deleted successfully");                                               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Button_EDIT_Click(object sender, EventArgs e)
        {
            var Id = CatIdTbl.Text;
            var name = CatNameTbl.Text;
            var desc = CatDescTbl.Text;

            try
            {
                if (string.IsNullOrEmpty(Id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(desc))
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    string query = "update ProductTbl set ProdName='" + name + "',ProdPrice=" + desc + "'where CatId=" + Id + ";";
                    if (HelperDataGrid.InsertOrEdit(query))
                        MessageBox.Show("Updated Successfuly");
                    Populate();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void Button_Products_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void Button_Sellers_Click(object sender, EventArgs e)
        {
            SellerForm sell = new SellerForm();
            sell.Show();
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
 