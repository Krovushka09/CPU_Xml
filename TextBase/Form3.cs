using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBase
{
    public partial class Form3 : Form
    {
        public int flag = 0;
        public Articles Article { get; set; }
        public Form3()
        {
            InitializeComponent();
            comboBox1.Items.Add("Новинки");
            comboBox1.Items.Add("Старые мощные процессоры");
            comboBox1.Items.Add("Бюджетные");
            comboBox1.Items.Add("Среднего класса");
            comboBox1.Items.Add("Дорогие");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                switch(comboBox1.SelectedItem)
                {
                    case "Новинки":
                        Article.Type_of_articles = Articles_Type.New; ;
                        break;
                    case "Старые мощные процессоры":
                        Article.Type_of_articles = Articles_Type.Old_but_powerful;
                        break;
                    case "Бюджетные":
                        Article.Type_of_articles = Articles_Type.Budgetary;
                        break;
                    case "Среднего класса":
                        Article.Type_of_articles = Articles_Type.Midddle_price;
                        break;
                    case "Дорогие":
                        Article.Type_of_articles = Articles_Type.Over_price;
                        break;
                }
                Article.Head_line = textBox1.Text;
                Article.Publication_date = DateTime.Now;
                Article.Articlec_text = richTextBox1.Text;
                Articles.ArticlToXML(Article.Head_line, Article.Publication_date, Article.Type_of_articles, Article.Articlec_text);
                flag = 1;
                Close();
            }
            catch(Exception er)
            {
                MessageBox.Show("Введенные вами значения некорректны. Попробуйте ввести их еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
