using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    class
     Program
    {
        static void Main(string[] args)
        {
            //Marrim numrin e rreshtave(M)
            Console.WriteLine("Give the number of rows");
            var n = int.Parse(Console.ReadLine());
            //Marrim numrin e kolonave(N)
            Console.WriteLine("Give the number of columns");
            var m = int.Parse(Console.ReadLine());
    



            bool alternate = false; //Do e perdor per te ndryshuar rendin e rruges ne menyre te alternuar, pasi nje here me duhet te eci nga lart poshte njeher nga poshte lart

            for (int i = 1; i <= m; i++)
            {
                if (!alternate)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        Console.WriteLine(string.Format("{0} {1}", i, j));//printon dy kordinatat dhe cikli vazhdon deri ne fund te kolones
                     
                    }
                }
                else
                {
                    for (int j = n; j != 0; j--)  //Cikli nis nga poshte lart, deri ne fillim te kolones
                    {
                        Console.WriteLine(string.Format("{0} {1}", i, j));
                    }
                }

                alternate = !alternate; //alternohet rreshti 
            }

            Console.ReadKey();
        }
    }
} 



//Shembull
/*  1  2  3  (m)
  1 *  *  *

  2 *  *  *
(n)  
    sipas shembullit qe mora n=2 dhe m=3
    Miu fillon te haje ne kete menyre
    1-1 (zbret posht)
    2-1 (kthehet djathtas)
    2*2 (ngjitet siper)
    1*2 (kthehet djathtas)
    1*3 (zbret poshte)
    2*3
     */
