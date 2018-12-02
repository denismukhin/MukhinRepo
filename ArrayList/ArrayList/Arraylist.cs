using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Arraylist
    {
        int[] massiv;
        int i = 0;

        public Arraylist()
        {

        }

        public void addElement(int element)
        {
            i++;
            int[] temp = new int[i];
            for(int j=0;j<i-1;j++)
            {
                temp[j] = massiv[j];
            }
            temp[i - 1] = element;
            massiv = temp;

        }

        public void removeElement(int element)
        {
            int count = 0;
            int k = 0;
            for (int j =0; j<i; j++)
            {
                if (massiv[j]==element)
                {
                    count++;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Такого элемента нет");
            }
            else
            {
                i = i - count;
                int[] temp = new int[i];
                for(int j =0; j<i+count;j++)
                {
                    if(massiv[j]!=element)
                    {
                        temp[k] = massiv[j];
                        k++;
                    }

                }
                massiv = temp;
            }


        }

        public void removeIndex(int index)
        {
            i--;
            int k = 0;
            int[] temp = new int[i];
            for (int j = 0; j < i + 1; j++)
            {
                if (j != index)
                {
                    temp[k] = massiv[j];
                    k++;
                }

            }
            massiv = temp;
        }

        public void indexOf(int element)
        {
            int[] masIndex = new int[i];
            int count = 0;
            int k = 0;
            for (int j = 0; j < i; j++)
            {
                if (massiv[j] == element)
                {
                    count++;
                    masIndex[count - 1] = j;
                }
            }
            if(count == 0)
            {
                Console.WriteLine("Нет такого элемента");
            }
            else
            {
                for(k=0;k<count;k++)
                {
                    Console.WriteLine(masIndex[k]);                }
            }
        }

        public void GetElement(int index)
        {
            Console.WriteLine(massiv[index]);
        }

        public void GetIndex(int element)
        {
            int count = 0;
            int k = 0;
            for (int j = 0; j < i; j++)
            {
                if (massiv[j] == element)
                {
                    count++;
                    Console.WriteLine(j);
                }
            }
            if(count ==0)
            {
                Console.WriteLine("Нет такого элемента");
            }
        }

        public void printElements()
        {
            for(int j=0;j<i;j++)
            {
                Console.WriteLine(massiv[j] + " ");
            }
        }
    }
}
