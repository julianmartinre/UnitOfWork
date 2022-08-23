using UnitOfWorkV3.Interfaces;

namespace UnitOfWorkV3.Entities
{
    public class Sale : Entity, ISale
    {
        public DateTime Date { get; set; }
        public IList<ISaleDetail> Details { get; set; }

        public Sale() => Details = new List<ISaleDetail>();
    }
}
