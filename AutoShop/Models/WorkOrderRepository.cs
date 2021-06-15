using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    
    public class WorkOrderRepository : IWorkOrderRepository
    {
        private readonly AppDbContext _appDbContext;

        public WorkOrderRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        IEnumerable<WorkOrder> GetAllWorkOrders => _appDbContext.workOrders;
   
    }
}
