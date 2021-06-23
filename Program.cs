using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {


        static void Main(string[] args)
        { /* I ruaj ne nje matrice marredhenien qe ka x kalores me kaloresit e tjere. nese kemi 1 (shoke) 
            nese kemi 0 (nuk jane shoke)
            */
            //I vendosa manualisht inputin e shembullit matrices
            int[,] knightsRelationshipArray = new int[5, 5] { {0, 1, 1, 0, 1 }, { 1, 0, 0, 1, 1 }, { 1, 0, 0, 1, 1 }, { 0, 1, 1, 0, 1 }, { 1, 1, 1, 1, 0 } };

            int count = 0; //mban nr e lidhjeve qe do te kemi ne fund

            for(int i=0; i< knightsRelationshipArray.GetLength(0); i++)//kaloresit
            {
                for(int j=0; j<knightsRelationshipArray.GetLength(1); j++) //marredhenien e i kaloresit me j kaloresit e tjere
                {
                    if (i != j) //pra nese eshte marredhenia me veten nuk quhet
                    {
                        if(knightsRelationshipArray[i,j]== 1) //kontrollojme nese jane apo jo shok
                        {  //reciprokisht dhe j eshte shok me i, pra nuk bejme kontroll per kete
                            knightsRelationshipArray[j, i] = 0;  //e bejme 0 pasi kjo marredhenie u vendos dhe nuk perdoret me
                            i = j; //tani kalojme tek kaloresi i per ti gjetur dhe shokun e dyte te tij ne te njejten menyre
                            count++;
                            break;// i bej break pasi nuk ka pse ti kontrolloje me j e tjera
                        }

                        j++;
                    }

                }
                // nese kemi mbarur te gjithe ciklin dhe nuk kemi gjetur marredhenie ateher kthejm No(Nuk kemi si ti ulim ne tavoline nese x kalores nuk ka marredhenie me asnje)
                if(count ==0)
                {
                    Console.Write("NO");

                }
               
            }
        
 
            if (count <= knightsRelationshipArray.Length)// Ketu jam ne medyshje per kete kusht. Do te ishte me funksional nese do te ishte ==  
            {
                Console.Write("Yes");
            }
            Console.ReadKey();
        }
    }
}
