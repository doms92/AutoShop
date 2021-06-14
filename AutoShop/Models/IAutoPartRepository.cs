using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoShop.Models
{
    public interface IAutoPartRepository
    {
        IEnumerable<AutoPart> GetAllAutoParts { get; }

        IEnumerable<AutoPart> GetAutoPartsOnSale { get; }

        AutoPart GetAutoPartsById(int autoPartsId);

    }
}
