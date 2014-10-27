using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #endregion

    }
}
