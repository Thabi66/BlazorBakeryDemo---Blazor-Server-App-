using System.Collections.Generic;
using System.Threading.Tasks;

namespace BakeryDemoApp.Data
{
    internal interface ISqlDataAccess
    {
        //Database connection string
        string DBCS { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U parameters);
        Task SaveData<T>(string sql, T parameters);
    }
}