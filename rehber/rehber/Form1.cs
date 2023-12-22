using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.BackColor = Color.Orange;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ekle form2 = new ekle();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sil form3 = new sil();
            form3.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guncelle form4 = new guncelle();
            form4.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listele form5= new listele();
            form5.ShowDialog();
        }
    }
}
