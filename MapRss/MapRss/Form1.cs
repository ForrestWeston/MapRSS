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
    public partial class Form1 : Form
    {
        TreeView m_treeViewTopics;
        TreeView m_treeViewFeeds;
        Rss.Reader rssReader = new Rss.Reader();

        public Form1()
        {
            InitializeComponent();


            m_treeViewTopics = PopulateTopicView();
            m_treeViewFeeds = PopulateFeedView();

            foreach (TreeNode node in m_treeViewFeeds.Nodes)
            {
                treeViewBase.Nodes.Add((TreeNode)node.Clone());
            }

            treeViewBase.ExpandAll();
        }

        private void Feed_Click(object sender, EventArgs e)
        {
            treeViewBase.Nodes.Clear();

            foreach (TreeNode node in m_treeViewFeeds.Nodes)
            {
                treeViewBase.Nodes.Add((TreeNode)node.Clone());
            }

            treeViewBase.ExpandAll();
        }

        private void Map_Click(object sender, EventArgs e)
        {

        }

        private void Topic_Click(object sender, EventArgs e)
        {
            treeViewBase.Nodes.Clear();

            foreach (TreeNode node in m_treeViewTopics.Nodes)
            {
                treeViewBase.Nodes.Add((TreeNode)node.Clone());
            }

            treeViewBase.ExpandAll();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void addFeed_Click(object sender, EventArgs e)
        {
            //Create new form to be used as popup entry method
            Form formUrl = new Form();
            formUrl.Location = new Point(Size.Width / 2, Size.Height / 2);
            formUrl.Text = "RSS URL";
            formUrl.ClientSize = new System.Drawing.Size(500, 150);

            //Create text and button
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Please enter URL:" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button add = new Button() { Text = "Add", Left = 350, Width = 100, Top = 70 };
            
            //Add event
            add.Click += (senderClick, eArg) => { formUrl.Close(); AddFeed(textBox.Text); };
            formUrl.Controls.Add(textBox);
            formUrl.Controls.Add(add);
            formUrl.Controls.Add(textLabel);
            formUrl.AcceptButton = add;
            formUrl.ShowDialog();
        }

        private void removeFeed_Click(object sender, EventArgs e)
        {

        }

        private void treeViewBase_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeView test = sender as TreeView;

            string name = test.SelectedNode.Text;

            List<Rss.Article> articles = rssReader.GetArticles(name);

            //each time a new feed is selected clear out exisitng info 
            listView1.Clear();
            // Set the view to show details.
            listView1.View = View.Details;
            listView1.FullRowSelect = false;
            listView1.Columns.Add("Title", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Description", -2, HorizontalAlignment.Left);

            foreach (Rss.Article article in articles)
            {
                LinkLabel link = new LinkLabel();
                link.Text = article.Title;
                ListViewItem item = new ListViewItem(link.Text);
                item.SubItems.Add(article.Description);
                item.SubItems.Add(article.Link);
                listView1.Items.Add(item);
                //TODO: pull images from rss and add them to this view using ImageList object 
            }
        }

        //This will need to load from the XML save file to actually populate the topic area
        private TreeView PopulateTopicView()
        {
            TreeView topics = new TreeView();

            //TreeNode[] topicAreas = new TreeNode[] { new TreeNode("Sports"), new TreeNode("Heath")};

            //TreeNode root = new TreeNode("Topics", topicAreas);

            //topics.Nodes.Add(root);

            return topics;
        }

        //This will need to load from the XML save file to actually populate the topic area
        private TreeView PopulateFeedView()
        {
            TreeView feed = new TreeView();

            //TreeNode[] topicAreas = new TreeNode[] { new TreeNode("NY Times"), new TreeNode("US News and World Report") };

            //TreeNode root = new TreeNode("Feed", topicAreas);

            //feed.Nodes.Add(root);

            return feed;
        }

        private void AddFeed(string url)
        {
            if(0 < url.Length)
            {
                rssReader.AddFeed(url, url);

                m_treeViewFeeds.Nodes.Add(new TreeNode(url));

                //This will just refresh the feed topics
                Feed_Click(null, null);

                //webBrowser1.Url = new Uri(rssReader.GetFeedUrl());
                //webBrowser1.Refresh();
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView selectedItem = sender as ListView;
            string articleUrl = selectedItem.FocusedItem.SubItems[2].Text;

            try
            {
                webBrowser1.Url = new Uri(articleUrl);
                webBrowser1.Refresh();
            }
            catch (Exception)
            {
                
                //ignore everything, e.g java script erros, and flash prompts, this will need to be fixed later 
            }
            
            
        }

    }
}
