using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] carts = new int[52] { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            Console.WriteLine("insert n");
            int[] randommass = new int[30];
            Random rnd = new Random();
            int k = 0;
            int i = 0;
            int j = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] players = new int[n, 5];
            int[] player = new int[5];
            for (i = 0; i < n * 5; i++)
            {
                randommass[i] = rnd.Next(0, 51);
                k = 0;
                while (k < i)
                {
                    if (randommass[k] == randommass[i])
                    {
                        randommass[i] = rnd.Next(0, 51);
                        k = 0;
                    }
                    else k++;
                }
            }

            j = 0;
            k = 0;
            i = 0;
            while(i<n*5)
            {

                while(j<n)
                {
                    while (k < 5)
                    {
                        players[j, k] = carts[randommass[i]];
                        i++;
                        k++;
                    }

                        k = 0;
                        j++;
                }

            }
            i = 0;
            while (i < n)
                {
                for (j = 0; j < 5; j++)
                {
                    player[j] = players[i, j];
                }
                Array.Sort(player);
                Console.WriteLine("\nplayer" + (i+1));
                for(j = 0; j < 5; j++)
                {
                    if (player[j] == 11) Console.WriteLine("Валет ");
                        else if (player[j] == 12) Console.WriteLine("Дама ");
                            else if (player[j] == 13) Console.WriteLine("Король ");
                                else if (player[j] == 14) Console.WriteLine("Туз ");
                                    else Console.WriteLine(player[j] + " ");
                }
                i++;
                }
            Console.ReadLine();

                

        }
    }
}



