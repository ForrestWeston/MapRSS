using Equin.ApplicationFramework;
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
            WebBrowser.ScriptErrorsSuppressed = true;
            
            
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
            if (currentUser != null)//someone is loged in
                MessageBox.Show("You are already logged in", "Login-error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                User loginUser = new User();
                loginUser.LoginUser();
                currentUser = loginUser;
                currentUser.PropertyChanged += UpdateTreeView;
            }

        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentUser == null)
                MessageBox.Show("Cannot logout as you are not logged in", "Login-error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //clear all the forms to initial values 
                this.currentUser.SaveUser();
                this.currentUser = null;
                this.FeedTreeView.Nodes.Clear();
                this.ArticleDataGridView.DataSource = null;
                this.ArticleDataGridView.Rows.Clear();
                this.WebBrowser.Navigate("about:blank");
            }

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
            FeedTreeView.Nodes.Add(newFeed.Title);
            FeedTreeView.EndUpdate();
            FeedTreeView.Refresh();
        }
        #endregion

        private void FeedTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView currentTreeView = sender as TreeView;
            var curArticles = new BindingListView<Article>(currentUser.GetUserArticles(currentTreeView.SelectedNode.Text));
            ArticleDataGridView.DataSource = curArticles;
            for(int i = 0; i < ArticleDataGridView.ColumnCount; i++)
            {
                ArticleDataGridView.Columns[i].SortMode = DataGridViewColumnSortMode.Automatic;
                ArticleDataGridView.Columns[i].ReadOnly = true;
                //ArticleDataGridView.Columns[i].DefaultCellStyle.BackColor = Color.Khaki;
            }

        }
        private void ArticleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var Grid = sender as DataGridView;

            //if the user has selected the checkbox
            if(e.ColumnIndex == ArticleDataGridView.Columns["Read"].Index)
            {
                //mark as unread
                if ((bool)ArticleDataGridView.Rows[e.RowIndex].Cells["Read"].Value)
                {
                    //Grid.CurrentRow.DefaultCellStyle.BackColor = Color.Khaki;
                    ArticleDataGridView.Rows[e.RowIndex].Cells["Read"].Value = false;
                }
                //mark as read
                else 
                {
                    //Grid.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    ArticleDataGridView.Rows[e.RowIndex].Cells["Read"].Value = true;
                    WebBrowser.Url = new Uri(Grid.CurrentRow.Cells["Link"].Value.ToString());
                }

            }
            //the user has selected a column besides the checkbox
            else
            {

                //Grid.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                Grid.CurrentRow.Cells["Read"].Value = true;
                WebBrowser.Url = new Uri(Grid.CurrentRow.Cells["Link"].Value.ToString());
            }


           
        }








    }
}
