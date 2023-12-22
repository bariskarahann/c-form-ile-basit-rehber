using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace rehber
{
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ekle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isim.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("boş geçilemez");              
            }
            else
            {
                StreamWriter dosyaYazici = new StreamWriter(".\\bilgiler.txt", true);
                dosyaYazici.WriteLine(isim.Text + "#" + textBox2.Text + "#" + textBox3.Text);
                dosyaYazici.Close();
                MessageBox.Show("başarılı");
            }
        }
    }
}
