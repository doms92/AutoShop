using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class WorkOrderRepository : IWorkOrderRepository
    {
        public IEnumerable<WorkOrder> GetAllWorkOrders => new List<WorkOrder>
        {
            new WorkOrder{WorkOrderId=1, WorkOrderName="", WorkOrderDescription=""}

        };
    }
}
