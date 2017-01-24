using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Server.API.Entities;

namespace Server.API.Controllers
{
    public class UserProfilesController : ApiController
    {
        [HttpGet]
        [ActionName("GetProfileByID")]
        public Profile Get(int id)
        {
            SqlDataReader reader = null;
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = ConfigurationManager.ConnectionStrings["AccountDB"].ConnectionString;

            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM user_profiles WHERE user_id=" + id;
            command.Connection = connection;
            connection.Open();
            reader = command.ExecuteReader();

            Profile result = null;
            while (reader.Read())
            {
                result = new Profile
                {
                    ProfileID = Convert.ToInt32(reader.GetValue(0)),
                    FirstName = reader.GetValue(1).ToString(),
                    LastName = reader.GetValue(2).ToString(),
                    Password = reader.GetValue(3).ToString(),
                    Status = Convert.ToInt32(reader.GetValue(4)),
                    UserLevelID = Convert.ToInt32(reader.GetValue(5)),
                    LastLogin = Convert.ToDateTime(reader.GetValue(6)),
                    LastUpdate = Convert.ToDateTime(reader.GetValue(7)),
                    Email = reader.GetValue(8).ToString()
                };
            }

            connection.Close();
            return result;
        }
    }
}
