using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitOfWorkV3.Interfaces
{
    public interface ISale : IEntity
    {
        DateTime Date { get; set; }
        IList<ISaleDetail> Details { get; set; }
    }
}
