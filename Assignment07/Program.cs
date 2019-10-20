using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07
{
    class Program
    {
        static void Main(string[] args)
        {
            var acc = new Account(1);
            acc.Deposite(20);
            acc.Withdrawl(100); // Invalid
        }
    }
}
