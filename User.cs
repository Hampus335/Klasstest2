using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace Klasstest2
{
    internal class User
    {
        public string? Email { get; set; }
        public string? Age { get; set; }
        public string? FirstName { get; set; }
        public string? SurName { get; set; }

        public void DataToVar()
        {       
            Console.WriteLine("Vad heter du i förnamn?");
            this.FirstName = Console.ReadLine();

            Console.WriteLine("Efternamn?");
            this.SurName = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            this.Age = Console.ReadLine();

            Console.WriteLine("Skriv din mail");
            this.Email = Console.ReadLine();
        }

        public string GetFullName()
        {   
            return $"{this.FirstName} {this.SurName}";
        }
    }
}
