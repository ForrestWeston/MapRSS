﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MapRss
{
    public class Feed
    {
        #region Member Variables

        #endregion

        #region Properties

        public string Nickname { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Language { get; set; }
        public string PublishDate { get; set; }
        public List<Article> Articles = new List<Article>();
        public DateTime LastBuildDate { get; set; }
        private XmlTextReader RssReader { get; set; }
        private XmlDocument RssDocument { get; set; }
        private XmlNode NodeRss { get; set; }
        private XmlNode NodeChannel { get; set; }
        private XmlNode NodeItem { get; set; }
        private ListViewItem RowNews { get; set; }


        #endregion
        #region Constructors

        public Feed(string RssUrl, string nickname)
        {
            Nickname = nickname;
            //Make sure the string isn't null
            if (null != RssUrl)
            {
                Link = RssUrl;

                //FW: Create new XmlTextReader from the provided RssUrl i.e the rss feed
                RssReader = new XmlTextReader(RssUrl);
                RssDocument = new XmlDocument();

                //FW: populate the XmlDocument 
                RssDocument.Load(RssReader);

                //FW: loop through all rss tags in RssDocument and create 'rss' nodes for them 
                for (var i = 0; i < RssDocument.ChildNodes.Count; i++)
                    if (RssDocument.ChildNodes[i].Name == "rss")
                        NodeRss = RssDocument.ChildNodes[i];

                //FW: loop through all channel tags in NodeRss and create 'channel' nodes for them 
                for (var i = 0; i < NodeRss.ChildNodes.Count; i++)
                    if (NodeRss.ChildNodes[i].Name == "channel")
                        NodeChannel = NodeRss.ChildNodes[i];

                //FW: These are required (i think), so this should never throw null exception, but lets check anyways
                var titleElement = NodeChannel["title"];
                if (titleElement != null) Title = titleElement.InnerText;

                var descElement = NodeChannel["description"];
                if (descElement != null) Description = descElement.InnerText;

                var langElement = NodeChannel["language"];
                if (langElement != null) Language = langElement.InnerText;

                if (null != NodeChannel["item"])
                {
                    //Get all articles
                    foreach (XmlNode item in RssDocument.SelectNodes("//channel/item"))
                    {                        
                        string title = item.SelectSingleNode("title").InnerText;
                        DateTime date = DateTime.Parse(item.SelectSingleNode("pubDate").InnerText);
                        string link = item.SelectSingleNode("link").InnerText;
                        string description = item.SelectSingleNode("description").InnerText;

                        Articles.Add(new Article(title, date, link, description));
                    }
                }
            }
        }

        #endregion

        #region Methods

        //Write Xml for the feed contents
        public void WriteXml(XmlWriter w)
        {
            w.WriteStartElement("Feed");

            //Write contents of the feed
            w.WriteStartElement("Name");
            w.WriteValue(Nickname);
            w.WriteEndElement();
            w.WriteStartElement("Title");
            w.WriteValue(Title);
            w.WriteEndElement();
            w.WriteStartElement("Description");
            w.WriteValue(Description);
            w.WriteEndElement();
            w.WriteStartElement("Link");
            w.WriteValue(Link);
            w.WriteEndElement();
            w.WriteStartElement("Language");
            w.WriteValue(Language);
            w.WriteEndElement();
            w.WriteStartElement("PublishDate");
            w.WriteValue(PublishDate);
            w.WriteEndElement();

            w.WriteEndElement();
        }

        #endregion
    }

}
