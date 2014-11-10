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
    public partial class EditUserForm : Form
    {
        User editUser;
        public EditUserForm(User user)
        {
            editUser = user;
            InitializeComponent();
            EditCurrentUsernameTextBox.Text = editUser.Username.ToString();
            EditCurrentPasswordTextBox.Text = editUser.Password.ToString();
            EditRefreshRatenumericUpDown.Value = editUser.Refresh;
            
        }

        private void EditUserAcceptButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(EditNewUsernameTextBox.Text))
                editUser.Username = EditNewUsernameTextBox.Text;
            if (!String.IsNullOrWhiteSpace(EditNewPasswordTextBox.Text))
                editUser.Password = EditNewPasswordTextBox.Text;
            editUser.Refresh = Convert.ToInt32(EditRefreshRatenumericUpDown.Value);
            //SaveUser
            Close();
        }

        private void EditUserCancleButon_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
