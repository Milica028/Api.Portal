using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.BusinessModels
{
    public class AuthenticationUserRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
