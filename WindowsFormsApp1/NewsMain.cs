using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication309.Controls;

namespace WindowsFormsApp1
{
    [Serializable]

    public partial class NewsMain : Form
    {
        private News news;

        public NewsMain()
        {
            InitializeComponent();

            news = new News();
            Build();
            
        }

        private void Build()
        {
            pnMain.Controls.Clear();
            var items = news.Items;
            foreach (var item in items)
                new NewsItemPanel { Parent = pnMain }.Build(item);
        }

        private void NewsMain_Load(object sender, EventArgs e)
        {

        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            SearchText();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchText()
        {
            string text = (tbxSearch.Text).ToLower();
            pnMain.Controls.Clear();
            foreach (var item in news.Items)
            {
                var query = item.Description.Split(new string[] { text }, StringSplitOptions.None);
                if (query.Length > 1)
                {
                    new NewsItemPanel { Parent = pnMain }.Build(item);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Authorization form2 = new Authorization();
            form2.Show();
            Hide();
        }

        //private void SortbyDate()
        //{
        //    List<string[]> people = new List<string[]>();
        //    people.Add(new string[] { "Иван", "1980" });
        //    people.Add(new string[] { "Яна", "1987" });
        //    people.Add(new string[] { "Михаил", "1979" });
        //    people.Add(new string[] { "Анна", "1992" });

        //    class YearComparer : IComparer<string[]>
        //{
        //    public int Compare(string[] o1, string[] o2)
        //    {
        //        int a = Convert.ToInt32(o1[1]);
        //        int b = Convert.ToInt32(o2[1]);

        //        if (a > b)
        //        {
        //            return 1;
        //        }
        //        else if (a < b)
        //        {
        //            return -1;
        //        }

        //        return 0;
        //    }
        //}
        //YearComparer yc = new YearComparer();

        //people.Sort(yc);

        //OutputList(people, "Список после сортировки по году рождения");

        //foreach (var item in news.Items)
        //{
        //    var query = item.PubDate.Split(new string[] { text }, StringSplitOptions.None);
        //    if (query.Length > 1)
        //    {
        //        new NewsItemPanel { Parent = pnMain }.Build(item);
        //    }
    }
        }

    //private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        
        //    // добавляем набор элементов
        //    //Sort.Items.AddRange(new string[] { "По дате", "По просмотрам" });

        //    //string selectedState = Sort.SelectedItem.ToString();
        //    //MessageBox.Show(selectedState);
        //}
    

