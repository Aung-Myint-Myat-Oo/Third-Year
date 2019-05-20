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
    public partial class AdminLoginForm : Form
    {

        
        public AdminLoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            String psw = "";
            psw = txtAPwd.Text;
            if (psw.Equals("Admin"))
            {

                label1.Hide();
                txtAPwd.Hide();
                btnLogin.Hide();
                label2.Show();
                UserGrid.Show();
            }
            else MessageBox.Show("Password didn't match!", "Try Again");
        }

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            int index = 0;
            UserGrid.Rows.Clear(); //If not, Same data will be repeatly inserted
            foreach (User i in MainForm.UserList)
            {
                index = UserGrid.Rows.Add();

                UserGrid.Rows[index].Cells[0].Value = i.uname;
                UserGrid.Rows[index].Cells[1].Value = i.upassword;
                UserGrid.Rows[index].Cells[2].Value = i.uph;
                UserGrid.Rows[index].Cells[3].Value = i.uemail;
                UserGrid.Rows[index].Cells[4].Value = i.uaddress;

                
            }
            label2.Hide();
            UserGrid.Hide();
         
        }

        private void UserGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int SelectedRowIndex = UserGrid.CurrentCell.RowIndex;
            Edit edit = new Edit(SelectedRowIndex);
            edit.Show();
        }
        
    }
}
