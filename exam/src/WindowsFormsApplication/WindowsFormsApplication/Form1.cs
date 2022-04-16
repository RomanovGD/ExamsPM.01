using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string text_box1 = textBox1.Text;
                string text_box2 = textBox2.Text;

                int x = int.Parse(text_box1);
                int y = int.Parse(text_box2);

                if ((x * x + y * y < 4) & (x * x + y * y > 1))
                {
                    textBox3.Text = "Да";
                    
                }
                else
                {
                    textBox3.Text = "Нет";
                    
                }
                
            }
            catch
            {
                MessageBox.Show("Некорректный ввод");
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Глеб Романов Дмитриевич ПКуспк-320. Вариант №9");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void вебстраница1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:/Users/Пользователь/Desktop/exam/web/index.html");
            Size = new Size(1400, 800);
        }

        private void вебстраница2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Url = new Uri("C:/Users/Пользователь/Desktop/exam/web/index2.html");
            Size = new Size(1400, 800);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
