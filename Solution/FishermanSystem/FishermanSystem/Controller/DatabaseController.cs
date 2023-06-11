using FishermanSystem.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Design;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Runtime.Remoting.Contexts;

namespace FishermanSystem.Controller
{
    internal class DatabaseController
    {
        static string connectionString = ConfigurationManager.ConnectionStrings["FishermanSystemDBEntities"].ConnectionString;

        public DataSet CustomQuery(string command)
        {
            if (connectionString.ToLower().StartsWith("metadata="))
            {
                System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder efBuilder = new System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder(connectionString);
                connectionString = efBuilder.ProviderConnectionString;
            }
            SqlConnection c = new SqlConnection(connectionString);
            var dataAdapter = new SqlDataAdapter(command, c);
            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            c.Open();
            dataAdapter.Fill(ds);
            c.Close();
            return ds;
        }
    }
}
