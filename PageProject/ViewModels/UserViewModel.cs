using System.ComponentModel;

namespace PageProject.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {

        private Models.UserModel _model { get; set; }


        public event PropertyChangedEventHandler? PropertyChanged;


        public UserViewModel (Models.UserModel uM)
        {
            _model = uM;
        }

        public string OsName 
        { 
            get => _model.OsName; 
        }
        public string UserName
        {
            get => _model.UserName;

            set
            {
                _model.UserName = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UserName)));
            }
        }
    }
}
