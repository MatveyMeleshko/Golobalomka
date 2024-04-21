using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Golobalomka
{
    public partial class FormPlay_1 : Form
    {
        public FormPlay_1()
        {
            InitializeComponent();

            progressBar1.Value = 100;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Все")
            {
                textBox1.Text = "ВЕРНО";

                FormPlay_2 play_2 = new FormPlay_2();
                play_2.Show();

                timer1.Enabled = false;
            }
            else
            {
                textBox1.Text = "!!!";

                progressBar1.Value = 100;
            }
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
    }
}
