using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class AutoPartsRepository : IAutoPartRepository
    {
        private readonly IWorkOrderRepository workOrderRepository = new IWorkOrderRepository();
        public IEnumerable<AutoPart> GetAllAutoParts => new List<AutoPart>
        {
            new AutoPart {AutoPartsId = 1, Name="Mozzy", Price = 76M, Description="GT, 2018"}
        };

        public IEnumerable<AutoPart> GetAutoPartsOnSale => throw new NotImplementedException();

        public AutoPart GetAutoPartsById(int autoPartsId)
        {
            throw new NotImplementedException();
        }
    }
}
