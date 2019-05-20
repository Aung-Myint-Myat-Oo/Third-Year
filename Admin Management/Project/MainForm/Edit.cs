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
    public partial class Edit : Form
    {
        int SelectedRowIndex;
        public Edit()
        {
            InitializeComponent();
        }

        public Edit(int Index)//Construstor to recieve SelectedRowIndex form AdminLoginForm
        {
            InitializeComponent();//No Form (Blank) is show without this
            SelectedRowIndex = Index;//Error if SelectedRowIndex is declared here
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            User SelectedUser = (User)MainForm.UserList[SelectedRowIndex];//Error if no TypeCast

            txtName.Text = SelectedUser.uname;
            txtPassword.Text = SelectedUser.upassword;
            txtEmail.Text = SelectedUser.uemail;
            txtPhone.Text = SelectedUser.uph;
            txtAddress.Text = SelectedUser.uaddress;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MainForm.UserList.RemoveAt(SelectedRowIndex);
            MessageBox.Show("Please Relogin to see the changes","Deleted!");
            this.Close();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MainForm.UserList[SelectedRowIndex] = new User(txtName.Text, txtPassword.Text, txtPhone.Text, txtEmail.Text, txtAddress.Text);
            MessageBox.Show("Please Relogin to see the changes", "Updated!");
            this.Close();
        }
    }
}
