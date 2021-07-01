namespace ClassLibrary1
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Contact_data { get; set; }

        public User()
        {
        }

        public User(string name, string surname, string contactData)
        {
            Name = name;
            Surname = surname;
            Contact_data = contactData;
        }
    }
}