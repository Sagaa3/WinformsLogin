using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformsLogin.Model
{
    public class Password
    {
        public int PasswordId {  get; set; }
        public string Pass { get; set; }

        public User User { get; set; }
    }
}
