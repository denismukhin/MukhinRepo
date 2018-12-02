using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {

            Arraylist arraylist = new Arraylist();
            arraylist.addElement(5);
            arraylist.addElement(7);
            arraylist.addElement(7);
            arraylist.addElement(8);
            arraylist.addElement(30);

            arraylist.printElements();
            Console.WriteLine("------------");
            Console.WriteLine("Index of 7");
            arraylist.indexOf(7);
            Console.WriteLine("------------");
            Console.WriteLine("Index of 30");
            arraylist.indexOf(30);
            Console.WriteLine("------------");
            Console.WriteLine("Remove 7");
            arraylist.removeElement(7);
            arraylist.printElements();
            Console.WriteLine("------------");
            Console.WriteLine("Remove index [2]");
            arraylist.removeIndex(2);
            arraylist.printElements();
            Console.WriteLine("------------");
            Console.WriteLine("Get elemnt [0]");
            arraylist.GetElement(0);
            Console.WriteLine("------------");
            Console.WriteLine("Get index of 8");
            arraylist.GetIndex(8);
            Console.ReadKey();

        }
    }
}
