using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageProject.Models
{
    public class UserData
    {
        private string profile = "federico";
        public string Profile
        {
            get
            {
                return profile;
            }
            set
            {
                profile = value;
            }
        }


        

        private string user = Environment.UserName;
        public string User
        {
            get
            {
                return user;
            }
        }
    }
}
