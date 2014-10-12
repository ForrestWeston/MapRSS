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

        #region Properties

        public readonly List<Article> Articles
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

        #endregion

    }
}
