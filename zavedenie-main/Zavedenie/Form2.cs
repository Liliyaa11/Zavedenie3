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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void osn_Click(object sender, EventArgs e)
        {
            grAlc.Hide();
            grdes.Hide();
            grCock.Hide();
            grOsn.Show();
        }

        private void des_Click(object sender, EventArgs e)
        {
            grAlc.Hide();
            grdes.Show();
            grCock.Hide();
            grOsn.Show();
        }

        private void cock_Click(object sender, EventArgs e)
        {
            grAlc.Show();
            grdes.Show();
            grCock.Show();
            grOsn.Show();
        }

        private void alc_Click(object sender, EventArgs e)
        {
            grAlc.Show();
            grdes.Show();
            grCock.Hide();
            grOsn.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            grAlc.Hide();
            grdes.Hide();
            grCock.Hide();
            grOsn.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double price = 0;
            if (int.Parse(txtOsn.Text)>0)
            {
                price += 12 * int.Parse(txtOsn.Text); ;
            }
            if (int.Parse(txtOsn2.Text) > 0)
            {
                price += 10 * int.Parse(txtOsn2.Text); ;
            }
            if (int.Parse(txtOsn3.Text) > 0)
            {
                price += 10 * int.Parse(txtOsn3.Text); ;
            }
            if (int.Parse(txtDes.Text) > 0)
            {
                price += 7 * int.Parse(txtDes.Text); ;
            }
            if (int.Parse(txtDes2.Text) > 0)
            {
                price += 9 * int.Parse(txtDes2.Text); ;
            }
            if (int.Parse(txtDes3.Text) > 0)
            {
                price += 6 * int.Parse(txtDes3.Text); ;
            }
            if (int.Parse(txtCock.Text) > 0)
            {
                price += 3 * int.Parse(txtCock.Text); ;
            }
            if (int.Parse(txtCock2.Text) > 0)
            {
                price += 3 * int.Parse(txtCock2.Text); ;
            }
            if (int.Parse(txtCock3.Text) > 0)
            {
                price += 2.5 * double.Parse(txtCock3.Text); ;
            }
            if (int.Parse(txtAlc.Text) > 0)
            {
                price += 7 * int.Parse(txtAlc.Text); ;
            }
            if (int.Parse(txtAlc2.Text) > 0)
            {
                price += 9 * int.Parse(txtAlc2.Text); ;
            }
            if (int.Parse(txtAlc3.Text) > 0)
            {
                price += 6 * int.Parse(txtAlc3.Text); ;
            }
            MessageBox.Show("Цена: "+price+"лв.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtOsn.Text != "0")
            {
                listBox1.Items.Add($"{txtOsn.Text}бр. {lblOsn.Text}");
            }
            if (txtOsn2.Text != "0")
            {
                listBox1.Items.Add($"{txtOsn2.Text}бр. {lblOsn2.Text}");
            }
            if (txtOsn3.Text != "0")
            {
                listBox1.Items.Add($"{txtOsn3.Text}бр. {lblOsn3.Text}");
            }
            if (txtDes.Text != "0")
            {
                listBox1.Items.Add($"{txtDes.Text}бр. {lblDes.Text}");
            }
            if (txtDes2.Text != "0")
            {
                listBox1.Items.Add($"{txtDes2.Text}бр. {lblDes2.Text}");
            }
            if (txtDes3.Text != "0")
            {
                listBox1.Items.Add($"{txtDes3.Text}бр. {lblDes3.Text}");
            }
            if (txtAlc.Text != "0")
            {
                listBox1.Items.Add($"{txtCock.Text}бр. {lblAlc.Text}");
            }
            if (txtAlc2.Text != "0")
            {
                listBox1.Items.Add($"{txtCock2.Text}бр. {lblAlc2.Text}");
            }
            if (txtAlc3.Text != "0")
            {
                listBox1.Items.Add($"{txtCock3.Text}бр. {lblAlc3.Text}");
            }
            if (txtCock.Text != "0")
            {
                listBox1.Items.Add($"{txtAlc.Text}бр. {lblCock.Text}");
            }
            if (txtCock2.Text != "0")
            {
                listBox1.Items.Add($"{txtAlc2.Text}бр. {lblCock2.Text}");
            }
            if (txtCock3.Text != "0")
            {
                listBox1.Items.Add($"{txtAlc3.Text}бр. {lblCock3.Text}");
            }

        }
    }
}
