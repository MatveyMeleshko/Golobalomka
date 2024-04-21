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
    public partial class FormPlay_2 : Form
    {
        public FormPlay_2()
        {
            InitializeComponent();

            progressBar1.Value = 100;
        }

        private void FormPlay_2_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Нужно прыгать с нижней ступени")
            {
                textBox3.Text = "ВЕРНО";

                FormPlay_3 play_3 = new FormPlay_3();
                play_3.Show();

                timer1.Enabled = false;
            }
            else
            {
                textBox3.Text = "!!!";

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
