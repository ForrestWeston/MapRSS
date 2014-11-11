using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MapRss
{
    public class User
    {
        private string m_username = null;
        private string m_password = null;
        private int m_refresh = 60;//default
        private List<Feed> m_feeds = new List<Feed>();

        public string Username
        {
            get { return m_username; }
            set { m_username = value; }
        }
        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }
        public int Refresh
        {
            get { return m_refresh; }
            set { m_refresh = value; }
        }
        public List<Feed> MyFeed
        {
            get { return m_feeds; }
            set { m_feeds = value; }
        }

        public User()
        {

        }

        public User(string userName, string password)
        {
            if(false == LoadUser(userName, password))
            {
                throw new Exception("User not found.");
            }
        }

        public void AddUserFeed(Feed newFeed)
        {
            m_feeds.Add(newFeed);
        }
        public void RemoveUserFeed(Feed oldFeed)
        {
            m_feeds.Remove(oldFeed);
        }

        public void SaveUser()
        {
            if(Username == null)
            {
                return;
            }
            string filename = Username + ".xml";

            //Create appropriate settings for Xml file
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.NewLineChars = "\n";
            settings.NewLineOnAttributes = false;
            settings.Indent = true;

            using(XmlWriter w = XmlWriter.Create(filename, settings))
            {
                if (w == null) { return; }

                w.WriteStartDocument();
                //Write starting element and then call the xml writer method in the feed class, then end the 
                //document
                w.WriteStartElement(Username);
                w.WriteAttributeString("Password", Password);
                w.WriteAttributeString("Refresh", Refresh.ToString());
                foreach(Feed feed in m_feeds)
                {
                    feed.WriteXml(w);
                }

                w.WriteEndElement();
                w.WriteEndDocument();
                
            }

        }

        public bool LoadUser(string userName, string password)
        {
            XmlDocument doc = new XmlDocument();

            //Try to load the file
            try
            {
                doc.Load(userName + ".xml");
            }
            catch (XmlException)
            {
                return false;
            }

            //Create new diction to add feeds to 
            MyFeed = new List<Feed>();

            XmlElement root = doc.DocumentElement;

            if (password == root.GetAttribute("Password"))
            {
                //Update username/password
                Username = userName;
                Password = password;
                Refresh = int.Parse(root.GetAttribute("Refresh"));

                //This allows for loading multiple feeds
                foreach (XmlNode feed in root.GetElementsByTagName("Feed"))
                {
                    XmlNode name = feed.SelectSingleNode("//Name");
                    XmlNode url = feed.SelectSingleNode("//Link");

                    if (null != name && null != url)
                    {
                        MyFeed.Add(new Feed(url.InnerText, name.InnerText));
                    }
                }
            }
            else
            {
                throw new Exception("Incorrect password.");
            }

            return true;
        }

        public void CreateUser()
        {
            if(Username != null)
            {
                MessageBox.Show("Logout before creating new user", "Login-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CreateUserForm createNewUser = new CreateUserForm(this);
                createNewUser.Show();
                createNewUser.Focus();
            }
        }
        public void EditUser()
        {
            if (Username == null)
                MessageBox.Show("You must login to edit user settings", "Login-error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                EditUserForm editUser = new EditUserForm(this);
                editUser.Show();
                editUser.Focus();
            }
        }
        public void AddFeedDialog()
        {
            if(Username == null)
                MessageBox.Show("Must login to save changes", "Login-Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
           
            ManageSubscriptionForm userSubscription = new ManageSubscriptionForm(this);
            userSubscription.Show();
            userSubscription.Focus();
        }

    }
}
