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
    public partial class CreateUserForm : Form
    {
        User newUser;
        public CreateUserForm(User user)
        {
            this.newUser = user;
            InitializeComponent();
        }

        private void CreateUserAccept_Click(object sender, EventArgs e)
        {
            if( UsernameTextbox.Text == String.Empty || 
                PasswordTextbox.Text == String.Empty || 
                ConfirmPasswordTextbox.Text == String.Empty)
            {
                MessageBox.Show("Fill out all sections","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(ConfirmPasswordTextbox.Text != PasswordTextbox.Text)
            {
                MessageBox.Show("Passwords must match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                newUser.Password = PasswordTextbox.Text;
                newUser.Username = UsernameTextbox.Text;
                //SaveUser
                Close();
            }
        }

        private void CreateUserCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
    
}
