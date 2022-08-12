using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Entities;

namespace UnitOfWork
{
    public class UserApplication : Application<User>
    {
        public UserApplication() : base(new UserRepository())
        {

        }
    }
}
