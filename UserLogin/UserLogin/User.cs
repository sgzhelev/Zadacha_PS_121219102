using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FakNum { get; set; }
        public UserRoles Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ActiveUntil { get; set; }
    }
}
