using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public interface IAutoPartRepository
    {
        IEnumerable<AutoParts> GetAllAutoParts { get; }

        IEnumerable<AutoParts> GetAutoPartsOnSale { get; }

        AutoParts GetAutoPartsById(int autoPartsId);

    }
}
