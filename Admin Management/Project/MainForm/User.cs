using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainForm
{
    
    public class User
    {       

        public string uname;
        public string upassword;
        public string uph;
        public string uemail;
        public string uaddress;

        public User()
        {
        }

        public User(string name, string password, string ph, string email, string address)
        {
            
            this.uname = name;
            this.upassword = password;
            this.uph = ph;
            this.uemail = email;
            this.uaddress = address;
        }   
    }            
}
