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

        }

        private void removeFeed_Click(object sender, EventArgs e)
        {

        }

        //This will need to load from the XML save file to actually populate the topic area
        private TreeView PopulateTopicView()
        {
            TreeView topics = new TreeView();

            TreeNode[] topicAreas = new TreeNode[] { new TreeNode("Sports"), new TreeNode("Heath")};

            TreeNode root = new TreeNode("Topics", topicAreas);

            topics.Nodes.Add(root);

            return topics;
        }

        //This will need to load from the XML save file to actually populate the topic area
        private TreeView PopulateFeedView()
        {
            TreeView feed = new TreeView();

            TreeNode[] topicAreas = new TreeNode[] { new TreeNode("NY Times"), new TreeNode("US News and World Report") };

            TreeNode root = new TreeNode("Feed", topicAreas);

            feed.Nodes.Add(root);

            return feed;
        }
    }
}
