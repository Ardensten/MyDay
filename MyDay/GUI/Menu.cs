using MyDay.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDay.GUI
{
    internal class Menu
    {
        internal static void Start()
        {
            Console.Clear();

            Console.WriteLine($"Välkommen!\n" +
                "[1] Logga in\n" +
                "[2] Registrera dig");

            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.KeyChar)
            {
                case '1':
                    LogIn();
                    break;
                case '2':
                    SignUp();
                    break;
                default:
                    HelperMethods.InputInstructions();
                    Start();
                    break;
            }

        }
        internal static void LogIn()
        {
            Console.Clear();

            Console.WriteLine("Logga in här!");
            Console.Write("Användarnamn: ");
            string userName = HelperMethods.TryString();
            Console.Write("Lösenord: ");
            string password = HelperMethods.TryString();


        }
        internal static void SignUp()
        {
            Console.Clear();


            Console.WriteLine("Registrera dig här!");
            Console.Write("Vad heter du? ");
            string name = HelperMethods.TryString();
            Console.Write("Användarnamn: ");
            string userName = HelperMethods.TryString();
            Console.Write("Lösenord: ");
            string password = HelperMethods.TryString();
            Console.Write("Email: ");
            string email = HelperMethods.TryString();

            Methods.CreateNewUser(name, userName, password, email);

            Console.WriteLine("Du har nu registrerats. Tryck nånstans för att fortsätta.");
            Console.ReadKey();
            Start();

        }
        internal static void LoggedInStart()
        {
            Console.Clear();

            Console.WriteLine("Välkommen Jonatan!\r\n" +
                "Morgonrutin\r\nEftermiddagsrutin\r\n" +
                "Kvällsrutin\r\nInköpslista\r\nAnteckningar\r\nLägg till ny rutin");
        }
        internal static void AddNewRoutine()
        {
            Console.Clear();

        }

    }
}
