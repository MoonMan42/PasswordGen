using MvvmCross.ViewModels;
using PasswordGen.Core.Model;
using System.Collections.ObjectModel;

namespace PasswordGen.Core.ModelView
{
    public class PasswordViewModel : MvxViewModel
    {
        private ObservableCollection<PasswordModel> _passwords;

        public ObservableCollection<PasswordModel> Passwords
        {
            get { return _passwords; }
            set
            {
                SetProperty(ref _passwords, value);
            }
        }

        #region UI
        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                SetProperty(ref _password, value);
            }
        }


        #endregion

    }
}
