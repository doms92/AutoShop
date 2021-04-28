using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public abstract class WorkOrders
    {
        [Key]
        public int WorkOrderId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        
    }
}
