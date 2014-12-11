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
    public partial class ManageTopicForm : Form
    {
        private User m_user;

        public ManageTopicForm(User user)
        {
            InitializeComponent();

            m_user = user;

            foreach(Topic topic in user.Topic)
            {
                comboBoxTopics.Items.Add(topic.Name);
            }

            if (null == comboBoxTopics.SelectedItem && 0 < comboBoxTopics.Items.Count)
            {
                comboBoxTopics.SelectedIndex = 0;
            }
        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonNewTopic_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxTopic.Text))
            {
                MessageBox.Show("Please input a topic.", "Topic Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string topicName = textBoxTopic.Text;

                //Add item to combo box, create topic for user and clear the input text box
                comboBoxTopics.Items.Add(topicName);

                Topic topic = new Topic(topicName);
                m_user.AddTopic(topic);

                textBoxTopic.Clear();

                //Select the newly created item
                comboBoxTopics.SelectedIndex = comboBoxTopics.Items.Count - 1;
            }
        }

        private void selectedIndex_Changed(object sender, EventArgs e)
        {
            //Clear listbox items
            checkedListBoxKeywords.Items.Clear();

            //Get topic name and find topic
            string topicName = comboBoxTopics.SelectedItem as string;

            Topic selectedTopic = m_user.GetTopic(topicName);

            //Add all keywords to the existing list
            if(null != selectedTopic)
            {
                foreach(string keyword in selectedTopic.Keyword)
                {
                    checkedListBoxKeywords.Items.Add(keyword, false);
                }
            }
        }

        private void buttonAddKeyword_Click(object sender, EventArgs e)
        {
            if (null == comboBoxTopics.SelectedItem)
            {
                MessageBox.Show("Please add and select a topic prior to adding keywords to it.", "Empty Topic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(textBoxKeyword.Text))
            {
                MessageBox.Show("Please input a keyword.", "Empty Keyword Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Add keyword to checked list box
                checkedListBoxKeywords.Items.Add(textBoxKeyword.Text);

                //Get topic and add keyword to it
                string topicName = comboBoxTopics.SelectedItem as string;

                Topic selectedTopic = m_user.GetTopic(topicName);

                if (null != selectedTopic)
                {
                    selectedTopic.Keyword.Add(textBoxKeyword.Text);
                }

                //Clear textbox
                textBoxKeyword.Clear();
            }
        }

        private void buttonDeleteKeywords_Click(object sender, EventArgs e)
        {
            if(0 == comboBoxTopics.Items.Count)
            {
                MessageBox.Show("You must add topics before attempting to delete.", "Delete Empty Topic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Remove keyword from UI
                string[] keywordsDelete = checkedListBoxKeywords.CheckedItems.OfType<string>().ToArray();

                //Only process deletes if keywords were selected
                if (null != keywordsDelete && 0 < keywordsDelete.Length)
                {
                    foreach (string keyword in keywordsDelete)
                    {
                        checkedListBoxKeywords.Items.Remove(keyword);
                    }

                    //Get topic and remove keywords from it
                    string topicName = comboBoxTopics.SelectedItem as string;

                    Topic selectedTopic = m_user.GetTopic(topicName);

                    if (null != selectedTopic)
                    {
                        foreach (string keyword in keywordsDelete)
                        {
                            selectedTopic.Keyword.Remove(keyword);
                        }
                    }
                }
            }
        }

        private void buttonDeleteTopic_Click(object sender, EventArgs e)
        {
            if (0 == comboBoxTopics.Items.Count)
            {
                MessageBox.Show("You must add topics before attempting to delete.", "Delete Empty Topic Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //Remove topic from UI
                string topicString = comboBoxTopics.SelectedItem as string;
                comboBoxTopics.Items.Remove(comboBoxTopics.SelectedItem);

                //Remove topic from user
                Topic topicDelete = m_user.GetTopic(topicString);
                m_user.RemoveTopic(topicDelete);
            }
        }
    }
}
