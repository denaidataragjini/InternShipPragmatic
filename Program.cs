using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    class Program
    {
        public static void CalculateCallPayment(int numberOfseconds)
        {
            int valueOfDivide;
            int valueOfmodul;
            decimal totalAmount = 0;

            if (numberOfseconds >= 180) //nese kemi me shume se 3 minuta bisede
            {
                numberOfseconds -= 180;  //heqim vleren ne sekonda te 3 min=180sec
                totalAmount += 6;         //totali = 6 pasi per 3 min kosto eshte 6 $

                valueOfDivide = numberOfseconds / 10;   // ndajme vleren e marre nga pjestimi(heresin), me 10 pasi per cdo 10 sec shtohet 0.5$
                valueOfmodul = numberOfseconds % 10;     // vleren e marre nga moduli (mbetja)

                totalAmount += (decimal)(valueOfDivide * 0.5); //i shtojme shumes vleren e marre nga heresi*0.5

                if (valueOfmodul != 0) //nese kemi mbetje duhet ti shtojme totalit 0.5sec 
                {
                    totalAmount += (decimal)0.5;
                    Console.Write(totalAmount);
                }
                    Console.Write(totalAmount);
            }
            else
            {
                totalAmount = 6;
            Console.Write(totalAmount);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Give the total number of seconds Mr.tafaj call dured:");
            int totalSeconds = int.Parse(Console.ReadLine());
            CalculateCallPayment(totalSeconds); Console.WriteLine("$");
            Console.ReadKey();
        }
    }
}

/* Shembull:    numberOfseconds = 1000 seconds   totalAmount=0$:
 * =>  1000 >180 ==> numberOfseconds =1000-180 = 820;   totalAmount=6$
 * =>valueOfDivide = 820/10 = 82 ;  totalAmount= 6+ (82 *0.5)= 47;
 * valueOfmodul= 820%10 =0; (Eshte == 0) 
  * Ketu perfundon ushtrimi dhe vlera e harxhuar eshte  47$.
 */

