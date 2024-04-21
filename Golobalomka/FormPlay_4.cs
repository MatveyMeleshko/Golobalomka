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
    public partial class FormPlay_4 : Form
    {
        public FormPlay_4()
        {
            InitializeComponent();

            progressBar1.Value = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Ноль")
            {
                textBox4.Text = "ВЕРНО";

                FormPlay_1 play_1 = new FormPlay_1();
                play_1.Show();

                timer1.Enabled = false;
            }
            else
            {

                textBox4.Text = "!!!";

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
