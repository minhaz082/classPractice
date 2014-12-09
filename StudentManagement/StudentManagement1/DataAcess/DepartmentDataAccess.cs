using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement1.DataAcess
{
  public  class DepartmentDataAccess
    {
      public List<Department> GetAll()
      {

          SqlConnectin connection = Connection.GetConnection();
          connection.Open();
          string query = "select * from Department";

          SqlCommand command=new SqlCommand(query,connectuon);
          connection.Close();
          return null;
      }
    }
}
