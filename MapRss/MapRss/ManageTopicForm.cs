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

            string topicName = textBoxTopic.Text;

            if (null != topicName && 0 < topicName.Length)
            {
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

            if (string.IsNullOrWhiteSpace(textBoxKeyword.Text))
            {
                MessageBox.Show("Please input a keyword.", "Empty Keyword Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Add keyword to checked list box
            checkedListBoxKeywords.Items.Add(textBoxKeyword.Text);

            //Get topic and add keyword to it
            string topicName = comboBoxTopics.SelectedItem as string;

            Topic selectedTopic = m_user.GetTopic(topicName);

            if (null != selectedTopic)
            {
                selectedTopic.Keyword.Add(textBoxKeyword.Text);
            }
        }

        private void buttonDeleteKeywords_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void buttonDeleteTopic_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
