using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.IO;

namespace MapRss
{
    public class User : INotifyPropertyChanged
    {
        private string m_username = null;
        private string m_password = null;
        private int m_refresh = 60;//default
        private ObservableCollection<Feed> m_feeds = new ObservableCollection<Feed>();
        private static System.Timers.Timer updateTimer;

        public User()
        {
            m_feeds.CollectionChanged += m_feeds_CollectionChanged;
            updateTimer = new System.Timers.Timer();    //init new timer var to update user feeds
            updateTimer.Elapsed += updateTimer_Elapsed; //event that is called when the interval elapses         
            updateTimer.Interval = Refresh * 60 * 1000; //refresh is specified in min so this conversion is made: Refresh * 60 * 1000
            updateTimer.Start();
 
        }

        void updateTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            foreach (var f in Feed)
                f.Update();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void m_feeds_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var newfeed = sender as ObservableCollection<Feed>;
            if(e.Action == NotifyCollectionChangedAction.Add)
            {
                if (PropertyChanged != null)
                    PropertyChanged(newfeed.Last(), null);
            }
            if(e.Action == NotifyCollectionChangedAction.Remove)
            {
                throw new NotImplementedException();
            }
        }

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
        public ObservableCollection<Feed> Feed
        {
            get { return m_feeds; }
        }

        public void AddUserFeed(Feed newFeed)
        {
            m_feeds.Add(newFeed);
        }
        public void RemoveUserFeed(Feed oldFeed)
        {
            m_feeds.Remove(oldFeed);
        }
        public bool AuthenticateUser(string username, string password)
        {
            XmlDocument doc;
            FileStream fs;
            try
            {
                fs = new FileStream(username + ".xml", FileMode.Open, FileAccess.Read);
            }
            catch(FileNotFoundException)
            {

                return false;
            }
            doc = new XmlDocument();
            try
            {
                doc.Load(fs);
            }
            catch(XmlException)
            {
                fs.Close();
                return false;
            }
            XmlElement root = doc.DocumentElement;

            XmlNodeList usrsetting = root.GetElementsByTagName("Username");
            var usrname = usrsetting.Item(0).InnerText;

            usrsetting = root.GetElementsByTagName("Password");
            var usrpswrd = usrsetting.Item(0).InnerText;


            if (usrname != username || usrpswrd != password)
            {
                fs.Close();
                return false;
            }
            fs.Close();
            return true;

        }
        public void SaveUser()
        {
            if(Username == null)
            {
                return;
            }
            string filename = Username + ".xml";
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.NewLineChars = "\n";
            settings.NewLineOnAttributes = false;
            settings.Indent = true;

            XmlWriter w = XmlWriter.Create(fs, settings);
            w.WriteStartDocument();

            w.WriteStartElement(filename);

            w.WriteStartElement("UserSetting");

            w.WriteStartElement("Username");
            w.WriteValue(Username);
            w.WriteEndElement();

            w.WriteStartElement("Password");
            w.WriteValue(Password);
            w.WriteEndElement();

            w.WriteStartElement("Refresh");
            w.WriteValue(Refresh);
            w.WriteEndElement();

            w.WriteEndElement();//end user settings 

            foreach (Feed feed in m_feeds)
            {
                w.WriteStartElement("Feed");

                w.WriteStartElement("Title");
                w.WriteValue(feed.Title);
                w.WriteEndElement();
                w.WriteStartElement("Description");
                w.WriteValue(feed.Description);
                w.WriteEndElement();
                w.WriteStartElement("Link");
                w.WriteValue(feed.Link);
                w.WriteEndElement();
                w.WriteStartElement("Language");
                w.WriteValue(feed.Language);
                w.WriteEndElement();
                w.WriteStartElement("PublishDate");
                w.WriteValue(feed.PublishDate);
                w.WriteEndElement();

                w.WriteEndElement();//end Feed

                
            }

            w.WriteEndElement();//End Filename
            w.WriteEndDocument();
            w.Dispose();
            fs.Close();
            
            
            

        }
        public void LoadUser()
        {
            if (Username == null)
                return;

            string filename = Username + ".xml";
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);

            XmlDocument doc = new XmlDocument();

            try
            {
                doc.Load(fs);
            }
            catch(XmlException)
            {
                return;
            }

            XmlElement root = doc.DocumentElement;
            XmlNodeList feeds = root.GetElementsByTagName("Feed");
            foreach (XmlNode feed in feeds)
            {
                XmlNodeList feedAttributes = feed.ChildNodes;
                string url = feedAttributes.Item(2).InnerText;
                //XmlNode url = feed.SelectSingleNode("//Link");

                if ( url != null)
                    Feed.Add(new Feed(url));
            }
            fs.Close();

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
        public void LoginUser()
        {
            if (Username != null)
            {
                MessageBox.Show("Logout before creating new user", "Login-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                LoginUserForm loginUser = new LoginUserForm(this);
                loginUser.Show();
                loginUser.Focus();
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
        public List<Article> GetUserArticles(string name)
        {
            var userArticles = m_feeds.Single(a => a.Title == name);
            if (userArticles != null)
                return userArticles.Articles;
            else
                return null; //should NEVER HAPPEN how would select an item from the treeview thats not there?
        }


        
    }
}
