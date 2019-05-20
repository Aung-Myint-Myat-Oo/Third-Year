using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace MainForm
{
    public partial class MainForm : Form
    {
        public static ArrayList UserList = new ArrayList();//"public static" for accessing ArrayList from Register Form
        
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminLoginForm alf = new AdminLoginForm();
            alf.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserLoginForm ulf = new UserLoginForm();
            ulf.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserList.Add(new User("Aung Myint Myat Oo", "imadethislmao", "09788561322", "ammo@csharp.pj", "Inlay, Hlaing"));
            UserList.Add(new User("Benedict Cumberbatch", "lemmeguess", "01010110", "dr.strange@marvel.com", "Queen Charlotte's and Chelsea Hospital, London, U.K."));
            UserList.Add(new User("Mark Ruffalo", "hulksmash", "01782880", "hulk@marvel.com", "Kenosha, Wisconsin, U.S."));
            UserList.Add(new User("Robert Downey, Jr.", "givebackmyshield", "011335670", "ironman@marvel.com", "Manhattan, New York City, New York, U.S."));
            UserList.Add(new User("Chris Evans", "language", "015576880", "cap@marvel.com", "Boston, Massachusetts, U.S."));
            UserList.Add(new User("Chris Hemsworth", "godofthunder", "0125461880", "thor@marvel.com", "Melbourne, Austrilla"));
            UserList.Add(new User("Scarlett Johnsson", "thesunisgettinglow", "012498780", "blackwidow@marvel.com", "Manhattan, New York City, New York, U.S."));
        }
    }
}
