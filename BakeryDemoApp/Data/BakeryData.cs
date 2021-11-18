using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BakeryDemoApp.Data
{
    public class BakeryData : IBakeryData
    {
        private readonly ISqlDataAccess _Database;

        public BakeryData(ISqlDataAccess Database)
        {
            _Database = Database;
        }

        public Task<List<Bakery>> GetPeople()
        {
            string sql = "select * from dbo.Bakery";

            return _Database.LoadData<Bakery, dynamic>(sql, new { });
        }

        public Task InsertPerson(Bakery bakery)
        {
            throw new NotImplementedException();
        }
    }
}
