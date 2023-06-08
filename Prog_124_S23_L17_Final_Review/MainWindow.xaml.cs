using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Prog_124_S23_L17_GymClassLibrary;


namespace Prog_124_S23_L17_Final_Review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        List<Account> _members = new List<Account>();

        public MainWindow()
        {
            InitializeComponent();
            _members = Data.Accounts;

            lbDebug.ItemsSource = _members;
        } // MainWindow()

 

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {

            string email = txtEmail.Text;
            string password = txtPassword.Text;

            if(IsValidUser(email, password))
            {
                foreach (Account account in _members)
                {
                    if(email == account.Email)
                    {
                        Data._currentAccount = account;
                    }
                }

                MessageBox.Show(Data._currentAccount.Email);

                new Workouts().Show();
            }
            else
            {
                MessageBox.Show("Please Enter a valid email or password");
            }


        } // 

        public bool IsValidUser(string email, string password)
        {

            // Linear search - loops through an entire list
            // checks if the current value equals our SEARCH value
            // Responds if true or false

            foreach (Account account in _members)
            {
                if(email == account.Email && password == account.Password)
                {
                    return true;
                }
            }
            return false;
        }

        private void lbDebug_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Account selected = (Account)lbDebug.SelectedItem;

            txtEmail.Text = selected.Email;
            txtPassword.Text = selected.Password;

        }
    }
}
