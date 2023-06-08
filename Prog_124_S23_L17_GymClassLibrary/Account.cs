namespace Prog_124_S23_L17_GymClassLibrary
{
    public class Account
    {

        string _firstName;
        string _lastName;
        string _phone; // optional
        string _idNumber; // not to be filled out by the user
        string _location; // optional
        string _email;
        string _password;


        public Account() { }

        public Account(string firstName, string lastName, string phone, string location, string email, string password)
        {
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _location = location;
            _email = email;
            _password = password;
        } // Account

        public Account(string firstName, string lastName, string email, string password)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
            _password = password;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string IdNumber { get => _idNumber; }
        public string Location { get => _location; set => _location = value; }
        public string Email { get => _email; set => _email = value; }
        public string Password { get => _password; set => _password = value; }

        public override string ToString()
        {
            return $"{_firstName} - {_email} - {_password}";
        }


        // List<Workout>

        //        email
        //password
        //first name
        //last name
        //phone
        //idNumber
        //location
        //List<Workout>
    }
}
