using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class WorkOrderRepository
    {
        IEnumerable<WorkOrder> GetAllWorkOrders { get; }
    }
}
