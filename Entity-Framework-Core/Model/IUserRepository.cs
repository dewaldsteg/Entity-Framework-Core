using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entity_Framework_Core.Model
{
    interface IUserRepository
    {
        User GetUser(int id);
        IEnumerable<User> GetAllUsers();
        User AddUser(User user);
        User UpdateUser(User userChanges);
        User Delete(int id);
    }
}
