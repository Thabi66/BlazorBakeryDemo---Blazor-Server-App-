using BakeryDemoApp.Data;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryDemoApp
{
    public class SqlDataAccess : ISqlDataAccess
    {
        private readonly IConfiguration _config;

        //Instantiation of connection string
        public string DBCS { get; set; } = "Default";


        public SqlDataAccess(IConfiguration config)
        {
            _config = config;
        }

        //Gen: Creates a list of the data from the database
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
        {
            string connectionString = _config.GetConnectionString(DBCS);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                var data = await connection.QueryAsync<T>(sql, parameters);

                return data.ToList();
            }
        }

        public Task SaveData<T>(string sql, T parameters)
        {
            throw new System.NotImplementedException();
        }
    }
}