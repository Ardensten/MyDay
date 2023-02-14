using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDay.Logic
{
    internal class HelperMethods
    {
        internal static int TryInt()
        {
            int number = 0;
            bool correctInput = false;

            while (!correctInput)
            {
                if (!int.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("Felaktig inmatning, försök igen. Måste vara ett heltal.");
                }
                else
                {
                    correctInput = true;
                }
            }
            return number;
        }

        internal static string TryString()
        {
            bool correctInput = false;
            string anyWord = null;

            while (!correctInput)
            {
                anyWord = Console.ReadLine();
                if (string.IsNullOrEmpty(anyWord))
                {
                    Console.WriteLine("Felaktig inmatning, försök igen. Fältet kan inte vara tomt.");
                }
                else
                {
                    correctInput = true;
                }
            }
            return anyWord;
        }
        internal static void InputInstructions()
        {
            Console.WriteLine("Felaktig inmatning, försök igen.");
        }

    }
}
