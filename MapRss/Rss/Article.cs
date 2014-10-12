using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rss
{
    class Article
    {
        #region Properties

        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Author { get; set; }
        public string Location { get; set; }
        public string Contents { get; set; }

        #endregion

        #region Constructors

        public Article()
        {
            FindLocation();
        }

        #endregion

        #region Helper Methods

        private void FindLocation()
        {

        }

        #endregion


    }
}
