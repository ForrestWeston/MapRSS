using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MapRss
{
    public class Article
    {
        #region Properties

        public bool Read { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public string Link { get; set; }
        public string Location { get; set; }


        #endregion

        #region Constructors

        public Article(string title, DateTime date, string link, string description, bool read=false)
        {
            string noHTML = Regex.Replace(description, @"<[^>]+>|&nbsp;", "").Trim();
            Title = title;
            Date = date;
            Link = link;
            Description = Regex.Replace(noHTML, @"\s{2,}", " ");
            Location = FindLocation();
            Read = read;
        }
        public Article() { }

        #endregion

        #region Helper Methods

        private string FindLocation()
        {
            return String.Empty;
        }

        #endregion


    }
}
