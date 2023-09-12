using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emplyee_management_System_Portal
{
    internal class DataFunctions
    {
        private SqlConnection Con;
        private SqlCommand Cmd;
        private DataTable dt;
        private SqlDataAdapter Sda;
        private string ConnectionString;

        public DataFunctions()
        {
            ConnectionString = @"Data Source=NTS-SHILPAKALE;Initial Catalog=Employee_Portal;Integrated Security=True";
            Con = new SqlConnection(ConnectionString);
            Cmd = new SqlCommand();
            Cmd.Connection = Con;
        }
        public DataTable GetData(string Query)
        {
            dt = new DataTable();
            Sda = new SqlDataAdapter(Query, ConnectionString);
            Sda.Fill(dt);
            return dt;

        }
        public int SetData(string Query)
        {
            int count =0;
            if (Con.State==ConnectionState.Closed)
            {

                Con.Open();
            }
            Cmd.CommandText = Query;
            count = Cmd.ExecuteNonQuery();
            return count;   
        }
    }
}
