using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkV3.Interfaces
{
    public interface ISaleDetail
    {
        int IdSale { get; set; }
        IProduct Product { get; set; }
        int Quantity { get; set; }
    }
}
