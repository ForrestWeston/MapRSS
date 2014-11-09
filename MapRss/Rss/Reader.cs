using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Rss
{
    public class Reader
    {
        private Dictionary<string, Feed> m_feeds = new Dictionary<string, Feed>();

        #region Properties

        #endregion

        #region Constructors

        public Reader()
        {

        }

        #endregion

        #region Helper Methods
        public string GetFeedTitle(string url)
        {
            var title = m_feeds.First(t => t.Key == url);
            return title.Value.Title;
        }

        private bool Save(Stream s, string fileName)
        {
            //Create appropriate settings for Xml file
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.NewLineChars = "\n";
            settings.NewLineOnAttributes = false;
            settings.Indent = true;

            //A XmlWriter with the settings created and the stream with the file
            XmlWriter w = XmlWriter.Create(s, settings);

            //Make sure writer isn't null
            if (null == w)
            {
                return false;
            }

            w.WriteStartDocument();

            //Write starting element and then call the xml writer method in the feed class, then end the 
            //document
            w.WriteStartElement(fileName);

            foreach (Feed feed in m_feeds.Values)
            {
                feed.WriteXml(w);
            }

            w.WriteEndElement();
            w.WriteEndDocument();

            //Dispose of the writer
            w.Dispose();

            return true;
        }

        private bool Load(Stream s, string fileName)
        {
            XmlDocument doc = new XmlDocument();

            //Try to load the file
            try
            {
                doc.Load(s);
            }
            catch (XmlException)
            {
                return false;
            }

            //Create new diction to add feeds to 
            m_feeds = new Dictionary<string, Feed>();

            XmlElement root = doc.DocumentElement;

            //This allows for loading multiple feeds
            foreach (XmlNode feed in root.GetElementsByTagName("Feed"))
            {
                XmlNode name = feed.SelectSingleNode("//Title");
                XmlNode url = feed.SelectSingleNode("//Link");

                if(null != name && null != url)
                {
                    m_feeds.Add(name.InnerText, new Feed(url.InnerText));
                }                
            }

            return true;
        }
        #endregion


        #region Methods

        public void RefreshArticles()
        {

        }

        public void AddFeed(string url, string name)
        {
            m_feeds.Add(name, new Feed(url));
        }

        //This needs to be revised. It is currently functioning this way for testing and needs to get a feed that is specified
        public string GetFeedUrl()
        {
            string url = "";

            //if(0 < m_feeds.Count)
            //{
            //    url = m_feeds[0].Articles[0].Link;
            //}

            return url;
        }

        public List<Article> GetArticles(string name)
        {
            return m_feeds[name].Articles;
        }

        //Accepts a file name and then creates a stream and passing it to the save method that actually saves
        //Will save to default file if no name is input.
        public void Save(string fileName = "Default")
        {
            FileStream fs = new FileStream(fileName + ".xml", FileMode.Create, FileAccess.Write);
            Save(fs, fileName);
            fs.Dispose();
        }

        //Accepts a file name and then creates a stream, passing it to the load method that will load
        //Will load from default file if no name is input
        public void Load(string fileName = "Default")
        {
            FileStream fs = new FileStream(fileName + ".xml", FileMode.Open, FileAccess.Read);
            Load(fs, fileName);
            fs.Dispose();
        }

        public String[] GetFeedNames()
        {
            return m_feeds.Keys.ToArray();
        }

        #endregion

    }
}
