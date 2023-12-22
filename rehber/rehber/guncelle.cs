using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehber
{
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }

        private void guncelle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("boş geçilemez");
            }
            else
            {
                string[] satirlar = new string[100];
                int i = 0;
                StreamReader okuyucu = new StreamReader(".\\bilgiler.txt");
                while (okuyucu.EndOfStream == false)
                {
                    string str = okuyucu.ReadLine();
                    string[] kelime = str.Split('#');

                    if (kelime[0] == textBox1.Text || kelime[1] == textBox2.Text || kelime[2] == textBox3.Text)
                    {

                        satirlar[i] = textBox4.Text + "#" + textBox5.Text + "#" + textBox6.Text;
                    }
                    else
                    {
                        satirlar[i] = str;
                    }
                    i++;

                }
                okuyucu.Close();

                StreamWriter yazici = new StreamWriter(".\\bilgiler.txt", false);
                foreach (string satir in satirlar)
                {
                    yazici.WriteLine(satir);
                }
                yazici.Close();
                MessageBox.Show("güncelleme işlemi tamamlandı");

            }
        }
    }
}
