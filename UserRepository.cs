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
            Console.WriteLine(_users.ToString());
        }
        
        public void GetUserFromList(User u)
        {
            foreach (User line in _users)
            {
                Console.WriteLine(string.Format(]=;
            }
        }
    }
} 
