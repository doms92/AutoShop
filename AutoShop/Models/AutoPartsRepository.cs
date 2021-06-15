using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public class AutoPartsRepository : IAutoPartRepository
    {
        private readonly AppDbContext _appDbContext;

        public AutoPartsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<AutoPart> GetAllAutoParts 
        {
            get
            {
                return _appDbContext.AutoParts.Include(c => c.WorkOrders);
            }
                
            
        }

        public IEnumerable<AutoPart> GetAutoPartsOnSale
        {
            get
            {
                return _appDbContext.AutoParts.Include(c => c.WorkOrders).Where(p => p.IsOnSale);
            }

        }


        public AutoPart GetAutoPartsById(int autoPartsId)
        {
            
            {
                return _appDbContext.AutoParts.FirstOrDefault(c => c.AutoPartsId == autoPartsId); ;
            }

        }
    }
}
