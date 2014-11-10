using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MapRss
{
    public partial class MainForm : Form
    {
        User currentUser;

        public MainForm()
        {
            InitializeComponent();
        }
        #region User Manipulation
        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User newUser = new User();
            newUser.CreateUser();
            currentUser = newUser;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentUser != null)
                currentUser.EditUser();
            else
                MessageBox.Show("You must login to edit user settings", "Login-error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        #endregion




    }
}
