namespace Supermarket
{
    partial class CategoryForm
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
            this.CatDGV = new System.Windows.Forms.DataGridView();
            this.button_DELETE = new System.Windows.Forms.Button();
            this.button_EDIT = new System.Windows.Forms.Button();
            this.button_ADD = new System.Windows.Forms.Button();
            this.CatDescTbl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CatNameTbl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CatIdTbl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button_Products = new System.Windows.Forms.Button();
            this.Button_Selling = new System.Windows.Forms.Button();
            this.button_Sellers = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.CatDGV);
            this.panel1.Controls.Add(this.button_DELETE);
            this.panel1.Controls.Add(this.button_EDIT);
            this.panel1.Controls.Add(this.button_ADD);
            this.panel1.Controls.Add(this.CatDescTbl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CatNameTbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CatIdTbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Location = new System.Drawing.Point(133, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 556);
            this.panel1.TabIndex = 2;
            // 
            // CatDGV
            // 
            this.CatDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CatDGV.Location = new System.Drawing.Point(293, 75);
            this.CatDGV.Name = "CatDGV";
            this.CatDGV.RowHeadersWidth = 51;
            this.CatDGV.Size = new System.Drawing.Size(474, 467);
            this.CatDGV.TabIndex = 16;
            this.CatDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CatDGV_RowHeaderMouseClick);
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
            // CatDescTbl
            // 
            this.CatDescTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatDescTbl.Location = new System.Drawing.Point(118, 171);
            this.CatDescTbl.Name = "CatDescTbl";
            this.CatDescTbl.Size = new System.Drawing.Size(159, 24);
            this.CatDescTbl.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "DESCRIPTION";
            // 
            // CatNameTbl
            // 
            this.CatNameTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatNameTbl.Location = new System.Drawing.Point(118, 141);
            this.CatNameTbl.Name = "CatNameTbl";
            this.CatNameTbl.Size = new System.Drawing.Size(159, 24);
            this.CatNameTbl.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "NAME";
            // 
            // CatIdTbl
            // 
            this.CatIdTbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CatIdTbl.Location = new System.Drawing.Point(118, 111);
            this.CatIdTbl.Name = "CatIdTbl";
            this.CatIdTbl.Size = new System.Drawing.Size(159, 24);
            this.CatIdTbl.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 114);
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
            this.button4.Text = "MANAGE CATEGORIES";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button_Products
            // 
            this.button_Products.BackColor = System.Drawing.SystemColors.Control;
            this.button_Products.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Products.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_Products.Location = new System.Drawing.Point(12, 149);
            this.button_Products.Name = "button_Products";
            this.button_Products.Size = new System.Drawing.Size(106, 36);
            this.button_Products.TabIndex = 9;
            this.button_Products.Text = "Products";
            this.button_Products.UseVisualStyleBackColor = false;
            this.button_Products.Click += new System.EventHandler(this.Button_Products_Click);
            // 
            // Button_Selling
            // 
            this.Button_Selling.BackColor = System.Drawing.SystemColors.Control;
            this.Button_Selling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Selling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Selling.ForeColor = System.Drawing.Color.YellowGreen;
            this.Button_Selling.Location = new System.Drawing.Point(12, 201);
            this.Button_Selling.Name = "Button_Selling";
            this.Button_Selling.Size = new System.Drawing.Size(106, 36);
            this.Button_Selling.TabIndex = 8;
            this.Button_Selling.Text = "Selling";
            this.Button_Selling.UseVisualStyleBackColor = false;
            this.Button_Selling.Click += new System.EventHandler(this.Button_Selling_Click);
            // 
            // button_Sellers
            // 
            this.button_Sellers.BackColor = System.Drawing.SystemColors.Control;
            this.button_Sellers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Sellers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Sellers.ForeColor = System.Drawing.Color.YellowGreen;
            this.button_Sellers.Location = new System.Drawing.Point(12, 96);
            this.button_Sellers.Name = "button_Sellers";
            this.button_Sellers.Size = new System.Drawing.Size(106, 36);
            this.button_Sellers.TabIndex = 7;
            this.button_Sellers.Text = "Sellers";
            this.button_Sellers.UseVisualStyleBackColor = false;
            this.button_Sellers.Click += new System.EventHandler(this.Button_Sellers_Click);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(927, 608);
            this.Controls.Add(this.button_Products);
            this.Controls.Add(this.Button_Selling);
            this.Controls.Add(this.button_Sellers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryForm";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CatDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView CatDGV;
        private System.Windows.Forms.Button button_DELETE;
        private System.Windows.Forms.Button button_EDIT;
        private System.Windows.Forms.Button button_ADD;
        private System.Windows.Forms.TextBox CatDescTbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CatNameTbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CatIdTbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button_Products;
        private System.Windows.Forms.Button Button_Selling;
        private System.Windows.Forms.Button button_Sellers;
    }
}