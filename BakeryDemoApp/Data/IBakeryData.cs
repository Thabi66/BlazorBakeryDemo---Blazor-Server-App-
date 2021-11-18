using System.Collections.Generic;
using System.Threading.Tasks;

namespace BakeryDemoApp.Data
{
    public interface IBakeryData
    {
        Task<List<Bakery>> GetPeople();
        Task InsertPerson(Bakery bakery);

    }
}