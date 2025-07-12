using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Invetory_Management_System
{
    class UsersData
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }

        public List<UsersData> AlluserData()
        {
            List<UsersData> listData = new List<UsersData>();
            using (SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False"))
            {
                connect.Open();

                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UsersData uData = new UsersData();
                        uData.ID = (int)reader["id"];
                        uData.Username = reader["username"].ToString();
                        uData.Password = reader["password"].ToString();
                        uData.Role = reader["role"].ToString();
                        uData.Status = reader["status"].ToString();
                        uData.Date = Convert.ToDateTime(reader["date"]);  

                        listData.Add(uData);
                    }
                }
            }
            return listData;
        }
    }
}
