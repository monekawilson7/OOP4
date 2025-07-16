using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    public interface IAuthenticationService
    {
        bool AuthenticateUser(String username, string password);
        bool AuthorizeUser(String username, string role);
    }
}
