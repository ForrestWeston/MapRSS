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
    public partial class UserLogin : Form
    {
        private User m_user;
        public UserLogin(User user)
        {
            InitializeComponent();
            m_user = user;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == String.Empty ||
                    passwordTextBox.Text == String.Empty)
            {
                MessageBox.Show("Fill out all sections", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                m_user.LoadUser(nameTextBox.Text, passwordTextBox.Text);

                Close();
            }
        }
    }
}
