using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spiral
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter the size :");
            int size = int.Parse(Console.ReadLine());


            int[,] a = new int[size, size];
            int counter = 1;
            int startrow = 0, endrow = size - 1 , startcol = 0 , endcol= size-1;


            while (counter <= size * size)
            {
                //top 

                for (int i = startcol; i <= endcol; i++)
                {
                    a[startrow, i] = counter++;
                }

                //down

                for (int j = startrow +1 ; j <= endcol; j++)
                {
                    a[j, endcol] = counter++;
                }

                //left

                for (int i = endcol - 1; i >= startcol; i--)
                {
                    a[endrow, i] = counter++;
                }

                //up

                for (int j = endrow - 1; j >= startrow + 1; j--)
                {
                    a[j, startcol] = counter++;
                }


                startcol++;
                startrow++;
                endcol--;
                endrow--;

            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
