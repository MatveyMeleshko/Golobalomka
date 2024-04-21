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
    public partial class FormPlay2 : Form
    {
        public FormPlay2()
        {
            InitializeComponent();

            progressBar1.Value = 100;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
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
            FormPlay3 play3 = new FormPlay3();
            play3.Show();

            timer1.Enabled = false;
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Неверно!");
            progressBar1.Value = 100;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверно!");
            progressBar1.Value = 100;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Неверно!");
            progressBar1.Value = 100;
        }
        
        private void FormPlay2_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
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
    }
}
