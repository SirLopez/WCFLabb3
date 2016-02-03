using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace AssignmentFive
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        public Employee GetEmployeeByID(int id)
        {
            var employee = new Employee();
            var connectionString = ConfigurationManager.ConnectionStrings["NORTHWND"].ConnectionString;
            using (var conn = new SqlConnection(connectionString))
            {
                conn.Open();

                var employeeCommand = new SqlCommand("SELECT [EmployeeID], [LastName], [FirstName], [Title], [Address], [City] FROM Employees WHERE EmployeeID = @id", conn);
                employeeCommand.Parameters.AddWithValue("@id", id);

                using (var reader = employeeCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        employee.EmployeeID = (int)reader["EmployeeID"];
                        employee.LastName = reader["LastName"].ToString();
                        employee.FirstName = reader["FirstName"].ToString();
                        employee.Title = reader["Title"].ToString();
                        employee.Address = reader["Address"].ToString();
                        employee.City = reader["City"].ToString();
                        
                    }
                }
                conn.Close();
            }
            return employee;
        }

        public void SaveEmployee(int id, string lastname, string firstname, string title, string address, string city)
        {
            throw new NotImplementedException();
        }
    }
}
