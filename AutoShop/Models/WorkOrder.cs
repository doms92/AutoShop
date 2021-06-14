using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class WorkOrder
    {
        [Key]
        public int WorkOrderId { get; set; }

        public string WorkOrderName { get; set; }

        public string WorkOrderDescription { get; set; }

        public List<AutoPart>AutoParts { get; set; }

        
        

        

        
        
    }

    public class WorkOrders : WorkOrder
    {
        public string EmbedCode { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }


    }
}
