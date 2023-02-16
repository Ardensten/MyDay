using MyDay.Logic;
using MyDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

            Methods.LogIn(userName, password);

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

            string user = "";

            Console.WriteLine($"Välkommen {user}!"); //TODO: Ställ in olika hälsningar beroende på tid på dygnet
            //TODO: Lägg in väder-API
            //TODO: API med dagligt citat?

            Console.WriteLine($"[1] Se dina rutiner\n" +
                $"[2] Lägg till ny rutin\n" +
            $"[3] Inköpslista\n" +
            $"[4] Anteckningar");


            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.KeyChar)
            {
                case '1':
                    ViewAllRoutines();
                    break;
                case '2':
                    AddNewRoutine();
                    break;
                case '3':
                    ShoppingList();
                    break;
                case '4':
                    Notes();
                    break;
                default:
                    HelperMethods.InputInstructions();
                    Start();
                    break;
            }

        }

        private static void Notes()
        {
            throw new NotImplementedException();
        }

        private static void ShoppingList()
        {
            //int count = 1;
            //foreach (item in db.ShoppingListItem.Where(x => x.UserId == loggedInId).OrderBy)
            //    {  Console.WriteLine($"{count} {item.Name} {item.Shop}")
            //       count++
            //    }        
            Console.WriteLine("Lägg till något i listan");
        }

        private static void ViewAllRoutines()
        {
            throw new NotImplementedException();

            //int count = 1;
            //foreach (Routine in User.Routines.Where(x => x.userId == loggedInId)
            //    {  Console.WriteLine($"{count} {Routine.Name})
            //       count++
            //    }
        }

        internal static void AddNewRoutine()
        {
            Console.Clear();

            Console.WriteLine("Lägg till en ny rutin");
            Console.WriteLine("Förslag på rutiner; Morgonrutin, Eftermiddagsrutin, Läggdagsrutin");
            Console.Write("Vad ska rutinen heta? ");
            string name = HelperMethods.TryString();
            Console.Write("Vilken tid ska rutinen starta? ");
            TimeOnly timeOfDay = TimeOnly.Parse(HelperMethods.TryString()); //TODO: validera TimeOnly
            //TODO: Lägg till så att man kan välja hur ofta rutinen ska upprepas

            Methods.CreateNewRoutine(name, timeOfDay);

            Console.WriteLine("Rutinen har lagts till. Tryck nånstans för att fortsätta.");
            Console.ReadKey();
        }

    }
}
