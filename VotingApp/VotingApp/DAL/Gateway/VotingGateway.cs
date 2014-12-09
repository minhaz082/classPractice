using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace VotingApp.DAL.Gateway
{
    class VotingGateway
    {
        private SqlConnection connection;

        public VotingGateway()
        {
            string conn = ConfigurationManager.ConnectionStrings["VotingDB"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;
        }

        public void SaveCandisate(Candidate aCandidate)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_Candidate VALUES(@name,@symbol)");
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.Add(new SqlParameter("@name", aCandidate.Name));
            command.Parameters.Add(new SqlParameter("@symbol",aCandidate.Symbol));
            command.ExecuteNonQuery();
            connection.Close();
        }

        public bool HasThisSymbol(string symbol)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Candidate WHERE Symbol=@symbol");
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@symbol", symbol));
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public bool HasThisEmail(string email)
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Voter WHERE Email=@email");
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@email", email));
            SqlDataReader aReader = command.ExecuteReader();
            bool Hasrow = aReader.HasRows;
            connection.Close();
            return Hasrow;
        }

        public List<Candidate> GetAllShop()
        {
            connection.Open();
            string query = string.Format("SELECT * FROM t_Candidate");
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Candidate> symbols = new List<Candidate>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Candidate aCandidate = new Candidate();
                    aCandidate.Name = aReader[1].ToString();
                    aCandidate.Symbol = aReader[2].ToString();

                    symbols.Add(aCandidate);
                }
            }
            connection.Close();
            return symbols;
        }
    }
}
