using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class FIOList
    {
        string fio;
        List<int> numbers = new List<int>();

        public FIOList(string fio, List<int> numbers)
        {
            this.fio = fio;
            this.numbers = numbers;
        }

        public string getFIO()
        {
            return fio;
        }
        public void print()
        {
            Console.WriteLine(fio);
            foreach (int number in numbers)
            {
                Console.WriteLine(number + " ");
            }


        }

        public List<int> returnList()
        {
            return numbers;
        }
    }
}
