using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TextBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XMLFileForCPU.xml");
            XmlElement xRoot = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRoot)
            {
                listBox1.Items.Add(xnode.Name);
            }

            XmlDocument xDocA = new XmlDocument();
            xDoc.Load("XMLFileForArticle.xml");
            XmlElement xRootA = xDoc.DocumentElement;

            foreach (XmlElement xnode in xRootA)
            {
                listBox2.Items.Add(xnode.Name);
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var form = new Form2() { CPU = new CPU() };
            form.ShowDialog(this);
            if (form.flag == 1)
            {
                listBox1.Items.Add(form.CPU.Name_of_CPU);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox1.Items.Remove(item);
            CPU.RemoveItems(Convert.ToString(item), true);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form = new Form3() { Article = new Articles() };
            form.ShowDialog(this);
            if (form.flag == 1)
            {
                listBox2.Items.Add(form.Article.Head_line);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var item = listBox2.SelectedItem;
                listBox2.Items.Remove(item);
            CPU.RemoveItems(Convert.ToString(item), false);
        }
    }
}
