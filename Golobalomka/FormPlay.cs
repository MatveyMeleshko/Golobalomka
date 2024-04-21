using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golobalomka
{
    public partial class FormPlay : Form
    {
        public FormPlay()
        {
            InitializeComponent();

            progressBar1.Value = 100;
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверно!");
            progressBar1.Value = 100;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверно!");
            progressBar1.Value = 100;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверно!");
            progressBar1.Value = 100;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            FormPlay2 play2 = new FormPlay2();
            play2.Show();

            timer1.Enabled = false;
        }
        
        private void button5_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Неверно!");
            progressBar1.Value = 100;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Неверно!");
            progressBar1.Value = 100;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 0)
            {
                progressBar1.Value -= 1;
            }
            else
            {
                Application.Exit();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
