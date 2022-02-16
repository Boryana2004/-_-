using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проста_Лихва
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k0 = double.Parse(textBoxNachalnaSuma.Text);
            int meseci = int.Parse(textBoxSrok.Text);
            double prozent = double.Parse(textBoxProzent.Text);

            double krajnaSuma = k0 + (((meseci * prozent) / (100 * 12) )* k0);
            labelKrajnaSuma.Text = krajnaSuma.ToString();
            double lihvamesec = (((meseci * prozent) / (100 * 12)) * k0) / 12;
            labelLihwaMesec.Text = $"{lihvamesec:f2}";

            for (int i = 1; i <= meseci; i++)
            {
                k0 = k0 + lihvamesec;
                listBox1.Items.Add($"Месец {i}: {k0:F2}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxNachalnaSuma.Text = "";
            textBoxProzent.Text = "";
            textBoxSrok.Text = "";
            labelKrajnaSuma.Text = "";
            labelLihwaMesec.Text = "";
            listBox1.Items.Clear();
        }
    }
}
