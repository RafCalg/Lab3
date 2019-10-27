using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Lab3.Models
{
    public static class ProductDB
    {
        public static List<Product> GetProductByID(string catID)
        {
            List<Product> products = new List<Product>();
            string sql = "SELECT * "
                + " FROM Products WHERE CategoryID = @CategoryID";
            using (SqlConnection con = new SqlConnection(GetConnectionString()))
            {
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@CategoryID", catID);
                    con.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Product prod;
                    while (dr.Read())
                    {
                        prod = new Product();
                        prod.ProductID = dr["ProductID"].ToString();
                        prod.Name = dr["Name"].ToString();
                        prod.CategoryID = dr["CategoryID"].ToString();
                        products.Add(prod);
                    }
                    dr.Close();
                }
            }
            return products;
        }
        private static string GetConnectionString()
        {
            return @"Data Source=localhost\sqlexpress;Initial Catalog=Halloween;Integrated Security=True";
        }
    }


    
}