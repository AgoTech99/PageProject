namespace PageProject.Models
{
    public class UserModel
    {
        private string _userName = "Alessio";
        public string UserName { get { return _userName; } set { _userName = value; } }

        private string _osName;
        public string OsName { get { return Environment.UserName; } set { _osName = value; } }


    }
}
