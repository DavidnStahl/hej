using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array._9
{
    class Program
    {
        static void Main(string[] args)
        {
            /*9. Skapa ett program där användaren måste mata in 10 tal.
             * Programmet skall bara spara tal som har ett värde som är mindre än 30, annars anses det som felaktigt tal.
             * När användaren matat in 10 riktiga tal skrivs dessa ut på en lista på skärmen */
            Console.WriteLine("Mata in 10 tal");
            int[] tal = new int[10];
            for (int i = 0; i < 10; i++)
            {
                
                Console.Write($"Tal {i + 1}: ");
                int input = Convert.ToInt32(Console.ReadLine());
                if (input < 30)
                {
                    tal[i] = input;
                }
                else
                {
                    i--;
                }

            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(tal[i]);
            }
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
