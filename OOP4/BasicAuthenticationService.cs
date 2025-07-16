using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    public class BasicAuthenticationService : IAuthenticationService
    {
        private Dictionary<string, (string Password, string Role)> users;
        public BasicAuthenticationService()
        {
            users = new Dictionary<string, (string Password, string Role)>
        {
            { "Ahmed", ("123", "Admin") },
            { "Amr", ("abc", "User") }
        };
        }
        public bool AuthenticateUser(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                return users[username].Password == password;
            }
            return false;
        }

        public bool AuthorizeUser(string username, string role)
        {
            if (users.ContainsKey(username))
            {
                return users[username].Role == role;
            }
            return false;
        }

    }
}
