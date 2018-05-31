using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp1
{
    [Serializable]

    public class NewsItem
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public string Item_id { get; set; }
        public string PubDate { get; set; }
        public string Description { get; set; }

    }


}
