using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lift
{
    class Program
    {
        static Queue<Level> listLevel = new Queue<Level>();
        Stack<Level> listLevel2 = new Stack<Level>();
        static int thisLevel = 0;

        static void Main(string[] args)
        {




            while (true)
            {
                Console.WriteLine("new level");
                Level newLevel = new Level() { level = Convert.ToInt32(Console.ReadLine()) };
                //listLevel.Enqueue(newLevel);
                addLevel(newLevel);
                Thread.Sleep(2000);
                //listLevel.Enqueue(new Level() { level = newlevel });


            }
        }

        static void addLevel(Level newlistLevel)
        {
            listLevel.Enqueue(newlistLevel);
            action();
        }

        static void action()
        {
            Level action = listLevel.Dequeue();
            //Console.WriteLine(action.level);
            if (action.level > thisLevel)
            {
                while(action.level > thisLevel)
                {
                    thisLevel++;
                    Console.WriteLine(thisLevel);
                    Thread.Sleep(1000);
                }
            }
            else
            {
                while (action.level < thisLevel)
                {
                    thisLevel++;
                    Console.WriteLine(thisLevel);
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
