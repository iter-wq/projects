using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace game
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        Form3 f3 = new Form3();


        public Form1()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(150, Color.White);
            label1.BackColor = Color.FromArgb(150, Color.White);
            label2.BackColor = Color.FromArgb(1, Color.White);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // переход на Form2 при выборе "Обычная сложность"
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // переход на Form3 при выборе "Средняя сложность"
            f3.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
