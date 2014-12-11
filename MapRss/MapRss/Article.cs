using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;
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
        public double latitude { get; set; }
        public double longitude { get; set; }


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
            String location;
            string filePath = "../../Resources/uslocations.csv";
            StreamReader sr = new StreamReader(filePath);
            var lines = new List<string[]>();
            int Row = 0;
            while (!sr.EndOfStream)
            {
                string[] Line = sr.ReadLine().Split(',');
                lines.Add(Line);
                Row++;
            }
            int i = 1;
            string city = null;
            string state = null;
            while (i < Row)
            {
                if (this.Description.Contains(lines[i][3]) || this.Title.Contains(lines[i][3]))
                {
                    city = lines[i][3];
                    state = lines[i][2];
                    latitude = Convert.ToDouble(lines[i][5]);
                    longitude = Convert.ToDouble(lines[i][6]);
                    break;
                }

                if (this.Description.Contains(lines[i][2]) || this.Title.Contains(lines[i][2]))
                {
                    state = lines[i][2];
                    city = lines[i][3];
                    latitude = Convert.ToDouble(lines[i][5]);
                    longitude = Convert.ToDouble(lines[i][6]);
                    break;
                }
                i++;
            }
            //create location string
            if (city != null)
            {
                string m_location = city + ", " + state;
                return m_location;
            }
            else
            {
                return String.Empty;
            }            

        }

        #endregion


    }
}
