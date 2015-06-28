using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;

// http://heathesh.com/post/2010/05/10/A-simple-way-to-read-an-RSS-feed-using-C.aspx

namespace LogSupportSystem
{
    /// <summary>
    /// RSS feed item entity
    /// </summary>
    public class RssFeedItem
    {
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the link
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Gets or sets the item id
        /// </summary>
        public int ItemId { get; set; }

        /// <summary>
        /// Gets or sets the publish date
        /// </summary>
        public DateTime PublishDate { get; set; }

        /// <summary>
        /// Gets or sets the channel id
        /// </summary>
        public int ChannelId { get; set; }
    }

    public static class RSSManager
    {
        /// <summary>
        /// Reads the relevant Rss feed and returns a list off RssFeedItems
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public static List<RssFeedItem> ReadFeed(string url)
        {
            //create a new list of the rss feed items to return
            List<RssFeedItem> rssFeedItems = new List<RssFeedItem>();

            //create an http request which will be used to retrieve the rss feed
            HttpWebRequest rssFeed = (HttpWebRequest)WebRequest.Create(url);

            //use a dataset to retrieve the rss feed
            using (DataSet rssData = new DataSet())
            {
                //read the xml from the stream of the web request
                rssData.ReadXml(rssFeed.GetResponse().GetResponseStream());

                //loop through the rss items in the dataset and populate the list of rss feed items
                foreach (DataRow dataRow in rssData.Tables["item"].Rows)
                {
                    rssFeedItems.Add(new RssFeedItem
                    {
                        ChannelId = Convert.ToInt32(dataRow["channel_Id"]),
                        Description = Convert.ToString(dataRow["description"]),
                        //ItemId = Convert.ToInt32(dataRow["item_Id"]),
                        Link = Convert.ToString(dataRow["link"]),
                        //PublishDate = Convert.ToDateTime(dataRow["pubDate"]),
                        Title = Convert.ToString(dataRow["title"])
                    });
                }
            }

            //return the rss feed items
            return rssFeedItems;
        }
    }
}
