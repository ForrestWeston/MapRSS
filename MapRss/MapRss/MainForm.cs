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
        TreeView m_treeViewTopics;
        TreeView m_treeViewFeeds;
        DataGridView m_articleGridView;
        Reader m_rssReader = new Reader();

        public MainForm()
        {
            InitializeComponent();
            m_treeViewFeeds = FeedTreeView;
            m_treeViewTopics = TopicTreeView;
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
                User tmpUser = new User();
                tmpUser.AddFeedDialog();
                currentUser = tmpUser;
            }
            else
            {
                currentUser.AddFeedDialog();
                UpdateTreeViewFeed();
            }
            //will need to check if topic tab or feed tab is selected and act accordingly 
        }
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
            //will need to check if topic tab or feed tab is selected and act accordingly 
        }

        public TreeView CreateTreeView()
        {
            TreeView tv = new TreeView();
            tv.BeginUpdate();
            tv.EndUpdate();
            return tv;
        }

        public void UpdateTreeViewFeed()
        {
            foreach (var feed in currentUser.MyFeed)
                m_treeViewFeeds.Nodes.Add(new TreeNode(feed.Nickname));
            
        }
        #endregion







    }
}
