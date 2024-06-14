using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEndRu.src.Models;

namespace BackEndRu.src.Infrastruct
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
    }
}