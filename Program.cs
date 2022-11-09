using System;
using System.Collections.Generic;

namespace Klasstest2;

class program
{   
    private static void Main()
    {
        User u = new User();
        u.DataToVar();
        Console.WriteLine($"Hej {u.GetFullName()}, du är {u.Age} år och vi kan kontakta dig på {u.Email?.ToLower()}");

        UserRepository i = new UserRepository();
       
        i.Add(u);
        i.GetUserFromList();
    }
}