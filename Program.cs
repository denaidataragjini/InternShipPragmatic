using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the number of cubes");
            int n = int.Parse(Console.ReadLine());

            var result = FindLadders(0, n); //therritja e funksionit rekrusiv, 0=> niveli minimum i shkalleve
            Console.WriteLine(result);

            Console.ReadKey();
        }
        public static int FindLadders(int level, int numberOfCubes)


        {  //ruajme nr e kubeve ne nje variabel te re
            int x = numberOfCubes;

            int numberOfLadders = 1; //Ruan nr e shkalleve, ka vlere 1 pasi vete n(cfaredolloj qofte vlera e saj) formon nje shkalle


            if (numberOfCubes == 1)  //kushti ndalues i funksionit rekrusiv
            {
                return numberOfLadders;
            }
            else
            {
                // cikli niset nga level+1 (Pasi nje nivel e krijuam me vete n )
                //shkon deri (x+1)/2, pasi nuk kemi pse te kontrollojme me elemetet  mbi gjysmen e nr te kubeve.
             
                for (int i = level + 1; i < (x + 1) / 2; ++i)
                {
                    numberOfLadders += FindLadders(i, numberOfCubes - 1);


                }

                return numberOfLadders;
            }


        }
    
     }
}
