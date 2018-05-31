using System.Collections.Generic;
using System.Net;
using System.IO;
using System.Text;
using System.Data;
using System;
using System.Linq;
using System.Collections;

namespace WindowsFormsApp1
{

     [Serializable]

    public partial class News
    {
      
        public News()
        {
            Items = GetNewsContent();
        }

        public List<NewsItem> Items { get; private set; }

        public static List<NewsItem> GetNewsContent(string NewsParameters = "")
        {

            List<NewsItem> Details = new List<NewsItem>();

            // httpWebRequest с API url
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://news.google.com/news?q=" + NewsParameters + "&output=rss");

            //Метод GET
            request.Method = "GET";

            //HttpWebResponse возврат результата
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();


            //Код состояния
            if (response.StatusCode == HttpStatusCode.OK)
            {

                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == "")
                    readStream = new StreamReader(receiveStream);
                else
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                //Get news data in json string

                string data = readStream.ReadToEnd();

                //Declare DataSet for put data in it.
                DataSet ds = new DataSet();
                StringReader reader = new StringReader(data);
                ds.ReadXml(reader);
                DataTable dtGetNews = new DataTable();

                if (ds.Tables.Count > 3)
                {
                    dtGetNews = ds.Tables["item"];

                    foreach (DataRow dtRow in dtGetNews.Rows)
                    {
                        NewsItem DataObj = new NewsItem();
                        DataObj.Title = dtRow["Title"].ToString();
                        DataObj.Link = dtRow["Link"].ToString();
                        DataObj.Item_id = dtRow["Item_id"].ToString();
                        DataObj.PubDate = dtRow["pubDate"].ToString();
                        DataObj.Description = dtRow["description"].ToString();
                        Details.Add(DataObj);
                    }

                }
            }


            //Return News array
            Details.RemoveAt(0);
            return Details;
        }

    }
}