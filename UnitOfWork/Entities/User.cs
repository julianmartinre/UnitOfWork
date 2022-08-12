using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Interfaces;

namespace UnitOfWork.Entities
{
    public class User : IEntity
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
