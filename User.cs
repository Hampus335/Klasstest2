namespace Klasstest2
{
    internal class User
    {
        public string? Email { get; set; }
        public string? Age { get; set; }
        public string? FirstName { get; set; }
        public string? SurName { get; set; }

        public string GetFullName()
        {
            return $"{FirstName} {SurName}";
        }
    }
}
