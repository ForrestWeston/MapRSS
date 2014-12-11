using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapRss
{
    public class Topic
    {
        #region Member Variables

        private string m_name;
        private List<string> m_keywords;

        #endregion

        #region Properties

        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        public List<string> Keyword
        {
            get
            {
                return m_keywords;
            }
            set
            {
                m_keywords = value;
            }
        }

        #endregion

        #region Constructors

        public Topic(string name)
        {
            Name = name;
            m_keywords = new List<string>();
        }

        #endregion

        #region Methods

        #endregion
    }
}
