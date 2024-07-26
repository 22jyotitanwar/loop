using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_formation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int age = 20;

             switch(age)
             {
                 case 18:

                     Console.WriteLine("please wait for an year");
                     break;

                 case 20:
                         Console.WriteLine("you are twenty");
                     break;

                 default:
                     Console.WriteLine("enjoy!");
                     break;*/

            // loop formation in c Sharp
            // loop is better for repetion
            //1. while loop
            /* int i = 0;
             while (i < 500)
             {
                 Console.WriteLine(i);
                 i++;*/

            // DO WHILE LOOP.

            /*    int i = 0;
            do                    // it run one time compulsary; atleast one time run
            {
                Console.WriteLine(i+1);
                i++;
            }
            while (i < 5) ; */

            //for loop

            /*for (int i = 0; i < 5; i++)     // int i = intiliazition, i< 5; condition check; i++ update satement;
            {
                Console.WriteLine(i + 1); 
            } */

            //  BREAK AND CONTINUE STATEMNET 
            /*  for (int i = 0; i < 5; i++)   
            {
                Console.WriteLine(i + 1);
                break;*/
                    
                    for (int i = 0; i < 5; i++)   
            {
                if (i == 0)
                {
                    continue; // leave this complete iteration of the loop
                }
                    Console.WriteLine(i + 1);
                }
               
            
            }
        }
    }

