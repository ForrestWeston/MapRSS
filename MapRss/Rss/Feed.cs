using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Rss
{
    class Feed
    {
        #region Properties

        public string Title { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
        public string Language { get; set; }
        public string PublishDate { get; set; }
        public DateTime LastBuildDate { get; set; }
        private XmlTextReader RssReader { get; set; }
        private XmlDocument RssDocument { get; set; }
        private XmlNode NodeRss { get; set; }
        private XmlNode NodeChannel { get; set; }
        private XmlNode NodeItem { get; set; }
        private ListViewItem RowNews { get; set; }

        #endregion
        #region Constructors

        public Feed(string RssUrl)
        {
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
            for(var i = 0; i < NodeRss.ChildNodes.Count; i++)
                if (NodeRss.ChildNodes[i].Name == "channel")
                    NodeChannel = NodeRss.ChildNodes[i];

            //FW: These are required (i think), so this should never throw null exception, but lets check anyways
            var titleElement = NodeChannel["title"];
            if (titleElement != null) Title = titleElement.InnerText;

            var descElement = NodeChannel["description"];
            if (descElement != null) Description = descElement.InnerText;

            var linkElement = NodeChannel["link"];
            if (linkElement != null) Link = linkElement.InnerText;

            var langElement = NodeChannel["language"];
            if (langElement != null) Language = langElement.InnerText;
        }

        #endregion
    }
        
}
