using System;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginExample.ViewModels
{
    public class LoginExamplePageViewModel : INotifyPropertyChanged
    {
        string _email;
        public string Email 
        { 
            get { return _email; }
            set 
            {
                _email = value;
                OnPropertyChanged("Email");
            } 
        }

        string _password;
        public string Password 
        { 
            get { return _password; }
            set 
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        public ICommand LoginCommand { get; private set; }

        public LoginExamplePageViewModel()
        {
            LoginCommand = new Command(OnLoginCommand);
        }


        void OnLoginCommand()
        {
            if (string.IsNullOrEmpty(Email))
                Application.Current.MainPage.DisplayAlert("Login Example", "The email is empty", "Ok");
            else if (string.IsNullOrEmpty(Password))
                Application.Current.MainPage.DisplayAlert("Login Example", "The password is empty", "Ok");
            //else if (here maybe a regex validation for email)
            else
            {
                //TODO your logic for login
                Application.Current.MainPage.DisplayAlert("Login Example", "You have successfully logged in", "Ok");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
