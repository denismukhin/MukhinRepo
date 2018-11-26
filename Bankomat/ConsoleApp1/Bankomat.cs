using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bankomat
    {
        List<Count> counts = new List<Count>();

        public void addCount(Count count)
        {
            counts.Add(count);
        }

        public Count getCountByName(String countName)
        {
            foreach (Count count in counts)
            {
                if (count.getName().Equals(countName))
                {
                    return count;
                }
            }

            return null;
        }

        public void returnAllNames()
        {
            foreach (Count count in counts)
            {
                Console.WriteLine(count.getName());
            }
        }

        public void printCountFor(String CountName)
        {
            foreach (Count count in counts)
                if (!count.getName().Equals(CountName))
                {
                    Console.WriteLine(count.getName());
                }
        }

        public string  returnCountFor(String CountName, int position)
        {
            int i = 0;
            String [] name = { "", "" };
            foreach (Count count in counts)
                if (!count.getName().Equals(CountName))
                {
                    name[i] = count.getName();
                    i++;
                }
            return name[position-1];
        }
    }
}
