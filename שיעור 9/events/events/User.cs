using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace events
{
    public delegate string Loginsuccess(string username);
    public delegate string LoginFailed();
    public class User
    {
        public User(string username, string password,int totalCash)
        {
            Username = username;
            Password = password;
            TotalCash= totalCash;

        }

        public string Username {get; set; }
        public string Password { get; set; }
        public int TotalCash { get; set; }
        public int Depositcash { get; set; } = 0;

        public override string ToString()
        {
            return $"{Username} Deposit to the bank: {Depositcash} shekels";
        }
    }

    public static class UserCollection
    {
        public static List<User> Users { get; set; } = new List<User>() {new User("Avicii","123456",250) ,new User("Naruto","Rassengan",200),new User("Luffy","gear4",150)};

        public static event Loginsuccess SuccessLoginEvent;

        public static event LoginFailed UnsuccesfulLoginEvent;

        public static string login(string username , string password)
        {
            foreach (var user in Users)
            {
                if (user.Username == username && user.Password == password) { SuccessLoginEvent = success; return SuccessLoginEvent(username); }
                else if (user.Username == username && user.Password != password) { UnsuccesfulLoginEvent = Wrongpassword; return UnsuccesfulLoginEvent(); }
            }
            UnsuccesfulLoginEvent = UserNotExist;
            return UnsuccesfulLoginEvent();

        }

        public static string success(string username)
        {
            return $"Wellcome {username}";
        }

        public static string Wrongpassword()
        {
            return $"Wrong password";
        }
        public static string UserNotExist()
        {
            return $"User name does not exist";
        }

    }
    
}
