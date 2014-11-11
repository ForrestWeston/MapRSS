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
        Reader m_rssReader = new Reader();



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
            currentUser.PropertyChanged += UpdateTreeView;

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
            throw new NotImplementedException();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Feed/Topic Manipulation
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(currentUser == null)
            {
                MessageBox.Show("Please Create an account or Login first", "Login-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                currentUser.AddFeedDialog();
            }
            //will need to check if topic tab or feed tab is selected and act accordingly 
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //will need to check if topic tab or feed tab is selected and act accordingly 
        }
        public void UpdateTreeView(object sender, EventArgs e)
        {
            Feed newFeed = (Feed)sender;
            FeedTreeView.BeginUpdate();
            FeedTreeView.Nodes.Add(newFeed.Nickname);
            FeedTreeView.EndUpdate();
            FeedTreeView.Refresh();
        }

        #endregion







    }
}
