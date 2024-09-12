using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class Form2 : Form
    {
        
        Random random = new Random();
        private DateTime lastClickTime = DateTime.Now;
        private int clickCount = 0;
        private const int maxClicks = 5; // Максимальное количество кликов за определенный период времени
        private TimeSpan clickInterval = TimeSpan.FromSeconds(1); // Интервал времени между кликами

        public Form2()
        {
            InitializeComponent();
            // Подписываемся на событие клика мыши на форме
            this.MouseClick += MainForm_MouseClick;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // установка фона для обычной сложности
            Image[] backgrounds = {Properties.Resources.кресло, Properties.Resources.хижина};

            int itemIndex = random.Next(1, 4);
            int itemIndex1 = random.Next(1, 4);// генерация числа от 1 до 3
            int randomIndex = random.Next(backgrounds.Length);

            // устанавка изображения фона для формы
            this.BackgroundImage = backgrounds[randomIndex];

            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;

            if (randomIndex == 0) //кресло
            {
                if (itemIndex == 1)
                {
                    label1.Text = "Найдите красную банку";
                    pictureBox1.Click += PictureBox1_Click;
                    pictureBox1.Enabled = true;
                }
                else if (itemIndex == 2) 
                {
                    label1.Text = "Найдите аксолотля";
                    pictureBox2.Click += PictureBox2_Click;
                    pictureBox2.Enabled = true;
                }
                else if (itemIndex == 3)
                {
                    label1.Text = "Найдите коробку";
                    pictureBox3.Click += PictureBox3_Click;
                    pictureBox3.Enabled = true;
                }
            } else if (randomIndex == 1) //хижина
            {
                if (itemIndex1 == 1)
                {
                    label1.Text = "Найдите свинку";
                    pictureBox4.Click += PictureBox4_Click;
                    pictureBox4.Enabled = true;
                }
                else if (itemIndex1 == 2)
                {
                    label1.Text = "Найдите табличку с надписью 20";
                    pictureBox5.Click += PictureBox5_Click;
                    pictureBox5.Enabled = true;
                }
                else if (itemIndex1 == 3)
                {
                    label1.Text = "Найдите громкоговоритель";
                    pictureBox6.Click += PictureBox6_Click;
                    pictureBox6.Enabled = true;
                }
            }
            
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы нашли красную банку!");
            this.Close(); // закрываем текущую форму
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы нашли аксолотля!");
            this.Close(); 
        }
        private void PictureBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы нашли коробку!");
            this.Close(); 
        }
        private void PictureBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы нашли свинку!");
            this.Close(); 
        }
        private void PictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы нашли табличку!");
            this.Close(); 
        }
        private void PictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы нашли громкоговоритель!");
            this.Close(); 
        }
        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            TimeSpan timeSinceLastClick = DateTime.Now - lastClickTime;

            if (timeSinceLastClick < clickInterval)
            {
                clickCount++;
            }
            else
            {
                clickCount = 1;
            }

            if (clickCount > maxClicks)
            {
                MessageBox.Show("Слишком много кликов.");
                // Дополнительные действия по предотвращению автоматизированных действий
            }
            lastClickTime = DateTime.Now;
        }
    }
}
