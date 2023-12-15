using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zavedenie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masa = "";
            string plashtane = "";
            if (radMasa.Checked)
            {
                masa = radMasa.Text;
            }
            else
            {
                masa = radMasa2.Text;
            }
            if (radKesh.Checked)
            {
                plashtane = radKesh.Text;
                MessageBox.Show("Ще оставите ли бакшиш?", "Бакшиш", MessageBoxButtons.YesNo);
            }
            else
            {
                plashtane = radCard.Text;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("За колко души да е масата?");
                textBox1.Focus();
            }
            else
            {
            MessageBox.Show("Вие избрахте: Маса " + masa + ", за " + textBox1.Text + " души и заплащане " + plashtane);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
