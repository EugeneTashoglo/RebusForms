using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebusForms
{
    public partial class Математика : Form
    {
        int n=0;
        string[] answer;
        string[] userAnswers;
        bool[] correctAnswers;
        public Математика()
        {
            InitializeComponent();
            answer = new string[]{ "Пять", "Конус", "Вершина"};
            userAnswers = new string[answer.Length];
            correctAnswers = new bool[answer.Length];
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        public void show(int n)
        {
            
            switch (n) 
            {
               case 0:
                    pictureBox1.BackgroundImage =  new Bitmap(RebusForms.Properties.Resources.пять);
                    break;
                case 1:
                    pictureBox1.BackgroundImage = new Bitmap(RebusForms.Properties.Resources.конус);
                    break;
                case 2:
                    pictureBox1.BackgroundImage = new Bitmap(RebusForms.Properties.Resources.вершина);
                    break;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            n++;
            if (n > 2) return;
            textBox1.Text = userAnswers[n];
            show(n);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n--;
            if (n < 0) return;
            textBox1.Text = userAnswers[n];
            show(n);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                        
        }
     
        private void Математика_Load(object sender, EventArgs e)
        {
            var bmp = new Bitmap(RebusForms.Properties.Resources.пять);
            pictureBox1.BackgroundImage = bmp;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int correctAnswersLenth = 0;
            for (int i = 0; i < userAnswers.Length; i++) 
            {
                
               
                bool correct = userAnswers[i] == answer[i];
                if (correct)
                {
                    correctAnswersLenth++;
                    correctAnswers[i] = correct;
                }
            }

            MessageBox.Show((correctAnswersLenth / answer.Length * 100).ToString());
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            userAnswers[n] = textBox1.Text;
        }
    }
}
