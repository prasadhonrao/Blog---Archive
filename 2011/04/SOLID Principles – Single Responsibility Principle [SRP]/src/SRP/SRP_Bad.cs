namespace SRP_Bad
{
    using System;
    using System.Configuration;
    using System.Data;
    using System.Data.SqlClient;

    public class User
    {
        public Employee GetEmployeeDetail(string employeeId)
        {
            using (var connection = new SqlConnection(
                ConfigurationManager.ConnectionStrings["MyDb"].ConnectionString))
            
            using (var command = new SqlCommand())
            {
                command.CommandText = "SELECT EmployeeId,FirstName,LastName,BirthDate"
                                    + "FROM Employee where UserId = @employeeId";

                command.Parameters.Add("@employeeId", SqlDbType.Int).Value =
                                    int.Parse(employeeId);
                
                command.Connection = connection;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    return reader.Read() ? MapEmployeeToUser(reader) : null;
                }
            }
        }

        private Employee MapEmployeeToUser(IDataReader reader)
        {
            return new Employee
            {
                Id = Convert.ToInt32(reader["UserId"]),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                BirthDate = Convert.ToDateTime(reader["BirthDate"]),
            };
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
