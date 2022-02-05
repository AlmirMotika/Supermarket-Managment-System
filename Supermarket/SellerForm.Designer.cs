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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(133, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 556);
            this.panel1.TabIndex = 1;
            // 
            // txt_Sell_Pass
            // 
            this.txt_Sell_Pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Pass.Location = new System.Drawing.Point(98, 231);
            this.txt_Sell_Pass.Name = "txt_Sell_Pass";
            this.txt_Sell_Pass.Size = new System.Drawing.Size(179, 24);
            this.txt_Sell_Pass.TabIndex = 17;
            // 
            // DGV_Sell
            // 
            this.DGV_Sell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Sell.Location = new System.Drawing.Point(293, 75);
            this.DGV_Sell.Name = "DGV_Sell";
            this.DGV_Sell.Size = new System.Drawing.Size(474, 467);
            this.DGV_Sell.TabIndex = 16;
            this.DGV_Sell.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
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
            this.button_EDIT.Click += new System.EventHandler(this.button_EDIT_Click);
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
            this.button_ADD.Click += new System.EventHandler(this.button_ADD_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "PASSWORD";
            // 
            // txt_Sell_Phone
            // 
            this.txt_Sell_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Phone.Location = new System.Drawing.Point(98, 201);
            this.txt_Sell_Phone.Name = "txt_Sell_Phone";
            this.txt_Sell_Phone.Size = new System.Drawing.Size(179, 24);
            this.txt_Sell_Phone.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "PHONE";
            // 
            // txt_Sell_Age
            // 
            this.txt_Sell_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Age.Location = new System.Drawing.Point(98, 171);
            this.txt_Sell_Age.Name = "txt_Sell_Age";
            this.txt_Sell_Age.Size = new System.Drawing.Size(179, 24);
            this.txt_Sell_Age.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "AGE";
            // 
            // txt_Sell_Name
            // 
            this.txt_Sell_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_Name.Location = new System.Drawing.Point(98, 141);
            this.txt_Sell_Name.Name = "txt_Sell_Name";
            this.txt_Sell_Name.Size = new System.Drawing.Size(179, 24);
            this.txt_Sell_Name.TabIndex = 6;
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
            // txt_Sell_ID
            // 
            this.txt_Sell_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sell_ID.Location = new System.Drawing.Point(98, 111);
            this.txt_Sell_ID.Name = "txt_Sell_ID";
            this.txt_Sell_ID.Size = new System.Drawing.Size(179, 24);
            this.txt_Sell_ID.TabIndex = 4;
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
            this.button4.Text = "MANAGE SELLERS";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Control;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.YellowGreen;
            this.button3.Location = new System.Drawing.Point(12, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 36);
            this.button3.TabIndex = 6;
            this.button3.Text = "Categories";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.YellowGreen;
            this.button2.Location = new System.Drawing.Point(12, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "Selling";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(12, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Products";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // SellerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 608);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SellerForm";
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}