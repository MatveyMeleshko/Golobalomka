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
    public partial class FormPlay_3 : Form
    {
        public FormPlay_3()
        {
            InitializeComponent();

            progressBar1.Value = 100;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Совесть") //!!!
            {
                textBox2.Text = "ВЕРНО";

                FormPlay_4 play_4 = new FormPlay_4();
                play_4.Show();

                timer1.Enabled = false;
            }
            else
            {
                textBox2.Text = "!!!";

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
