using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class AutoParts
    {
        public int AutoPartsId { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public string ImageThumbnailUrl { get; set; }

        public bool IsOnSale { get; set; }

        public bool IsInStock { get; set; }

        public int CategoryId { get; set; }

        public WorkOrders WorkOrders { get; set; }
    }
}
