using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class User
    {
        private string email;
        private string Password;

        public string Email { get { return email; } }
        public User(string email, string password)
        {
            this.email = email;
            this.Password = password;
        }

    }
}
