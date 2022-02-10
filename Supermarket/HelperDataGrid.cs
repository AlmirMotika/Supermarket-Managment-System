using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermarket
{
    public static class HelperDataGrid
    {
        private static readonly SqlConnection Con = new SqlConnection(Properties.Settings.Default.SqlConnectionString);    
        
        public static void Delete(string query)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted successfully");
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        
        
        public static DataSet Get(string query)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            Con.Close();

            return ds;
        }

        public static bool InsertOrEdit(string query)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();                
                Con.Close();
                return true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
    }
}
