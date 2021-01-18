using Baked_in_Heaven.Data_access.Entities;
using Baked_in_Heaven.Data_access.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BakedInHeaven.BussinessService
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;
        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            users = _userRepository.GetAllUsers();
            return users.ToList();

        }
    }
}
