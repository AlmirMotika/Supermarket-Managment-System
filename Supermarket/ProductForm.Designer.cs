namespace Supermarket
{
    partial class ProductForm
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
            this.button_refresh = new System.Windows.Forms.Button();
            this.combo_Category_Data = new System.Windows.Forms.ComboBox();
            this.dataGridView1_Cell = new System.Windows.Forms.DataGridView();
            this.button_DELETE = new System.Windows.Forms.Button();
            this.button_EDIT = new System.Windows.Forms.Button();
            this.button_ADD = new System.Windows.Forms.Button();
            this.Cat_combo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Qty = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Prod_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button_Cat = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Cell)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.button_refresh);
            this.panel1.Controls.Add(this.combo_Category_Data);
            this.panel1.Controls.Add(this.dataGridView1_Cell);
            this.panel1.Controls.Add(this.button_DELETE);
            this.panel1.Controls.Add(this.button_EDIT);
            this.panel1.Controls.Add(this.button_ADD);
            this.panel1.Controls.Add(this.Cat_combo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_Price);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Qty);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_Prod_ID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(133, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 556);
            this.panel1.TabIndex = 0;
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_refresh.Location = new System.Drawing.Point(562, 45);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(88, 24);
            this.button_refresh.TabIndex = 18;
            this.button_refresh.Text = "Refresh";
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.Button_refresh_Click);
            // 
            // combo_Category_Data
            // 
            this.combo_Category_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Category_Data.FormattingEnabled = true;
            this.combo_Category_Data.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.combo_Category_Data.Location = new System.Drawing.Point(382, 45);
            this.combo_Category_Data.Name = "combo_Category_Data";
            this.combo_Category_Data.Size = new System.Drawing.Size(159, 24);
            this.combo_Category_Data.TabIndex = 17;
            this.combo_Category_Data.Text = "SELECT CATEGORY";
            // 
            // dataGridView1_Cell
            // 
            this.dataGridView1_Cell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1_Cell.Location = new System.Drawing.Point(293, 75);
            this.dataGridView1_Cell.Name = "dataGridView1_Cell";
            this.dataGridView1_Cell.Size = new System.Drawing.Size(474, 467);
            this.dataGridView1_Cell.TabIndex = 16;
            this.dataGridView1_Cell.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_RowHeaderMouseClick);
            // 
            // button_DELETE
            // 
            this.button_DELETE.BackColor = System.Drawing.SystemColors.Control;
            this.button_DELETE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DELETE.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_DELETE.Location = new System.Drawing.Point(192, 297);
            this.button_DELETE.Name = "button_DELETE";
            this.button_DELETE.Size = new System.Drawing.Size(86, 36);
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
            this.button_EDIT.Location = new System.Drawing.Point(100, 297);
            this.button_EDIT.Name = "button_EDIT";
            this.button_EDIT.Size = new System.Drawing.Size(86, 36);
            this.button_EDIT.TabIndex = 14;
            this.button_EDIT.Text = "EDIT";
            this.button_EDIT.UseVisualStyleBackColor = false;
            this.button_EDIT.Click += new System.EventHandler(this.Button_EDIT_Click);
            // 
            // button_ADD
            // 
            this.button_ADD.BackColor = System.Drawing.SystemColors.Control;
            this.button_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ADD.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_ADD.Location = new System.Drawing.Point(8, 297);
            this.button_ADD.Name = "button_ADD";
            this.button_ADD.Size = new System.Drawing.Size(86, 36);
            this.button_ADD.TabIndex = 13;
            this.button_ADD.Text = "ADD";
            this.button_ADD.UseVisualStyleBackColor = false;
            this.button_ADD.Click += new System.EventHandler(this.Button_ADD_Click);
            // 
            // Cat_combo
            // 
            this.Cat_combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cat_combo.FormattingEnabled = true;
            this.Cat_combo.Items.AddRange(new object[] {
            "ADMIN",
            "SELLER"});
            this.Cat_combo.Location = new System.Drawing.Point(98, 231);
            this.Cat_combo.Name = "Cat_combo";
            this.Cat_combo.Size = new System.Drawing.Size(179, 24);
            this.Cat_combo.TabIndex = 12;
            this.Cat_combo.Text = "SELECT CATEGORY";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "CATEGORY";
            // 
            // txt_Price
            // 
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(98, 201);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(179, 24);
            this.txt_Price.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "PRICE";
            // 
            // txt_Qty
            // 
            this.txt_Qty.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qty.Location = new System.Drawing.Point(98, 171);
            this.txt_Qty.Name = "txt_Qty";
            this.txt_Qty.Size = new System.Drawing.Size(179, 24);
            this.txt_Qty.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "QUANTITY";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(98, 141);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(179, 24);
            this.txt_Name.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME";
            // 
            // txt_Prod_ID
            // 
            this.txt_Prod_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prod_ID.Location = new System.Drawing.Point(98, 111);
            this.txt_Prod_ID.Name = "txt_Prod_ID";
            this.txt_Prod_ID.Size = new System.Drawing.Size(179, 24);
            this.txt_Prod_ID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.YellowGreen;
            this.button4.Location = new System.Drawing.Point(222, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 36);
            this.button4.TabIndex = 2;
            this.button4.Text = "MANAGE PRODUCTS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(41, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 36);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sellers";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.YellowGreen;
            this.button2.Location = new System.Drawing.Point(41, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Selling";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button_Cat
            // 
            this.button_Cat.BackColor = System.Drawing.SystemColors.Control;
            this.button_Cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Cat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Cat.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_Cat.Location = new System.Drawing.Point(41, 151);
            this.button_Cat.Name = "button_Cat";
            this.button_Cat.Size = new System.Drawing.Size(86, 36);
            this.button_Cat.TabIndex = 3;
            this.button_Cat.Text = "Categor";
            this.button_Cat.UseVisualStyleBackColor = false;
            this.button_Cat.Click += new System.EventHandler(this.Button_Cat_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Control;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.YellowGreen;
            this.button5.Location = new System.Drawing.Point(779, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 29);
            this.button5.TabIndex = 3;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 608);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button_Cat);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1_Cell)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_Cat;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Qty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Prod_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ComboBox combo_Category_Data;
        private System.Windows.Forms.DataGridView dataGridView1_Cell;
        private System.Windows.Forms.Button button_DELETE;
        private System.Windows.Forms.Button button_EDIT;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.ComboBox Cat_combo;
    }
}