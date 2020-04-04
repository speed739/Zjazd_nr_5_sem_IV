using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zjazd_5
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            var path = openFileDialog1.FileName;
            var content = File.ReadAllText(path);
            var filenumbers = content.Split(new[] { "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in filenumbers)
            {
                flowLayoutPanel1.Controls.Add(GenerateNumberTextBox(item));
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private TextBox GenerateNumberTextBox(string number)
        {
            return new TextBox()
            {
                Text = number,
                ReadOnly = true,
                Width = 25
            };
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = rand.Next(50).ToString();

        }
    }
}
