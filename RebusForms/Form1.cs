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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            математика=new Математика();
        }
        Математика математика;

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Русский_Click(object sender, EventArgs e)
        {

        }

        private void Физкультура_Click(object sender, EventArgs e)
        {

        }

        private void Математика_Click(object sender, EventArgs e)
        {
            математика.Show();
            Hide();
        }
    }
}
