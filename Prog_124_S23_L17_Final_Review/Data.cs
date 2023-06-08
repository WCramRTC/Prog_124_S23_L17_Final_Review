using Prog_124_S23_L17_Final_Review;
using Prog_124_S23_L17_GymClassLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace Prog_124_S23_L17_Final_Review
{
    internal static class Data
    {
        public static Account _currentAccount;
        private static List<Account> _accounts = new List<Account>();


        public static string userInformation = "members.json";

        public static List<Account> Accounts { get => _accounts;  }
        static string ExerciseExtension = "_Exercises.csv";

        static Data()
        {
            LoadAccounts();
        }

        public static void Preload()
        {
            _accounts.Add(new Account("Josh", "Emery", "jemery@rtc.edu", "jem"));
            _accounts.Add(new Account("Will", "Cram", "wcram@rtc.edu", "wcram"));

            SaveAccounts();
        }

        public static string UsersExercises()
        {
            return _currentAccount.FirstName + ExerciseExtension;
        }

        public static void SaveAccounts()
        {
            JsonSerializerOptions jso = new JsonSerializerOptions()
            {
                WriteIndented = true
            };
            string jsonManager = JsonSerializer.Serialize(_accounts, jso);
            File.WriteAllText(userInformation, jsonManager);
        }

        public static void LoadAccounts()
        {
            string listFromFile = File.ReadAllText(userInformation);
            _accounts = JsonSerializer.Deserialize<List<Account>>(listFromFile);
        }


    } // class

} // 


//Data
//        public static UserAccount currentUser;
//public static List<UserAccount> accounts = new List<UserAccount>();

//// Use a static constructor to load the accounts list ( make sure a file exist before you try to load )
//static Data()
//{
//    ReadUsers();
//}
//// Special Method with provided code ( helps save a file with the users name and transaction )
//// This creates a unique file automatically based on the user account that's logged in

//public static string UsersTransactions()
//{
//    return currentUser.Name + TransactionExtension;
//}

//public static void Preload() // Used to load accounts list the first time, then save to .json

//        public static void AddUser(UserAccount account) // Add user to accounts and then save to json

//        public static void SaveUsers() // Save accounts json

//        public static void ReadUsers() // Read json and deserialize to accounts