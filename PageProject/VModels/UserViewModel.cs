using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageProject.VModels
{
    public class UserViewModel
    {
        private Models.UserData UserData { get; set; }

        public string Profile 
        { 
            get
            {
                return UserData.Profile;
            }
            set
            {
                UserData.Profile = value;
            } 
        }
        public string User 
        { 
            get => UserData.User; 
        }
        public UserViewModel(Models.UserData userData)
        {
            UserData = userData;
            
        }



    }
}
