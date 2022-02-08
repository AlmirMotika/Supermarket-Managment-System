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

        private void button_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into CategoryTbl values(" + CatIdTbl.Text + ",'" + CatNameTbl.Text + "','" + CatDescTbl.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added successfully");
                Con.Close();
                Populate();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void Populate()
        {
            Con.Open();
            string query = "Select * from CategoryTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            CatDGV.DataSource = ds.Tables[0];
            Con.Close();
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
                Con.Open();
                string query = "delete from CategoryTbl where CatId=" + CatIdTbl.Text + "";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category deleted successfully");
                Con.Close();
                Populate();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if(CatIdTbl.Text=="" || CatNameTbl.Text=="" || CatDescTbl.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update CategoryTbl set CatName='" + CatNameTbl.Text + "',CatDesc='" + CatDescTbl.Text + "'where CatId=" + CatIdTbl.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category successfully updated");
                    Con.Close();
                    Populate();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_Products_Click(object sender, EventArgs e)
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
 