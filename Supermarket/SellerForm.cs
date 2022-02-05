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
        readonly HellperClass obj = new HellperClass();
        // SqlConnection Con = new SqlConnection(Properties.Settings.Default.DatabaseConnectionString);
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-M15F5BI\MSSQLSERVER_OLAP;Initial Catalog=smarketdb;Integrated Security=True");


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
            Con.Open();
            string query = "Select * from SellerTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            DGV_Sell.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void button_ADD_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "insert into SellerTbl values(" + txt_Sell_ID.Text + ",'" + txt_Sell_Name.Text + "'," + txt_Sell_Age.Text + ",'"+txt_Sell_Phone.Text+"','"+txt_Sell_Pass.Text+"')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Seller added successfully");
                Con.Close();
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
            obj.Delete(query);
            Populate();

        }

        private void button_EDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Sell_ID.Text == "" || txt_Sell_Name.Text == "" || txt_Sell_Phone.Text == "" || txt_Sell_Age.Text == "" || txt_Sell_Pass.Text == "")
                {
                    MessageBox.Show("Missing information");
                }
                else
                {
                    Con.Open();
                    string query = "update SellerTbl set SellerName='" + txt_Sell_Name.Text + "',SellerAge=" + txt_Sell_Age.Text + ",SellerPhone='"+ txt_Sell_Phone.Text+"',SellerPass='"+ txt_Sell_Pass.Text+"'where SellerId =" + txt_Sell_ID.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Seller successfully updated");
                    Con.Close();
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
    }
}
