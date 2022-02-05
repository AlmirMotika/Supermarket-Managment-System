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
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-M15F5BI\MSSQLSERVER_OLAP;Initial Catalog=smarketdb;Integrated Security=True");

        private void Populate()
        {
            Con.Open();
            string query = "select ProdName,ProdQty from ProductTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGV_Prod.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Populatebills()
        {
            Con.Open();
            string query = "select * from BillTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DGV_Bills.DataSource = ds.Tables[0];
            ShowListView(ds.Tables[0]);
            Con.Close();
        }

        private void ShowListView(DataTable dataTable)
        {
            ListView listView = new ListView();
            listView.View = View.Details;
            listView.Dock = DockStyle.Fill;

            // Create list view columns
            foreach (DataColumn dataColumn in dataTable.Columns)
            {
                listView.Columns.Add(dataColumn.Caption);
            }

            // Create list view items
            foreach (DataRow dataRow in dataTable.Rows)
            {
                string[] cellValues = new string[dataTable.Columns.Count];

                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    object cellValue = dataRow[i];
                    if (cellValue != null)
                    {
                        cellValues[i] = cellValue.ToString();
                    }
                }
                ListViewItem rootItem = new ListViewItem(cellValues);
                listView.Items.Add(rootItem);
            }
            listView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);


            var form = new Form();
            form.Controls.Add(listView);
            form.ShowDialog();
        }

        private void DGV_Prod_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void SellingForm_Load(object sender, EventArgs e)
        {
            Populate();
            Populatebills();

        }
        int flag = 0;

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

        private void btn_Add_Sell_List_Click(object sender, EventArgs e)
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
            flag = 1;
        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void button_DELETE_Click(object sender, EventArgs e)
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
            if(txt_Prod_Name.Text=="" || txt_Quantity.Text=="")
            {
                MessageBox.Show("Missing Data");
            }
            int price = 0, quantity = 0, total=0;
            if(int.TryParse(txt_Prod_Price.Text,out price) && int.TryParse(txt_Quantity.Text,out quantity))
            total = price * quantity;
            
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.CreateCells(Order_DGV);
            newRow.Cells[0].Value = n + 1;
            newRow.Cells[1].Value = txt_Prod_Name.Text;
            newRow.Cells[2].Value = txt_Prod_Price.Text;
            newRow.Cells[3].Value = txt_Quantity.Text;
            newRow.Cells[4].Value = price*quantity;
            Order_DGV.Rows.Add(newRow);
            n++;
            Grdtotal = Grdtotal + total;
            Total_lbl.Text = Grdtotal.ToString();


        }
    }
}
