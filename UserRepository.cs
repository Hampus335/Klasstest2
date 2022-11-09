namespace Klasstest2
{
    internal class UserRepository
    {
        private readonly List<User> _users = new List<User>()
        {
            new User { FirstName = "Stig", SurName = "Lennartsson", Age = "96", Email = "Använder inte internet mailen." },
            new User { FirstName = "Lukas", SurName = "Lukasson", Age = "14", Email = "gmail.com" }
        };

        public void Add(User u)
        {
            _users.Add(u);
        }
        
        public void GetUserFromList()
        {
            foreach (User line in _users)
            {
                Console.WriteLine($"Namn: {line.GetFullName()}, Ålder: {line.Age}, Email: {line.Email}");
            }
        }
    }
} 
