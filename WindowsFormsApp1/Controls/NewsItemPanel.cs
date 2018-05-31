using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;


namespace WindowsFormsApplication309.Controls
{
    [Serializable]

    public partial class NewsItemPanel : UserControl
    {
        public NewsItemPanel()
        {
            InitializeComponent();
        }

        public void Build(NewsItem item)
        {
            lbTime.Text = item.PubDate;
            lbTitle.Text = item.Link;
            tbContent.Text = item.Title;
            pbImage.ImageLocation = "https://www.google.ru/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png"; //item.Item_id;
        }

        private void tbContent_TextChanged(object sender, System.EventArgs e)
        {
 
        }

        private void lbTitle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Browser Browser = new Browser();
            Browser.Show();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.BackColor = btnSave.BackColor != Color.Red ? Color.Red : Color.Silver;
        }
    }
}
