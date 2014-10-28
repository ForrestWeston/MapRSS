using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rss
{
    public class Article
    {
        #region Properties

        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }

        #endregion

        #region Constructors

        public Article(string title, DateTime date, string link, string description)
        {
            Title = title;
            Date = date;
            Link = link;
            Description = description;
            Location = FindLocation();
        }

        #endregion

        #region Helper Methods

        private string FindLocation()
        {
            return String.Empty;
        }

        #endregion


    }
}
