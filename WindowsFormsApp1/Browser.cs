using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    [Serializable]

    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            //WebClient client = new WebClient();
            //var bytes = client.DownloadData("description");
            //var stream = new System.IO.MemoryStream(bytes);

            //Image url = Image.FromStream(stream); // 1 способ

            Browser1.Navigate("url");
        }


    }
}
