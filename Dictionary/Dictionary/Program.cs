using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FIOList> list = new List<FIOList>();
            FIOList fIOList1 = new FIOList("Ivanov", new List<int>{3234, 23423,23423});
            FIOList fIOList2 = new FIOList("Ivanov2", new List<int> { 3234435, 23456723, 2343423 });
            FIOList fIOList3 = new FIOList("Petrov", new List<int> { 367234, 23456723, 237623 });
            FIOList fIOList4 = new FIOList("Sidorov", new List<int> { 323364, 23355423, 2336423 });

            list.Add(fIOList1);
            list.Add(fIOList2);
            list.Add(fIOList3);
            list.Add(fIOList4);

            Dictionary<string, FIOList> first = new Dictionary<string, FIOList>();

            Dictionary<char, Dictionary<string, FIOList>> second= new Dictionary<char, Dictionary< string, FIOList >>();

            foreach(FIOList fIOList in list)
            {
                if(!first.ContainsKey(fIOList.getFIO()))
                {
                    first.Add(fIOList.getFIO(), fIOList);
                }
            }

            foreach(FIOList fIOList in list)
            {


                if (!second.ContainsKey(fIOList.getFIO().ToCharArray()[0]))
                {
                    Dictionary<string, FIOList> temp = new Dictionary<string, FIOList>();
                    temp.Add(fIOList.getFIO(), fIOList);
                    second.Add(fIOList.getFIO().ToCharArray()[0], temp);
                }
                else
                {
                    second[fIOList.getFIO().ToCharArray()[0]].Add(fIOList.getFIO(), fIOList);
                }
            }

            Console.WriteLine("for surname");
            first["Ivanov"].print();
            Console.WriteLine("-------------");
            Console.WriteLine("for symbol");
            Dictionary<string, FIOList> temp1 = second['I'];
            foreach (KeyValuePair<string, FIOList> kvp in temp1)
            {
                temp1[kvp.Key].print();
            }
            Console.WriteLine("---------------");
            Console.WriteLine("for nubmer");
            int m = 323364;
            foreach (KeyValuePair<string, FIOList> kvp in first)
            {
                foreach(int number in kvp.Value.returnList())
                if (kvp.Value.returnList().Contains(m))
                    {
                        first[kvp.Key].print();
                        break;
                    }
            }
            

            Console.ReadKey();

        }


    }

}
