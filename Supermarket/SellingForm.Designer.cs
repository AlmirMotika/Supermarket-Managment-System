namespace Supermarket
{
    partial class SellingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellingForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.Order_DGV = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_Product = new System.Windows.Forms.Button();
            this.Seller_lbl = new System.Windows.Forms.Label();
            this.Date_lbl = new System.Windows.Forms.Label();
            this.button_refresh = new System.Windows.Forms.Button();
            this.combo_Category_Data = new System.Windows.Forms.ComboBox();
            this.DGV_Prod = new System.Windows.Forms.DataGridView();
            this.DGV_Bills = new System.Windows.Forms.DataGridView();
            this.button_DELETE = new System.Windows.Forms.Button();
            this.button_Print = new System.Windows.Forms.Button();
            this.btn_Add_Sell_List = new System.Windows.Forms.Button();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Prod_Price = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Prod_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Bill_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.Button_Seller = new System.Windows.Forms.Button();
            this.Button_Product = new System.Windows.Forms.Button();
            this.Button_Category = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Prod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bills)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.Order_DGV);
            this.panel1.Controls.Add(this.Total_lbl);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Add_Product);
            this.panel1.Controls.Add(this.Seller_lbl);
            this.panel1.Controls.Add(this.Date_lbl);
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.combo_Category_Data);
            this.panel1.Controls.Add(this.DGV_Prod);
            this.panel1.Controls.Add(this.DGV_Bills);
            this.panel1.Controls.Add(this.button_DELETE);
            this.panel1.Controls.Add(this.button_Print);
            this.panel1.Controls.Add(this.btn_Add_Sell_List);
            this.panel1.Controls.Add(this.txt_Quantity);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Prod_Price);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Prod_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Bill_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(105, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 684);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.YellowGreen;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(631, 357);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "SELLS LIST";
            // 
            // Order_DGV
            // 
            this.Order_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Order_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.PName,
            this.Price,
            this.Quantity,
            this.Total});
            this.Order_DGV.Location = new System.Drawing.Point(452, 84);
            this.Order_DGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Order_DGV.Name = "Order_DGV";
            this.Order_DGV.RowHeadersWidth = 51;
            this.Order_DGV.Size = new System.Drawing.Size(541, 194);
            this.Order_DGV.TabIndex = 27;
            // 
            // Id
            // 
            this.Id.HeaderText = "ProdID";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // PName
            // 
            this.PName.HeaderText = "ProdName";
            this.PName.MinimumWidth = 6;
            this.PName.Name = "PName";
            this.PName.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // Total_lbl
            // 
            this.Total_lbl.AutoSize = true;
            this.Total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_lbl.Location = new System.Drawing.Point(700, 298);
            this.Total_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Total_lbl.Name = "Total_lbl";
            this.Total_lbl.Size = new System.Drawing.Size(51, 20);
            this.Total_lbl.TabIndex = 26;
            this.Total_lbl.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(577, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Amount";
            // 
            // Add_Product
            // 
            this.Add_Product.BackColor = System.Drawing.SystemColors.Control;
            this.Add_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Product.ForeColor = System.Drawing.Color.YellowGreen;
            this.Add_Product.Location = new System.Drawing.Point(160, 229);
            this.Add_Product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_Product.Name = "Add_Product";
            this.Add_Product.Size = new System.Drawing.Size(175, 32);
            this.Add_Product.TabIndex = 24;
            this.Add_Product.Text = "ADD PRODUCT";
            this.Add_Product.UseVisualStyleBackColor = false;
            this.Add_Product.Click += new System.EventHandler(this.Add_Product_Click);
            // 
            // Seller_lbl
            // 
            this.Seller_lbl.AutoSize = true;
            this.Seller_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seller_lbl.Location = new System.Drawing.Point(57, 17);
            this.Seller_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Seller_lbl.Name = "Seller_lbl";
            this.Seller_lbl.Size = new System.Drawing.Size(58, 20);
            this.Seller_lbl.TabIndex = 23;
            this.Seller_lbl.Text = "Seller";
            // 
            // Date_lbl
            // 
            this.Date_lbl.AutoSize = true;
            this.Date_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_lbl.Location = new System.Drawing.Point(925, 17);
            this.Date_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Date_lbl.Name = "Date_lbl";
            this.Date_lbl.Size = new System.Drawing.Size(49, 20);
            this.Date_lbl.TabIndex = 21;
            this.Date_lbl.Text = "Date";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_refresh.Location = new System.Drawing.Point(253, 288);
            this.button_refresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(117, 30);
            this.button_refresh.TabIndex = 20;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            // 
            // combo_Category_Data
            // 
            this.combo_Category_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Category_Data.FormattingEnabled = true;
            this.combo_Category_Data.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.combo_Category_Data.Location = new System.Drawing.Point(21, 288);
            this.combo_Category_Data.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_Category_Data.Name = "combo_Category_Data";
            this.combo_Category_Data.Size = new System.Drawing.Size(211, 28);
            this.combo_Category_Data.TabIndex = 19;
            this.combo_Category_Data.Text = "SELECT CATEGORY";
            // 
            // DGV_Prod
            // 
            this.DGV_Prod.AllowDrop = true;
            this.DGV_Prod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Prod.Location = new System.Drawing.Point(43, 336);
            this.DGV_Prod.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Prod.Name = "DGV_Prod";
            this.DGV_Prod.RowHeadersWidth = 51;
            this.DGV_Prod.Size = new System.Drawing.Size(327, 331);
            this.DGV_Prod.TabIndex = 18;
            this.DGV_Prod.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_Prod_RowHeaderMouseClick);
            // 
            // DGV_Bills
            // 
            this.DGV_Bills.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Bills.Location = new System.Drawing.Point(452, 396);
            this.DGV_Bills.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGV_Bills.Name = "DGV_Bills";
            this.DGV_Bills.RowHeadersWidth = 51;
            this.DGV_Bills.Size = new System.Drawing.Size(541, 208);
            this.DGV_Bills.TabIndex = 16;
            this.DGV_Bills.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Bills_CellContentClick);
            // 
            // button_DELETE
            // 
            this.button_DELETE.BackColor = System.Drawing.SystemColors.Control;
            this.button_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DELETE.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_DELETE.Location = new System.Drawing.Point(759, 623);
            this.button_DELETE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_DELETE.Name = "button_DELETE";
            this.button_DELETE.Size = new System.Drawing.Size(115, 44);
            this.button_DELETE.TabIndex = 15;
            this.button_DELETE.Text = "DELETE";
            this.button_DELETE.UseVisualStyleBackColor = false;
            this.button_DELETE.Click += new System.EventHandler(this.Button_DELETE_Click);
            // 
            // button_Print
            // 
            this.button_Print.BackColor = System.Drawing.SystemColors.Control;
            this.button_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Print.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_Print.Location = new System.Drawing.Point(636, 623);
            this.button_Print.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Print.Name = "button_Print";
            this.button_Print.Size = new System.Drawing.Size(115, 44);
            this.button_Print.TabIndex = 14;
            this.button_Print.Text = "PRINT";
            this.button_Print.UseVisualStyleBackColor = false;
            this.button_Print.Click += new System.EventHandler(this.Button_Print_Click);
            // 
            // btn_Add_Sell_List
            // 
            this.btn_Add_Sell_List.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Add_Sell_List.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Sell_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_Sell_List.ForeColor = System.Drawing.Color.YellowGreen;
            this.btn_Add_Sell_List.Location = new System.Drawing.Point(513, 623);
            this.btn_Add_Sell_List.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Add_Sell_List.Name = "btn_Add_Sell_List";
            this.btn_Add_Sell_List.Size = new System.Drawing.Size(115, 44);
            this.btn_Add_Sell_List.TabIndex = 13;
            this.btn_Add_Sell_List.Text = "ADD";
            this.btn_Add_Sell_List.UseVisualStyleBackColor = false;
            this.btn_Add_Sell_List.Click += new System.EventHandler(this.Btn_Add_Sell_List_Click);
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Quantity.Location = new System.Drawing.Point(131, 192);
            this.txt_Quantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(237, 29);
            this.txt_Quantity.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "QUANTITY";
            // 
            // txt_Prod_Price
            // 
            this.txt_Prod_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prod_Price.Location = new System.Drawing.Point(131, 155);
            this.txt_Prod_Price.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Prod_Price.Name = "txt_Prod_Price";
            this.txt_Prod_Price.Size = new System.Drawing.Size(237, 29);
            this.txt_Prod_Price.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "PRICE";
            // 
            // txt_Prod_Name
            // 
            this.txt_Prod_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prod_Name.Location = new System.Drawing.Point(131, 118);
            this.txt_Prod_Name.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Prod_Name.Name = "txt_Prod_Name";
            this.txt_Prod_Name.Size = new System.Drawing.Size(237, 29);
            this.txt_Prod_Name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 126);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "PROD NAME";
            // 
            // txt_Bill_ID
            // 
            this.txt_Bill_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Bill_ID.Location = new System.Drawing.Point(131, 84);
            this.txt_Bill_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Bill_ID.Name = "txt_Bill_ID";
            this.txt_Bill_ID.Size = new System.Drawing.Size(237, 29);
            this.txt_Bill_ID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "BILLID";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.YellowGreen;
            this.button4.Location = new System.Drawing.Point(296, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(324, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "SELLING";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Button_Seller
            // 
            this.Button_Seller.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Seller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Seller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Seller.ForeColor = System.Drawing.Color.YellowGreen;
            this.Button_Seller.Location = new System.Drawing.Point(3, 58);
            this.Button_Seller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Seller.Name = "Button_Seller";
            this.Button_Seller.Size = new System.Drawing.Size(99, 32);
            this.Button_Seller.TabIndex = 25;
            this.Button_Seller.Text = "Seller";
            this.Button_Seller.UseVisualStyleBackColor = false;
            this.Button_Seller.Click += new System.EventHandler(this.Button_Seller_Click);
            // 
            // Button_Product
            // 
            this.Button_Product.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Product.ForeColor = System.Drawing.Color.YellowGreen;
            this.Button_Product.Location = new System.Drawing.Point(3, 97);
            this.Button_Product.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Product.Name = "Button_Product";
            this.Button_Product.Size = new System.Drawing.Size(95, 32);
            this.Button_Product.TabIndex = 26;
            this.Button_Product.Text = "Product";
            this.Button_Product.UseVisualStyleBackColor = false;
            this.Button_Product.Click += new System.EventHandler(this.Button_Product_Click);
            // 
            // Button_Category
            // 
            this.Button_Category.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Category.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Category.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Category.ForeColor = System.Drawing.Color.YellowGreen;
            this.Button_Category.Location = new System.Drawing.Point(3, 137);
            this.Button_Category.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Category.Name = "Button_Category";
            this.Button_Category.Size = new System.Drawing.Size(99, 32);
            this.Button_Category.TabIndex = 27;
            this.Button_Category.Text = "Category";
            this.Button_Category.UseVisualStyleBackColor = false;
            this.Button_Category.Click += new System.EventHandler(this.Button_Category_Click);
            // 
            // SellingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1215, 700);
            this.Controls.Add(this.Button_Category);
            this.Controls.Add(this.Button_Product);
            this.Controls.Add(this.Button_Seller);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SellingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellingForm";
            this.Load += new System.EventHandler(this.SellingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Order_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Prod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Bills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_Bills;
        private System.Windows.Forms.Button button_DELETE;
        private System.Windows.Forms.Button button_Print;
        private System.Windows.Forms.Button btn_Add_Sell_List;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Prod_Price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Prod_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Bill_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView DGV_Prod;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox combo_Category_Data;
        private System.Windows.Forms.Button Add_Product;
        private System.Windows.Forms.Label Seller_lbl;
        private System.Windows.Forms.Label Date_lbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView Order_DGV;
        private System.Windows.Forms.Label Total_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn PName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button Button_Seller;
        private System.Windows.Forms.Button Button_Product;
        private System.Windows.Forms.Button Button_Category;
    }
}