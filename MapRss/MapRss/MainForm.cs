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

        private void FeedTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView currentTreeView = sender as TreeView;
            string selectedNode = currentTreeView.SelectedNode.Text;
            List<Article> currentArticles = currentUser.GetUserArticles(selectedNode);
            //ArticleDataGridView.DataSource = currentArticles;

            DataTable dt = new DataTable();
            dt.Columns.Add("Read", Type.GetType("System.Boolean"));
            dt.Columns.Add("Title");
            dt.Columns.Add("Description");
            dt.Columns.Add("Date");
            dt.Columns.Add("Link");
            dt.Columns.Add("Location");
            DataRow dr;
            foreach (var article in currentArticles)
            {
                dr = dt.NewRow();
                dr["Read"] = article.Read;
                dr["Title"] = article.Title.ToString();
                dr["Description"] = article.Description.ToString();
                dr["Date"] = article.Date.ToShortDateString();
                dr["Link"] = article.Link.ToString();
                dr["Location"] = article.Location.ToString();
                dt.Rows.Add(dr);
            }
            ArticleDataGridView.DataSource = dt;
            ArticleDataGridView.AllowUserToAddRows = false;
            ArticleDataGridView.AllowUserToDeleteRows = false;
            ArticleDataGridView.DefaultCellStyle.BackColor = Color.Khaki;
            ArticleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ArticleDataGridView.Columns["Title"].ReadOnly = true;
            ArticleDataGridView.Columns["Description"].ReadOnly = true;
            ArticleDataGridView.Columns["Date"].ReadOnly = true;
            ArticleDataGridView.Columns["Link"].ReadOnly = true;
            ArticleDataGridView.Columns["Location"].ReadOnly = true;
            ArticleDataGridView.Columns["Read"].SortMode = DataGridViewColumnSortMode.NotSortable;
            ArticleDataGridView.Columns["Title"].SortMode = DataGridViewColumnSortMode.NotSortable;
            ArticleDataGridView.Columns["Description"].SortMode = DataGridViewColumnSortMode.NotSortable;
            ArticleDataGridView.Columns["Date"].SortMode = DataGridViewColumnSortMode.NotSortable;
            ArticleDataGridView.Columns["Link"].SortMode = DataGridViewColumnSortMode.NotSortable;
            ArticleDataGridView.Columns["Location"].SortMode = DataGridViewColumnSortMode.NotSortable;




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
                    Grid.CurrentRow.DefaultCellStyle.BackColor = Color.Khaki;
                    ArticleDataGridView.Rows[e.RowIndex].Cells["Read"].Value = false;
                }
                //mark as read
                else 
                {
                    Grid.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                    ArticleDataGridView.Rows[e.RowIndex].Cells["Read"].Value = true;
                    WebBrowser.Url = new Uri(Grid.CurrentRow.Cells["Link"].Value.ToString());
                }

            }
            //the user has selected a column besides the checkbox
            else
            {

                Grid.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                Grid.CurrentRow.Cells["Read"].Value = true;
                WebBrowser.Url = new Uri(Grid.CurrentRow.Cells["Link"].Value.ToString());
            }


           
        }








    }
}
