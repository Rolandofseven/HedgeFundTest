using HedgeFundApi2.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;

namespace HedgeFundApi2.Repositories
{
    public class PeopleRepository
    {
        public IEnumerable<Person> GetPeople() {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["PeopleContext"].ConnectionString;

            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Person>
                ("SELECT * FROM People").ToList();
            }
          
        }
    }
}