using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Debit : Count
    {
        public Debit(String name, int limit, bool isBlocked) : base(name, limit, isBlocked)
        {

        }
    }
}
