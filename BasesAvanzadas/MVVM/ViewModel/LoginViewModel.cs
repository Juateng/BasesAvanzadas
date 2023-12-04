using BasesAvanzadas.Core;
using BasesAvanzadas.MVVM.Model;
using System;
using System.Linq;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Threading;
using System.Windows.Input;

namespace BasesAvanzadas.MVVM.ViewModel
{
    internal class LoginViewModel : ObservableObject
    {
        LoginDBDataContext dc = new LoginDBDataContext(Properties.Settings.Default.LearnHubConnectionString);

        //Fields
        private string _username;
        private string _password;
        private string _errorMesage;
        private bool _isViewVisible = true;
        private int _accesLevel;

        //Properties
        public string Username 
        { 
            get { return _username; }
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username)); 
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            } 
        }
        public string ErrorMesage
        {
            get { return _errorMesage; }
            set
            { 
                _errorMesage = value;
                OnPropertyChanged(nameof(ErrorMesage));
            }
        }
        public bool IsViewVisible
        {
            get { return _isViewVisible; }
            set
            {
                _isViewVisible = value;
                OnPropertyChanged(nameof(IsViewVisible));
            }

        }

        public int AccesLevel
        {
            get { return _accesLevel; }
            set
            {
                _accesLevel = value;
                OnPropertyChanged(nameof(AccesLevel));
            }
        }

        //-> Commands
        public ICommand LoginCommand { get; }
        public ICommand RecoverPassword { get; }
        public ICommand ShowPassword { get; }

        //Constructor
        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(ExecuteLoginCommand, CanExecuteLoginCommand);
        }
        private void ExecuteLoginCommand(object obj)
        {
            var teacher = dc.profesors.FirstOrDefault(u => u.Correo == Username && u.Contraseña == Password);
            var student = dc.estudiantes.FirstOrDefault(u => u.Correo == Username && u.Contraseña == Password);

            if (teacher != null || student != null)
            {
                MainWindow menu = new MainWindow();
                menu.Show();
                IsViewVisible = false;
                AccesLevel = (teacher != null) ? 1 : 0;
            }
            else
            {
                ErrorMesage = "Correo o contraseña inválidos.";
            }
        }
        private bool CanExecuteLoginCommand(object arg)
        {
            return !(string.IsNullOrWhiteSpace(Username) || Username.Length < 3 || Password == null || Password.Length < 3);
        }
    }
}
