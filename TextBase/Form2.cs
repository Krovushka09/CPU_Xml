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
    public partial class Form2 : Form
    {

        public CPU CPU { get; set; }
        public int flag = 0;
        public Form2()
        {
            
            InitializeComponent();
            comboBox1.Items.Add(Vendor.AMD);
            comboBox1.Items.Add(Vendor.Intel);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        
        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem.ToString() == "AMD")
                {
                    CPU.Name_of_vendor = Vendor.AMD;
                }
                else
                {
                    CPU.Name_of_vendor = Vendor.Intel;
                }
                CPU.Release_date = dateTimePicker1.Value;
                CPU.Name_of_CPU = textBox1.Text;
                CPU.Soket = textBox2.Text;
                CPU.Numbers_of_cores = Int32.Parse(textBox3.Text);
                CPU.Numbers_of_threads = Int32.Parse(textBox4.Text);
                CPU.Base_frequency = Double.Parse(textBox5.Text);
                CPU.Size_of_cacheL1 = textBox6.Text;
                CPU.Size_of_cacheL2 = textBox7.Text;
                CPU.Size_of_cacheL3 = textBox8.Text;
                flag = 1;
                CPU.CpuToXML(CPU.Name_of_vendor, CPU.Release_date, CPU.Name_of_CPU, CPU.Soket, CPU.Numbers_of_cores,
                             CPU.Numbers_of_threads, CPU.Base_frequency, CPU.Size_of_cacheL1, CPU.Size_of_cacheL2, CPU.Size_of_cacheL3);
                Close();

            }
            catch(Exception er)
            {
                MessageBox.Show("Введенные вами значения некорректны. Попробуйте ввести их еще раз.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
