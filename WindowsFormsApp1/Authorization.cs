using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{

    public partial class Authorization : Form
    {
        /*const*/ string docPath = Path.Combine(Application.StartupPath, "Pass.txt");

        public Authorization()
        {
            InitializeComponent();
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration form3 = new Registration(docPath);
            form3.ShowDialog();
            if (form3.DialogResult == DialogResult.OK) Start();
            Hide();
        }

        void Start()
        {
            this.DialogResult = DialogResult.OK;
            NewsMain form2 = new NewsMain();
            form2.Show();
        
        }

        // расшифрование пары логин/пароль
        string Decryption(string str)
        {
            StringBuilder strB = new StringBuilder(str);
            for (int i = 0; i < strB.Length; i++)
                strB[i] = (char)(strB[i] - 2);

            return strB.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewsMain form1 = new NewsMain();
            form1.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string login;
            string pasword;

            if (File.Exists(docPath))
            {
                string[] lines = File.ReadAllLines(docPath, Encoding.Default);
                foreach (string line in lines)
                {
                    string[] linesDec = Decryption(line).Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    login = linesDec[0];
                    pasword = linesDec[1];

                    if (login.ToLower() == tbxLogin.Text.ToLower() && pasword == tbxPasword.Text) Start();
                }
            }

            MessageBox.Show("Такого логина или пароля не существует. \n Повторите ввод или зарегистрируйтесь!");
        }

        private void tbxPasword_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
