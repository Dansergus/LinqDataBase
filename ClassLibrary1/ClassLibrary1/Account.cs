namespace ClassLibrary1
{
    public class Account
    {
      
        public string Login { get; set; }
        public string Password { get; set; }
        public string activity_indicator { get; set; }

        public Account()
        {
        }

        public Account(string login, string password, string activityIndicator)
        {
            Login = login;
            Password = password;
            activity_indicator = activityIndicator;
        }

        
    }
}