using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkV3.Interfaces
{
    public interface ISaleDetailRepository : ICreate<ISaleDetail>
    {
        IList<ISaleDetail> GetAllByIdSale(int id);
    }
}
