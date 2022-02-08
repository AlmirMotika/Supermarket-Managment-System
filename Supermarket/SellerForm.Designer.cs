namespace Supermarket
{
    partial class SellerForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Sell_Pass = new System.Windows.Forms.TextBox();
            this.DGV_Sell = new System.Windows.Forms.DataGridView();
            this.button_DELETE = new System.Windows.Forms.Button();
            this.button_EDIT = new System.Windows.Forms.Button();
            this.button_ADD = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Sell_Phone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Sell_Age = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Sell_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Sell_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.Button_Categories = new System.Windows.Forms.Button();
            this.Button_Selling = new System.Windows.Forms.Button();
            this.Button_Products = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sell)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.txt_Sell_Pass);
            this.panel1.Controls.Add(this.DGV_Sell);
            this.panel1.Controls.Add(this.button_DELETE);
            this.panel1.Controls.Add(this.button_EDIT);
            this.panel1.Controls.Add(this.button_ADD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Sell_Phone);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Sell_Age);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Sell_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Sell_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(177, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 684);
            this.panel1.TabIndex = 1;
            // 
            // txt_Sell_Pass
            // 
            this.txt_Sell_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Pass.Location = new System.Drawing.Point(131, 284);
            this.txt_Sell_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Sell_Pass.Name = "txt_Sell_Pass";
            this.txt_Sell_Pass.Size = new System.Drawing.Size(237, 29);
            this.txt_Sell_Pass.TabIndex = 17;
            // 
            // DGV_Sell
            // 
            this.DGV_Sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sell.Location = new System.Drawing.Point(391, 92);
            this.DGV_Sell.Margin = new System.Windows.Forms.Padding(4);
            this.DGV_Sell.Name = "DGV_Sell";
            this.DGV_Sell.RowHeadersWidth = 51;
            this.DGV_Sell.Size = new System.Drawing.Size(632, 575);
            this.DGV_Sell.TabIndex = 16;
            this.DGV_Sell.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // button_DELETE
            // 
            this.button_DELETE.BackColor = System.Drawing.SystemColors.Control;
            this.button_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DELETE.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_DELETE.Location = new System.Drawing.Point(256, 366);
            this.button_DELETE.Margin = new System.Windows.Forms.Padding(4);
            this.button_DELETE.Name = "button_DELETE";
            this.button_DELETE.Size = new System.Drawing.Size(115, 44);
            this.button_DELETE.TabIndex = 15;
            this.button_DELETE.Text = "DELETE";
            this.button_DELETE.UseVisualStyleBackColor = false;
            this.button_DELETE.Click += new System.EventHandler(this.Button_DELETE_Click);
            // 
            // button_EDIT
            // 
            this.button_EDIT.BackColor = System.Drawing.SystemColors.Control;
            this.button_EDIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EDIT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_EDIT.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_EDIT.Location = new System.Drawing.Point(133, 366);
            this.button_EDIT.Margin = new System.Windows.Forms.Padding(4);
            this.button_EDIT.Name = "button_EDIT";
            this.button_EDIT.Size = new System.Drawing.Size(115, 44);
            this.button_EDIT.TabIndex = 14;
            this.button_EDIT.Text = "EDIT";
            this.button_EDIT.UseVisualStyleBackColor = false;
            this.button_EDIT.Click += new System.EventHandler(this.button_EDIT_Click);
            // 
            // button_ADD
            // 
            this.button_ADD.BackColor = System.Drawing.SystemColors.Control;
            this.button_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ADD.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_ADD.Location = new System.Drawing.Point(11, 366);
            this.button_ADD.Margin = new System.Windows.Forms.Padding(4);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(115, 44);
            this.button_ADD.TabIndex = 13;
            this.button_ADD.Text = "ADD";
            this.button_ADD.UseVisualStyleBackColor = false;
            this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 292);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "PASSWORD";
            // 
            // txt_Sell_Phone
            // 
            this.txt_Sell_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Phone.Location = new System.Drawing.Point(131, 247);
            this.txt_Sell_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Sell_Phone.Name = "txt_Sell_Phone";
            this.txt_Sell_Phone.Size = new System.Drawing.Size(237, 29);
            this.txt_Sell_Phone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "PHONE";
            // 
            // txt_Sell_Age
            // 
            this.txt_Sell_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Age.Location = new System.Drawing.Point(131, 210);
            this.txt_Sell_Age.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Sell_Age.Name = "txt_Sell_Age";
            this.txt_Sell_Age.Size = new System.Drawing.Size(237, 29);
            this.txt_Sell_Age.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 218);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "AGE";
            // 
            // txt_Sell_Name
            // 
            this.txt_Sell_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Name.Location = new System.Drawing.Point(131, 174);
            this.txt_Sell_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Sell_Name.Name = "txt_Sell_Name";
            this.txt_Sell_Name.Size = new System.Drawing.Size(237, 29);
            this.txt_Sell_Name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 181);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME";
            // 
            // txt_Sell_ID
            // 
            this.txt_Sell_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_ID.Location = new System.Drawing.Point(131, 137);
            this.txt_Sell_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Sell_ID.Name = "txt_Sell_ID";
            this.txt_Sell_ID.Size = new System.Drawing.Size(237, 29);
            this.txt_Sell_ID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 144);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.YellowGreen;
            this.button4.Location = new System.Drawing.Point(296, 4);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(324, 44);
            this.button4.TabIndex = 2;
            this.button4.Text = "MANAGE SELLERS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Button_Categories
            // 
            this.Button_Categories.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Categories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Categories.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Categories.ForeColor = System.Drawing.Color.YellowGreen;
            this.Button_Categories.Location = new System.Drawing.Point(16, 181);
            this.Button_Categories.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Categories.Name = "Button_Categories";
            this.Button_Categories.Size = new System.Drawing.Size(141, 44);
            this.Button_Categories.TabIndex = 6;
            this.Button_Categories.Text = "Categories";
            this.Button_Categories.UseVisualStyleBackColor = false;
            this.Button_Categories.Click += new System.EventHandler(this.Button_Categories_Click);
            // 
            // Button_Selling
            // 
            this.Button_Selling.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Selling.ForeColor = System.Drawing.Color.YellowGreen;
            this.Button_Selling.Location = new System.Drawing.Point(16, 245);
            this.Button_Selling.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Selling.Name = "Button_Selling";
            this.Button_Selling.Size = new System.Drawing.Size(141, 44);
            this.Button_Selling.TabIndex = 5;
            this.Button_Selling.Text = "Selling";
            this.Button_Selling.UseVisualStyleBackColor = false;
            this.Button_Selling.Click += new System.EventHandler(this.Button_Selling_Click);
            // 
            // Button_Products
            // 
            this.Button_Products.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Products.ForeColor = System.Drawing.Color.YellowGreen;
            this.Button_Products.Location = new System.Drawing.Point(16, 116);
            this.Button_Products.Margin = new System.Windows.Forms.Padding(4);
            this.Button_Products.Name = "Button_Products";
            this.Button_Products.Size = new System.Drawing.Size(141, 44);
            this.Button_Products.TabIndex = 4;
            this.Button_Products.Text = "Products";
            this.Button_Products.UseVisualStyleBackColor = false;
            this.Button_Products.Click += new System.EventHandler(this.Button_Products_Click);
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1236, 748);
            this.Controls.Add(this.Button_Categories);
            this.Controls.Add(this.Button_Selling);
            this.Controls.Add(this.Button_Products);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SellerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerForm";
            this.Load += new System.EventHandler(this.SellerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Sell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView DGV_Sell;
        private System.Windows.Forms.Button button_DELETE;
        private System.Windows.Forms.Button button_EDIT;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Sell_Phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Sell_Age;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Sell_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Sell_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txt_Sell_Pass;
        private System.Windows.Forms.Button Button_Categories;
        private System.Windows.Forms.Button Button_Selling;
        private System.Windows.Forms.Button Button_Products;
    }
}