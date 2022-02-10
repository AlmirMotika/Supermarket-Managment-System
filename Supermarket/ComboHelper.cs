using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    public static class  ComboHelper
    {
        private static readonly SqlConnection Con = new SqlConnection(Properties.Settings.Default.SqlConnectionString);

        public static DataTable FillCombo(string query, string ColumnName)
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
    }
}
