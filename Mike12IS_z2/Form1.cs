using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mike12IS_z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double tsenat, nt, tsenak, nk, p;// tsenat-цена тетради; nt-кол-во тетрадей;tsenak-цена карандаша; nt-кол-во карандашей; p-стоимость покупки
            tsenat = Convert.ToDouble(textBox1.Text);
            nt = Convert.ToDouble(textBox2.Text);
            tsenak = Convert.ToDouble(textBox3.Text);
            nk = Convert.ToDouble(textBox4.Text);
            p = ((tsenat * nt) + (tsenak * nk));
            listBox1.Items.Add("Стоимость покупки = " + p + "руб.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
