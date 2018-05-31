using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    [Serializable]

    class NewsState
    {
        public partial class NewsItemPanel { }
        public class NewsItem { }
        public partial class News { }

        public static NewsState Instance { get; private set; }

        public static void CreateInstance()
        {
            Instance = new NewsState();
        }

        public static void LoadInstance(string fileName)
        {

            using (var st = File.OpenRead(fileName))
                Instance = (NewsState)new BinaryFormatter().Deserialize(st);
        }

        public static void SaveInstance(string fileName)
        {
            using (var f = File.OpenWrite(fileName))
                new BinaryFormatter().Serialize(f, Instance);
        }
    }
}
