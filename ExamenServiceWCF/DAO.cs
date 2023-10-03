using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenServiceWCF
{
    internal class DAO
    {
        public static void insertProjet(string code, string description)
        {
            string query = "INSERT INTO projet (code, description) " +
            "VALUES (@code, @description)";

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbGestion;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@code", code);
                    command.Parameters.AddWithValue("@description", description);

                    command.ExecuteNonQuery();
                }
            }
        }

        /*
        public static string selectProjet(string code)
        {
            string query = "SELECT description FROM projet WHERE code = @code";
            string result = "";

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbGestion;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@code", code);

                    object value = command.ExecuteScalar();

                    if (value != null)
                    {
                        result = value.ToString();
                    }
                }

                return result;   
            }
        }*/

        public static string selectProjet(string code)
        {
            string query = "SELECT code, description FROM projet WHERE code = @code";
            string result = "";

            using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=dbGestion;Integrated Security=True"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@code", code);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            result += reader["code"].ToString();
                            result += ", ";
                            result += reader["description"].ToString();
                        }
                    }
                }

                return result;
            }
        }



    }
}
