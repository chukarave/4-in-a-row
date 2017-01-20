using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            drawboard();
        }
        public static void drawboard()
        { 
            
            string alphabet = "ABCDEFGHIJ";
            int c, i, j;
            bool firstiteration = true;
            
            for (c = 1; c < 11; c++)
            {
                if (firstiteration)
                {
                    Console.Write(" ");
                    firstiteration = false;
                }
                Console.Write(" " + c + " ");
            }
            Console.WriteLine();

         
            for (i = 0; i < 10; i++ )
            {
                Console.Write(alphabet[i]);
                for (j = 0; j < 10; j++ )
                {
                    
                    Console.Write(" _ ");
               }

                Console.WriteLine();
            }

            Console.ReadKey();
        }

    }
}
