using Baked_in_Heaven.Data_access.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Baked_in_Heaven.Data_access.Repositories
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();
        void Add(User userEntity);


    }
}
