using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Invetory_Management_System
{
    class CategoriesData
    {
        public int ID { set; get; }
        public string Category { set; get; }
        public string Date { set; get; }
        public List<CategoriesData> AllCatagoriesData()
        {
            List<CategoriesData> listData = new List<CategoriesData>();
            using (SqlConnection connect = new SqlConnection(@"Data Source=LAPTOP-A305DT04;Initial Catalog=ABCD;Integrated Security=True;Encrypt=False"))
            {
                connect.Open();

                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoriesData cData = new CategoriesData();
                        cData.ID = (int)reader["id"];
                        cData.Category = reader["category"].ToString();
                        cData.Date = reader["date"].ToString();
                       
                        listData.Add(cData);
                    }
                }
            }
            return listData;
        }
    }
}
