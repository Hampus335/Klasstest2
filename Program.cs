namespace Klasstest2;

class program
{
    private static void Main()
    {
        User u = new User();

        Console.WriteLine("Vad heter du i förnamn?");
        string? firstName = Console.ReadLine();
        u.FirstName = firstName;

        Console.WriteLine("Efternamn?");
        string? surName = Console.ReadLine();
        u.SurName = surName;

        Console.WriteLine("Hur gammal är du?");
        string? age = Console.ReadLine();
        u.Age = age;

        Console.WriteLine("Skriv din mail");
        string? email = Console.ReadLine();
        u.Email = email;

        Console.WriteLine($"Hej {u.GetFullName()}, du är {u.Age} år och vi kan kontakta dig på {u.Email}");
    }
}