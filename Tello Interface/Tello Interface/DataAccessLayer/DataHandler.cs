using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tello_Interface.DataAccessLayer
{
    internal class DataHandler
    {
        public DataHandler() { }

        string conn = ("Data Source = b88d0a3a0ea7.sn.mynetname.net; Initial Catalog = PRJ381; User Id = SA; Password = Uwuntu42@;");

        //Add new user
        public void NewClient(string Username, int UserRole, string UserPassword)
        {
            using (SqlConnection connection = new SqlConnection(conn))
            {
                SqlCommand cmd = new SqlCommand("spNewUser", connection);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Username", Username);
                cmd.Parameters.AddWithValue("@Role", UserRole);
                cmd.Parameters.AddWithValue("@UserPassword", UserPassword);

                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

    }
}
