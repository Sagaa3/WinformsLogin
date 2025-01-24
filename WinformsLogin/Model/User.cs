using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsLogin.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }

        public string Password { get; set; }

        public User() { }
        public User(string name, string pass)
        {
            Name = name;
            Password = pass;
        }
    }
}
