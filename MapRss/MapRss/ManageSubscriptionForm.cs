using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Equin.ApplicationFramework;

namespace MapRss
{
    public partial class ManageSubscriptionForm : Form
    {
        User editUser;
        public ManageSubscriptionForm(User user)
        {
            editUser = user;
            InitializeComponent();
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            SubscriptionDataGridView.Columns.Add(chk);
            chk.HeaderText = "Select";
            chk.Name = "chk";
            SubscriptionDataGridView.DataSource = new BindingListView<Feed>(editUser.Feed);
        }

        private void ManageAcceptButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ManageFeedAddButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(ManageURLTextBox.Text))
                MessageBox.Show("Please Provide a RSS URL", "URL-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                string URL = ManageURLTextBox.Text;
                Feed newFeed = new Feed(URL);
                editUser.AddUserFeed(newFeed);
                SubscriptionDataGridView.DataSource = new BindingListView<Feed>(editUser.Feed);
                ManageURLTextBox.Text = String.Empty;
                ManageURLTextBox.Focus();
            }
        }

        private void ManageDeleteFeedButton_Click(object sender, EventArgs e)
        {
            int i = 0;
            List<Feed> feedsToDelete = new List<Feed>();
            foreach (DataGridViewRow item in SubscriptionDataGridView.Rows)
            {
                bool IsBool = false;
                bool.TryParse(item.Cells[0].EditedFormattedValue.ToString(), out IsBool);
                if (IsBool) //<--Where: The ColumnIndex of the DataGridViewCheckBoxCell
                {
                    feedsToDelete.Add(editUser.Feed.ElementAt(i));
                }
                i++;
            }
            editUser.RemoveUserFeed(feedsToDelete);
            SubscriptionDataGridView.DataSource = new BindingListView<Feed>(editUser.Feed);
        }


    }
}
