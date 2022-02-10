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
    public partial class SellingForm : Form
    {
        public SellingForm()
        {
            InitializeComponent();
        }
        private readonly SqlConnection Con = new SqlConnection(Properties.Settings.Default.SqlConnectionString);

        private void Populate()
        {            
            string query = "select ProdName,ProdQty from ProductTbl";
            DGV_Prod.DataSource = HelperDataGrid.Get(query).Tables[0];
            
        }
        private void Populatebills()
        {           
            string query = "select * from BillTbl";
            DGV_Bills.DataSource = HelperDataGrid.Get(query).Tables[0];      
        }
        private void SellingForm_Load(object sender, EventArgs e)
        {
            Populate();
            Populatebills();

        }
        

        private void DGV_Prod_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txt_Prod_Name.Text = DGV_Prod.Rows[rowIndex].Cells[0].Value.ToString();
            txt_Prod_Price.Text = DGV_Prod.Rows[rowIndex].Cells[1].Value.ToString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Date_lbl.Text = DateTime.Today.Day.ToString() + "/" + DateTime.Today.Month.ToString() + "/" + DateTime.Today.Year.ToString();
        }
        int Grdtotal = 0, n = 0;

        private void Btn_Add_Sell_List_Click(object sender, EventArgs e)
        {
            if (txt_Bill_ID.Text == "")
            {
                MessageBox.Show("Missing BillID");
            }
            else
            {

            try
            {
                Con.Open();
                string query = "insert into BillTbl values(" + txt_Bill_ID.Text + ",'"+Seller_lbl.Text+"','" + Date_lbl.Text + "'," + Total_lbl.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order added successfully");
                Con.Close();
                Populatebills();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("FAMILYSUPERMARKET", new Font("Century Gothic", 25, FontStyle.Bold),Brushes.Red, new Point(230));
        }

        private void DGV_Bills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button_Print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void Button_DELETE_Click(object sender, EventArgs e)
        {

        }

        private void Button_Seller_Click(object sender, EventArgs e)
        {
            SellerForm sell = new SellerForm();
            sell.Show();
            this.Hide();
        }

        private void Button_Product_Click(object sender, EventArgs e)
        {
            ProductForm prod = new ProductForm();
            prod.Show();
            this.Hide();
        }

        private void Button_Category_Click(object sender, EventArgs e)
        {
            CategoryForm cat = new CategoryForm();
            cat.Show();
            this.Hide();
        }

        private void Add_Product_Click(object sender, EventArgs e)
        {
            var name = txt_Prod_Name.Text;
            var quantity = txt_Quantity.Text;
            var price = txt_Prod_Price.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Missing Data");
            }
            int price2 = 0, quantity2 = 0, total=0;
            if(int.TryParse(price,out price2) && int.TryParse(quantity,out quantity2))
            total = price2 * quantity2;
            
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(Order_DGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = name;
            newRow.Cells[2].Value = price;
            newRow.Cells[3].Value = quantity;
            newRow.Cells[4].Value = price2*quantity2;
            Order_DGV.Rows.Add(newRow);
            n++;
            Grdtotal += total;
            Total_lbl.Text = Grdtotal.ToString();


        }
    }
}
