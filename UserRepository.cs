namespace Klasstest2
{
    internal class UserRepository
    {
        private readonly List<User> _users = new List<User>();
       
        public void Add(User u)
        {
            _users.Add(u);
        }
    }
} 
