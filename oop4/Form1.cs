using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Produkt produkt;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked) { produkt = new Produkt(textBox1.Text, (double)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value, true); }
                else { produkt = new Produkt(textBox1.Text, (double)numericUpDown1.Value, dateTimePicker1.Value, (int)numericUpDown2.Value, false); }
                button2.Enabled = true;
            }
            catch { MessageBox.Show("Chybne zadane udaje!"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(produkt.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
