using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX2
{
    class Program
    {
        public static void IsoscelesTriangle(long firstSide, long secondSide, long thirdSide) //Parametrat i mora si long pasi vlera mund ti shkoje deri ne 10 milion
        {
            //kontrollojme nese te pakten 2 jane te barabarte
            if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        static void Main(string[] args)
        {
            //marrim vlerat e brinjeve si input nga console
            Console.WriteLine("Give the 1 side of triangle");
            long firstSide = long.Parse(Console.ReadLine());
            Console.WriteLine("Give the 2 side of triangle");
            long secondSide = long.Parse(Console.ReadLine());
            Console.WriteLine("Give the 3 side of triangle");
            long thirdSide = long.Parse(Console.ReadLine());
            //kontrollojme nese vlerat jane  0 ≤ (s1, s2, s3) ≤ 10 milion.
            if (firstSide > 0 && firstSide < 10000000 && secondSide > 0 && secondSide < 10000000 && thirdSide > 0 && thirdSide < 10000000)
            {
                IsoscelesTriangle(firstSide, secondSide, thirdSide); //therrasim funskionin 
            }

            else
            { //shfaqim mesazh gabimi nese vlerat nuk perkojne me kushtin
                Console.WriteLine("The values of each side must be larger than 0 and fewer than 10million");
            }

            Console.ReadKey();
        }
    }
}

