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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }   
        
        private void Populate()
        {            
            string query = "Select * from ProductTbl";            
            dataGridView1_Cell.DataSource = HelperDataGrid.Get(query).Tables[0];                  
        } 
               
        private void ProductForm_Load(object sender, EventArgs e)
        {
            string query = "select CatName from CategoryTbl";
            Populate();            
            combo_Category_Data.ValueMember = "catName";
            combo_Category_Data.DataSource= ComboHelper.FillCombo(query, "CatName");
        }

        private void Button_Cat_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_Prod_ID.Text = GetCellValue(rowIndex, 0);
            txt_Name.Text = GetCellValue(rowIndex,1);
            txt_Price.Text = GetCellValue(rowIndex, 2);
            txt_Qty.Text = GetCellValue(rowIndex, 3);
            Cat_combo.SelectedValue = GetCellValue(rowIndex, 4);
        }

        private string GetCellValue(int rowIndex, int cellIndex)
        {
            var cellValue = dataGridView1_Cell.Rows[rowIndex].Cells[cellIndex].Value;
            if (cellValue != null)
            {
                return cellValue.ToString();
            }
            return string.Empty;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SellerForm sell = new SellerForm();
            sell.Show();
            this.Hide();
        }     
        private void Button_ADD_Click(object sender, EventArgs e)
        {
            string query = "insert into ProductTbl values(" + txt_Prod_ID.Text + ",'" + txt_Name.Text + "'," + txt_Qty.Text + "," + txt_Price.Text + ",'" + Cat_combo.SelectedValue.ToString() + "')";
            if (HelperDataGrid.InsertOrEdit(query))
                MessageBox.Show("Added Successfuly");
            Populate();

        }
        
        private void Button_EDIT_Click(object sender, EventArgs e)
        {
            var prodId = txt_Prod_ID.Text;
            var name = txt_Name.Text;
            if (string.IsNullOrEmpty(prodId) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(txt_Qty.Text) || string.IsNullOrEmpty(txt_Price.Text))
            {                    
                MessageBox.Show("Missing information");
            }
            else
            {                                  
                string query = $"update ProductTbl set ProdName='{name}',ProdPrice={txt_Price.Text}, ProdQty=" + txt_Qty.Text + ",ProdCat='" + Cat_combo.SelectedValue.ToString() + "'where ProdID =" + txt_Prod_ID.Text + ";";                
                if (HelperDataGrid.InsertOrEdit(query))
                    MessageBox.Show("Updated Successfuly");
                Populate();
            }
           
        }
      
        private void Button_DELETE_Click(object sender, EventArgs e)
        {                     
            string query = "delete from ProductTbl where ProdID=" + txt_Prod_ID.Text + "";
            HelperDataGrid.Delete(query);
            Populate();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SellingForm sf = new SellingForm();
            sf.Show();
            this.Hide();
        }

        private void Button_refresh_Click(object sender, EventArgs e)
        {
            txt_Prod_ID.Text = string.Empty;
            txt_Name.Text = string.Empty;
            txt_Price.Text = string.Empty;
            txt_Qty.Text = string.Empty;            
        }

    }
}
