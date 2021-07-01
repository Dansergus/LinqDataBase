
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;


namespace ClassLibrary1
{


    public class Class1
    {
        public static string conection = " ";
        public MySqlConnection DataBase = new MySqlConnection(conection);
        private List<User> _users = new List<User>(); 
        private List<Account> _accounts = new List<Account>(); 
        private List<Role> _roles = new List<Role>(); 



        public void ADDingUser()
        {
            DataBase = new MySqlConnection(conection);
            DataBase.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM TABLE USER ;", DataBase);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string TempNAME = reader["NAME"].ToString();
                string TempSurname = reader["SURNAME"].ToString();
                string TempContactData = reader["CONTACTDATA"].ToString();
                _users.Add(new User(TempNAME, TempSurname,TempContactData));
            }
            
            DataBase.Close();

        }

        public void ADDingAccount()
        {
            DataBase = new MySqlConnection(conection);
            DataBase.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM TABLE ACCOUNT ;", DataBase);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string TempLogin = reader["LOGIN"].ToString();
                string TempPass = reader["PASSWORD"].ToString();
                string TempActivity_indicator = reader["activity_indicator"].ToString();
                _accounts.Add(new Account(TempLogin, TempPass,TempActivity_indicator));
            }
            
            DataBase.Close();

        }

        public void ADDingRole()
        {
            DataBase = new MySqlConnection(conection);
            DataBase.Open();
            MySqlCommand command = new MySqlCommand($"SELECT * FROM TABLE ROLE ;", DataBase);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string TempNameOfRole = reader["NameOfRole"].ToString();
                _roles.Add(new Role(TempNameOfRole));
            }
            
            DataBase.Close();
        }






        }

}