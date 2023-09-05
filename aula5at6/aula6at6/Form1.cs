using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aula6at6
{
    public partial class Form1 : Form
    {
        int finValue, iniValue, divi, i;
        double resol;

        private void button1_Click(object sender, EventArgs e)
        {
            iniValue = int.Parse(textBox1.Text);
            finValue = int.Parse(textBox2.Text);
            divi = int.Parse(textBox3.Text);

            for (int i = iniValue; i <= finValue; i++)
            {
                if (iniValue % divi == 0)
                {
                    listBox1.Items.Add(iniValue);
                    iniValue++;
                }
                else
                {
                    iniValue++;
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
         
        }
    }
}
