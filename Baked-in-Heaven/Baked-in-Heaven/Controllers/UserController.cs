using Baked_in_Heaven.Data_access.Entities;
using BakedInHeaven.BussinessService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Baked_in_Heaven.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;

        }
        [HttpGet]
        public List<User> GetAllItems()
        {

            return _userService.GetUsers();
        }

        [HttpPost]
        public void AddUser(User newUser)
        {
            _userService.AddUser(newUser);
        }


    }
}
