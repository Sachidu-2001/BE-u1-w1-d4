using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppW1D4.Models
{
    public class Account
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";




        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }



    }
}
