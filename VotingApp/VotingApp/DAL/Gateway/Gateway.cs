using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace VotingApp.DAL.Gateway
{
    class Gateway
    {
        public SqlConnection connection;

        public Gateway()
        {
            string conn = ConfigurationManager.ConnectionStrings["VotingDB"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;
        }
    }
}
