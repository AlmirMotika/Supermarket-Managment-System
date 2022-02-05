using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Supermarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Username_tbl.Text = "";
            Password_tbl.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Username_tbl.Text=="" || Password_tbl.Text == "")
            {
                MessageBox.Show("Enter the Username and Password");
            }
            else
            {
                if (combo_role.SelectedIndex > -1)
                {
                    if (combo_role.SelectedItem.ToString() == "ADMIN")
                    {
                        if(Username_tbl.Text=="Admin" && Password_tbl.Text == "Admin")
                        {
                            ProductForm prod = new ProductForm();
                            prod.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("If You are the Admin,Enter the correct Id and Password");
                        }
                    }                  
                    else
                    {
                        MessageBox.Show("Select a role");
                    }

                }
                else
                {
                    MessageBox.Show("Select a role");
                }
            }
        }
    }
}
