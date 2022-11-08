using System;
using System.Collections.Generic;

namespace Klasstest2;

class program
{   
    private static void Main()
    {
        User u = new User();
        User.DataToVar(u);
        Console.WriteLine($"Hej {u.GetFullName()}, du är {u.Age} år och vi kan kontakta dig på {u.Email?.ToLower()}");
        

        UserRepository l = new UserRepository();

        l.Add(u);
    }
}