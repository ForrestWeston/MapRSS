using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rss
{
    public class Reader
    {
        private List<Article> m_articles = new List<Article>();
        private List<Feed> m_feeds = new List<Feed>();

        #region Properties

        public List<Article> Articles
        {
            get
            {
                return m_articles;
            }
        }

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

        public void AddFeed(string url)
        {
            m_feeds.Add(new Feed(url));
        }

        //This needs to be revised. It is currently functioning this way for testing and needs to get a feed that is specified
        public string GetFeedUrl()
        {
            string url = "";

            if(0 < m_feeds.Count)
            {
                url = m_feeds[0].Link;
            }

            return url;
        }

        #endregion

    }
}
