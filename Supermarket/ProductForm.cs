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

        readonly HellperClass obj = new HellperClass();
        //  readonly SqlConnection Con = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-M15F5BI\MSSQLSERVER_OLAP;Initial Catalog=smarketdb;Integrated Security=True");

        private void Button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
        private void Populate()
        {
            
            string query = "Select * from ProductTbl";            
            dataGridView1_Cell.DataSource = obj.Get(query).Tables[0];
            
        }      
        private void ProductForm_Load(object sender, EventArgs e)
        {           
            string ColumnName = "CatName";           
            Cat_combo.ValueMember = ColumnName;
            Cat_combo.DataSource = obj.FillCombo("Select CatName from CategoryTbl", ColumnName);
            Populate();
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
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }       
        private void Button_ADD_Click(object sender, EventArgs e)
        {
            string query = "insert into ProductTbl values(" + txt_Prod_ID.Text + ",'" + txt_Name.Text + "'," + txt_Qty.Text + "," + txt_Price.Text + ",'" + Cat_combo.SelectedValue.ToString() + "')";
            if (obj.InsertOrEdit(query))
                MessageBox.Show("Added Successfuly");
            Populate();

        }
        
        private void Button_EDIT_Click(object sender, EventArgs e)
        {           
               
            if (string.IsNullOrEmpty(txt_Prod_ID.Text) || string.IsNullOrEmpty(txt_Name.Text) || string.IsNullOrEmpty(txt_Qty.Text) || string.IsNullOrEmpty(txt_Price.Text))
            {                    
                MessageBox.Show("Missing information");
            }
            else
            {                                  
                string query = "update ProductTbl set ProdName='" + txt_Name.Text + "',ProdPrice=" + txt_Price.Text + ",ProdQty=" + txt_Qty.Text + ",ProdCat='" + Cat_combo.SelectedValue.ToString() + "'where ProdID =" + txt_Prod_ID.Text + ";";                
                if (obj.InsertOrEdit(query))
                    MessageBox.Show("Updated Successfuly");
                Populate();
            }
           
        }
      
        private void Button_DELETE_Click(object sender, EventArgs e)
        {                     
            string query = "delete from ProductTbl where ProdID=" + txt_Prod_ID.Text + "";
            obj.Delete(query);
            Populate();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SellingForm sf = new SellingForm();
            sf.Show();
            this.Hide();
        }
    }
}
