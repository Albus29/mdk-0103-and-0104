﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desktop1and3lab
{
    public class Users
    {
        public string Login { get; set; }

        public string Password { get; set; }
        public Users(
            string login,
            string password)
        {
            Login = login;
            Password = password;
        }
    }
}
