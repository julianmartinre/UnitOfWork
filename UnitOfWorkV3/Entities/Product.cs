using UnitOfWorkV3.Interfaces;

namespace UnitOfWorkV3.Entities
{
    public class Product : Entity, IProduct
    {
        public string Name { get; set; }
    }
}
