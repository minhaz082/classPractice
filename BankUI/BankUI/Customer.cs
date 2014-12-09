using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankUI
{
    class Customer
    {
        public string Name { set; get; }
        public string Email { set; get; }
        public Account AnAccount { set; get; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }
    }
}
