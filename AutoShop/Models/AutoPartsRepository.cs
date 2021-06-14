using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class AutoPartsRepository : IAutoPartRepository
    {
        private readonly IWorkOrderRepository workOrderRepository = new IWorkOrderRepository();
        public IEnumerable<AutoParts> GetAllAutoParts => new List<AutoParts>
        {
            new AutoParts {AutoPartsId = 1, Name="Mozzy", Price = 76M, Description="GT, 2018"}
        };

        public IEnumerable<AutoParts> GetAutoPartsOnSale => throw new NotImplementedException();

        public AutoParts GetAutoPartsById(int autoPartsId)
        {
            throw new NotImplementedException();
        }
    }
}
