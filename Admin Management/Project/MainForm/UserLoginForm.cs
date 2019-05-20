using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class UserLoginForm : Form
    {

        public UserLoginForm()
        {

            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {


            foreach (User i in MainForm.UserList)
            {
                if (i.uname == txtUserName.Text && i.upassword == txtUserPassword.Text)
                {
                    MessageBox.Show("Login Successful");
                    this.Close();
                    break;
                }

            }
        }
    }
}
