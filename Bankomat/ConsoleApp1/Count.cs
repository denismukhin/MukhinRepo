using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Count
    {
        private int money;
        private string name;
        private int limit;
        private bool isBlocked;

        public String getName()
        { return name; }

        public bool getBlocked()
        {
            return isBlocked;
        }

        public bool setBlocked(bool block)
        { this.isBlocked = block;
            return this.isBlocked;
        }

        public int getMoney()
        { return money; }

        public bool setMoney(int sum)
        {
            bool Success = true;
            if (this.money + sum >= this.limit)
            {
                this.money = this.money + sum;
            }
            else
            {
                Console.WriteLine("Недостаточно средств");
                Success = false;
            }
            return Success;
        }

        protected Count(string name, int limit, bool isBlocked)
        {
            this.name = name;
            this.isBlocked = isBlocked;
            this.money = 0;
            this.limit = limit;
        }
     
    }


}