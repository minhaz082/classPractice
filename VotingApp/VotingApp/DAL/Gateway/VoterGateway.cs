using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace VotingApp.DAL.Gateway
{
    class VoterGateway:Gateway
    {       
        
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

        internal void CastVote(VoteCast aVoteCast)
        {
            connection.Open();
            string query = string.Format("INSERT INTO t_VoteCast VALUES(@candidateId,@voterID)");
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add(new SqlParameter("@candidateId", aVoteCast.CandidateID));
            command.Parameters.Add(new SqlParameter("@voterID", aVoteCast.VoterID));
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
