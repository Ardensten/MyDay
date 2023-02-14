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
        internal static void CreateNewUser(string name, string userName, string password, string email)
        {
            User user = new() { Email = email, Name = name, UserName = userName, Password = password};

            // TODO: lägg till användaren till databasen
        }
    }
}
