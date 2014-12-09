using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BoothCampStudentCourseApp.DAL.DAO;

namespace BoothCampStudentCourseApp.DAL.Gateway
{
    class CourseGateway
    {

        private SqlConnection connection;

        public CourseGateway()
        {
            connection  = new SqlConnection();
            string conn = @"server= BITM-401-PC28\SQLEXPRESS ;database= StudentCourse ;integrated security=true";
            connection.ConnectionString = conn;
            connection.Open();
        }
        

       public bool HasThisRegNo(string RegNo)
        {
            SqlConnection connection = new SqlConnection();
            string conn = @"server=BITM-401-PC03\SQLEXPRESS; database=SuperShop; integrated security=true";
            connection.ConnectionString = conn;
            connection.Open();

            string query = String.Format("SELECT * FROM t_Student WHERE RegNo='{1}'", RegNo);
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            bool hasRows = aReader.HasRows;
            connection.Close();
            return hasRows;
        }



    }
}
