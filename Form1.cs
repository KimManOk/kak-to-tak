using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }


        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            a = 0;
            b = 0;
        }


        double a = 0, b = 0, c = 0;
        char znak;

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void первыйпочтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Первый(почти) калькулятор, не судите строго.");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Sqrt(a));
            }
            catch (Exception)
            {

            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(Math.Pow(a, 2));
            }
            catch (Exception)
            {

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
                switch(znak)
                {
                    case '+': c = a + b;
                        break;
                    case '-': c = a - b;
                        break;
                    case '*': c = a * b;
                        break;
                    case '/': c = a / b;
                        break;
                }
            textBox1.Text = c.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                a = Convert.ToDouble(textBox1.Text); //значение текстбокса конверировали в тип дабл

                znak = (sender as Button).Text[0];  //принимает значение типа чар кнопки, на которую нажали

                textBox1.Clear();
            }
            catch (Exception)
            {

            }

        }
    }
}
