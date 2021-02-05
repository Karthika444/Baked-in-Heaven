using Baked_in_Heaven.Data_access.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedInHeaven.BussinessService
{
    public interface IUserService
    {
        List<User> GetUsers();
        void AddUser(User newUser);
    }
}
