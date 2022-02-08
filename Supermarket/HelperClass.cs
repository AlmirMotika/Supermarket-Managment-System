using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Supermarket
{
    public class HelperClass
    {
        private static readonly SqlConnection Con = new SqlConnection(Properties.Settings.Default.SqlConnectionString);    
        public void Delete(string query)
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
        public DataTable FillCombo(string query, string ColumnName)
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add(ColumnName, typeof(string));
            dt.Load(rdr);
            Con.Close();

            return dt;

        }
        public DataSet Get(string query)
        {
            Con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            Con.Close();

            return ds;
        }
        public bool InsertOrEdit(string query)
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
