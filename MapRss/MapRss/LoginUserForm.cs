using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapRss
{
    public partial class LoginUserForm : Form
    {
        User loginUser;
        public LoginUserForm(User user)
        {
            this.loginUser = user;
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextbox.Text == String.Empty ||
               PasswordTextbox.Text == String.Empty)
                MessageBox.Show("Fill out all sections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (!loginUser.AuthenticateUser(UsernameTextbox.Text, PasswordTextbox.Text))
                MessageBox.Show("Incorrect Credential", "Login-Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                loginUser.Password = PasswordTextbox.Text;
                loginUser.Username = UsernameTextbox.Text;
                loginUser.LoadUser();
                Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

       
    }
}
