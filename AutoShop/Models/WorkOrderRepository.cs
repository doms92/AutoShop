using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class WorkOrderRepositoryb : IWorkOrderRepository
    {
        public IEnumerable<WorkOrders> GetAllWorkOrders => new List<WorkOrders>
        {
            new WorkOrder{WorkOrderId=1, Title="", Description = ""}

        };
    }
}
