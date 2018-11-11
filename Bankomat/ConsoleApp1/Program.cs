using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {



        static void Main(string[] args)
        {
            Credit credit = new Credit("Credit", -1000000, false);
            Debit debit = new Debit("Debit", 0, false);
            Current current = new Current("Current", 0, false);
            Bankomat bankomat = new Bankomat();
            bankomat.addCount(credit);
            bankomat.addCount(debit);
            bankomat.addCount(current);
            mainMenu();

            void mainMenu()
            {
                bankomat.getCountByName("Debit").setBlocked(bankomat.getCountByName("Credit").getMoney() <= -20000 ? true : false);
                while (true)
                {
                    Console.WriteLine("Выберите счет");
                    bankomat.returnAllNames();
                    var cmd = Console.ReadLine();
                    String CurrentName;
                    switch (cmd)
                    {
                        case "1":
                            CurrentName = "Credit";
                            OperationMenu(CurrentName);
                            break;
                        case "2":
                            CurrentName = "Debit";
                            if (bankomat.getCountByName(CurrentName).getBlocked())
                            {
                                Console.WriteLine("Sorry, it's block");
                                break; }
                            else OperationMenu(CurrentName);
                            break;
                        case "3":
                            CurrentName = "Current";
                            OperationMenu(CurrentName);
                            break;
                    }
                }
            }



            void OperationMenu(String name)
            {
                Console.WriteLine("\n 1. Add to count");
                Console.WriteLine("\n 2. Get from count");
                Console.WriteLine("\n 3. Count to count");
                Console.WriteLine("\n 4. How much money");
                Console.WriteLine("\n 5. Main menu");
                var cmd = Console.ReadLine();
                bankomat.getCountByName("Debit").setBlocked(bankomat.getCountByName("Credit").getMoney() <= -20000 ? true : false);
                while (true)
                {
                    switch (cmd)
                    {
                        case "1":
                            Console.WriteLine("Insert sum to add");
                            int sum = Convert.ToInt32(Console.ReadLine());
                            bankomat.getCountByName(name).setMoney(sum);
                            if(sum>=1000000 && name == "Current")
                            {
                                bankomat.getCountByName("Debit").setMoney(2000);
                            }
                            OperationMenu(name);
                            break;
                        case "2":
                            Console.WriteLine("Insert sum to get");
                            sum = Convert.ToInt32(Console.ReadLine());
                            while(sum>=30000)
                            {
                                Console.WriteLine("too much");
                                Console.WriteLine("\nCorrect sum");
                                sum = Convert.ToInt32(Console.ReadLine());
                            }
                            sum = -sum;
                            bankomat.getCountByName(name).setMoney(sum);
                            OperationMenu(name);
                            break;

                        case "3":
                            bankomat.getCountByName("Current");
                            menuTransfer(name);
                            break;
                        case "4":
                            Console.WriteLine(bankomat.getCountByName(name).getMoney());
                            OperationMenu(name);
                            break;
                        case "5":
                            mainMenu();
                            return;
                    }
                }
            }

            void menuTransfer(String name)
            {
                Console.WriteLine("Выберите счет для перевода");
                bankomat.printCountFor(name);
                var cmd = Console.ReadLine();
                bankomat.getCountByName("Debit").setBlocked(bankomat.getCountByName("Credit").getMoney() <= -20000 ? true : false);
                while (true)
                {
                    switch(cmd)
                    {
                        case "1":
                            string t = bankomat.returnCountFor(name, 1);
                            if (bankomat.getCountByName(bankomat.returnCountFor(name, 1)).getBlocked())
                            {
                                Console.WriteLine("Sorry, it's block");
                                menuTransfer(name);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Insert sum");
                                int sum = Convert.ToInt32(Console.ReadLine());
                                sum = -sum;
                               // bankomat.getCountByName(name).setMoney(sum);
                                if(bankomat.getCountByName(name).setMoney(sum))
                                {
                                    sum = -sum;
                                    bankomat.getCountByName(bankomat.returnCountFor(name, 1)).setMoney(sum);
                                }
                            }
                            OperationMenu(name);
                            break;
                        case "2":
                            if (bankomat.getCountByName(bankomat.returnCountFor(name, 2)).getBlocked())
                            {
                                Console.WriteLine("Sorry, it's block");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Insert sum");
                                int sum = Convert.ToInt32(Console.ReadLine());
                                sum = -sum;
                                // bankomat.getCountByName(name).setMoney(sum);
                                if (bankomat.getCountByName(name).setMoney(sum))
                                {
                                    sum = -sum;
                                    bankomat.getCountByName(bankomat.returnCountFor(name, 2)).setMoney(sum);
                                }
                            }
                            OperationMenu(name);
                            break;

                        case "3":
                            {
                                OperationMenu(name);
                                break;
                            }
                    }
                }
            }


        }



        

        

    }
}
