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
    public partial class ManageSubscriptionForm : Form
    {
        User editUser;
        public ManageSubscriptionForm(User user)
        {
            editUser = user;
            InitializeComponent();
        }

        private void ManageAcceptButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ManageURLTextBox.Text))
                MessageBox.Show("Please Provide a RSS URL", "URL-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string URL = ManageURLTextBox.Text;
                Feed newFeed = new Feed(URL);
                editUser.AddUserFeed(newFeed);
                //saveuser
                Close();
                
            }
                
        }
        private void ManageCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
