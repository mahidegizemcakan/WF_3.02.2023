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
    public partial class Tablo : Form
    {
        public Tablo()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int secilen = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(secilen);
        }

        private void Tablo_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("OGRETMEN");
            comboBox1.Items.Add("MUHENDİS");
            comboBox1.Items.Add("DOKTOR");
            comboBox1.Items.Add("ASCI");
            comboBox1.Items.Add("TEKNİSYEN");
            comboBox2.Items.Add("KADIN");
            comboBox2.Items.Add("ERKEK");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
            listBox3.Items.Add(textBox2.Text);
            textBox2.Text = "";
            textBox2.Focus();
            comboBox1.Items.Add(comb.Text);
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
