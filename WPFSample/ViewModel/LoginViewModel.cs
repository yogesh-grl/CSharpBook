using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFSample.Model;

namespace WPFSample.ViewModel
{
    internal class LoginViewModel : BaseViewModel
    {
        LoginModel objLoginModel = null;

        public string _Login { get; set; }
        public string _Password { get; set; }

        public LoginViewModel()
        {
            objLoginModel = new LoginModel();
        }

        public string Login
        {
            get
            {
                return _Login;
            }
            set
            {
                _Login = value;
                NotifyPropertyChanged(nameof(Login));
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }
            set
            {
                _Password = value;
                NotifyPropertyChanged(nameof(Password));
            }
        }

    }
}
