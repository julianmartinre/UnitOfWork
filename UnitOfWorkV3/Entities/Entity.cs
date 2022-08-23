using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkV3.Interfaces;

namespace UnitOfWorkV3.Entities
{
    public class Entity : IEntity
    {
        public int Id { get; set; }
    }
}
