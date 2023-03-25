using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_3._02._2023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //isim soy isim telefon olan rehber
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(secilen);
        }

        private void ekle2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(isim.Text);
            listBox2.Items.Add(soyisim.Text);
            listBox2.Items.Add(telefon.Text);
            isim.Text = "";
            isim.Focus();
        }

        private void sil2_Click(object sender, EventArgs e)
        {
            int sec = listBox2.SelectedIndex;
            listBox2.Items.RemoveAt(sec);
        }
    }
}
