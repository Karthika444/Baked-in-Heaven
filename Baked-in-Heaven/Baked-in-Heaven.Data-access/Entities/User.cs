using System;
using System.Collections.Generic;
using System.Text;

namespace Baked_in_Heaven.Data_access.Entities
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public int PhoneNumber { get; set; }
        public bool IsAdmin { get; set; }
    }

}
