using MyDay.GUI;
using MyDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDay.Logic
{
    internal class Methods
    {
        internal static void LogIn(string userName, string password)
        {
            // TODO: kolla mot databasen om användaren finns
            // Globals.loggedInId = ;

            Menu.LoggedInStart();
        }
        internal static void CreateNewUser(string name, string userName, string password, string email)
        {
            User user = new() { Email = email, Name = name, UserName = userName, Password = password};

            // TODO: lägg till användaren till databasen
        }
        internal static void CreateNewRoutine(string name, TimeOnly timeOfDay)
        {
            Routine routine = new() { Name = name, TimeOfDay = timeOfDay};
        }
    }
}
