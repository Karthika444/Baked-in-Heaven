using Baked_in_Heaven.Data_access.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baked_in_Heaven.Data_access.Repositories
{
    public class UserRepository : IUserRepository 
    {
        private readonly applicationdbcontext _dbContext;
        public UserRepository(applicationdbcontext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<User> GetAllUsers()
        {
            return _dbContext.Users.ToList();
        }
        public void Add(User userEntity)
        {
            _dbContext.Users.Add(userEntity);
            _dbContext.SaveChanges();
        }


       
    }

}

