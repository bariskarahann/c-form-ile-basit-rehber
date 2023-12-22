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
    public partial class listele : Form
    {
        public listele()
        {
            InitializeComponent();
        }

        private void listele_Load(object sender, EventArgs e)
        {
            StreamReader okuyucu = new StreamReader(".\\bilgiler.txt", true);
            string header = "İSİM\tSOYİSİM\tTELEFON\n";
            string content = "";

            while (okuyucu.EndOfStream == false)
            {
                string str = okuyucu.ReadLine();
                string[] kelime = str.Split('#');
                for (int i = 0; i < kelime.Length; i++)
                {
                    content += kelime[i] + "\t";
                }
                content += "\n";
            }

            okuyucu.Close();

            richTextBox1.Text = header + content + richTextBox1.Text;



        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
    

