using System;
using System.Collections.Generic;
using System.Text;

namespace MobileApp.DemoPages.LoginSystem.Model
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
