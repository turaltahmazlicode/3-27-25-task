namespace StudentTask
{
    public class Person
    {
        public Person(string name, string email, sbyte score)
        {
            Name = name;
            Email = email;
            Score = score;
        }

        private string name;
        private string email;
        private sbyte score;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Email
        {
            get => email;
            set => email = value;
        }
        public sbyte Score
        {
            get => score;
            set => score = value;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nEmail: {Email}\nScore: {Score}";
        }
    }
}
