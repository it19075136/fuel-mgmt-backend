using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fuel_mgmt_backend.models
{
    public interface IUserService
    {
        List<User> Get();
        User Get(string id);
        User GetByEmail(string email);
        User Create(User user);
        void Update(string id, User user);
        void Delete(string id);
    }
}
