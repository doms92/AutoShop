using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class IWorkOrderRepository
    {
        IEnumerable<WorkOrder> GetAllWorkOrders { get; }
    }
}
