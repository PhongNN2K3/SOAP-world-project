using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WorldSearch
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        private readonly string connectionString = "Data Source=LAPTOP-59U1A9H7\\SQLEXPRESS;Initial Catalog=world;Integrated Security=True";

        [WebMethod]
        public List<string> GetAllCountries()
        {
            List<string> countries = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM country", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    countries.Add(reader["Name"].ToString());
                }
            }
            return countries;
        }
        [WebMethod]
        public string GetCountryByCode(string countryCode)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM country WHERE Code = @Code", conn);
                cmd.Parameters.AddWithValue("@Code", countryCode);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "Country not found";
            }
        }

        [WebMethod]
        public string GetCityByName(string cityName)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM city WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", cityName);
                object result = cmd.ExecuteScalar();
                return result != null ? result.ToString() : "City not found";
            }
        }

        [WebMethod]
        public List<string> GetCitiesByCountry(string countryCode)
        {
            List<string> cities = new List<string>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM city WHERE CountryCode = @CountryCode", conn);
                cmd.Parameters.AddWithValue("@CountryCode", countryCode);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cities.Add(reader["Name"].ToString());
                }
            }
            return cities;
        }
    }
}
