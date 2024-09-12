using System; // Использование пространства имён System
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace app1
{
    public partial class Form1 : Form
    {
        private int balance = 100; //баланс
        private int attempts = 10; //попытки

        int i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, r1;

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true; 
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //нельзя ввести букву
            if (!int.TryParse(textBox1.Text, out int number))
            { 
                textBox1.Clear();
                MessageBox.Show("Пожалуйста, введите число!");
            }
        }

        private Random random = new Random();

        public Form1()
        {
            InitializeComponent(); //Метод, который инициализирует все компоненты, расположенные на форме: поля, кнопки, меню, переключатели и т. п. 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            r1++;
                       
            if (r1<20)
            {
                i1 = random.Next(5); //генерирует случайное число от 0 до 4 и присваивает его переменной
                i2 = random.Next(5);
                i3 = random.Next(5);
                i4 = random.Next(5);
                i5 = random.Next(5);
                i6 = random.Next(5);
                i7 = random.Next(5);
                i8 = random.Next(5);
                i9 = random.Next(5);
                i10 = random.Next(5);
                i11 = random.Next(5);
                i12 = random.Next(5);
                i13 = random.Next(5);
                i14 = random.Next(5);
                i15 = random.Next(5);

                switch (i1) //оператор многоходового перехода, выбирает действие на основании значения переменной i1
                {
                    case 1: //используется для того, чтобы указать значение константы
                        pictureBox2.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox2.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox2.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox2.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i2)
                {
                    case 1:
                        pictureBox5.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox5.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox5.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox5.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i3)
                {
                    case 1:
                        pictureBox8.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox8.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox8.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox8.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i4) 
                {
                    case 1:
                        pictureBox11.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox11.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox11.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox11.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i5)
                {
                    case 1:
                        pictureBox14.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox14.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox14.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox14.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i6) 
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox1.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox1.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox1.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i7)
                {
                    case 1:
                        pictureBox3.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox3.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox3.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox3.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i8)
                {
                    case 1:
                        pictureBox4.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox4.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox4.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox4.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i9)
                {
                    case 1:
                        pictureBox6.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox6.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox6.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox6.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i10)
                {
                    case 1:
                        pictureBox7.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox7.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox7.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox7.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i11)
                {
                    case 1:
                        pictureBox9.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox9.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox9.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox9.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i12)
                {
                    case 1:
                        pictureBox10.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox10.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox10.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox10.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i13)
                {
                    case 1:
                        pictureBox12.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox12.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox12.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox12.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i14)
                {
                    case 1:
                        pictureBox13.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox13.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox13.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox13.Image = Properties.Resources.ivent;
                        break;
                }
                switch (i15)
                {
                    case 1:
                        pictureBox15.Image = Properties.Resources.mora;
                        break;
                    case 2:
                        pictureBox15.Image = Properties.Resources.prem;
                        break;
                    case 3:
                        pictureBox15.Image = Properties.Resources.stand;
                        break;
                    case 4:
                        pictureBox15.Image = Properties.Resources.ivent;
                        break;
                }
            }
            else
            {
                timer1.Enabled = false;
                r1 = 0;
                Result();
            }

        }
        void Result()
        {
            int bet = Convert.ToInt32(textBox1.Text);
            if (i1 == i2 && i2 == i3 && i3 == i4 && i4 == i5)
            {
                // Комбинация 1 2 3 4 5 - одинаковые символы во всех позициях
                balance += 50;
                label4.Text = "Баланс: " + (bet * balance);
                attempts++;
            }
            else if (i1 == i2 && i2 == i3 && i3 == i4)
            {
                // Комбинация 1 2 3 4 - одинаковые символы в первых четырех позициях
                balance += 40;
                label4.Text = "Баланс: " + (bet * balance);
                attempts++;
            }
            else if (i2 == i3 && i3 == i4 && i4 == i5)
            {
                // Комбинация 2 3 4 5 - одинаковые символы в последних четырех позициях
                balance += 35;
                label4.Text = "Баланс: " + (bet * balance);
                attempts++;
            }
            else if (i1 == i2 && i2 == i3)
            {
                // Комбинация 1 2 3 - одинаковые символы в первых трех позициях
                balance += 30;
                label4.Text = "Баланс: " + (bet * balance);
                attempts++;
            }
            else if (i2 == i3 && i3 == i4)
            {
                // Комбинация 2 3 4 - одинаковые символы в середине
                balance += 25;
                label4.Text = "Баланс: " + (bet * balance);
                attempts++;
            }
            else if (i3 == i4 && i4 == i5)
            {
                // Комбинация 3 4 5 - одинаковые символы в последних трех позициях
                balance += 20;
                label4.Text = "Баланс: " + (bet * balance);
                attempts++;
            }
            else if (i1 == i2 && i2 == i3 && i4 == i5)
            {
                // Комбинация 1 2 3 4 5 - одинаковые символы в первых трех и последних двух позициях
                balance += 15;
                label4.Text = "Баланс: " + (bet * balance);
                attempts++;
            }
            else if (i1 == i2 && i3 == i4 && i4 == i5)
            {
                // Комбинация 1 2 3 4 5 - одинаковые символы в первых двух и последних трех позициях
                balance += 10;
                label4.Text = "Баланс: " + (bet * balance);
                attempts++;
            }
            else if (i1 == i2 && i3 == i4)
            {
                // Комбинация 1 2 3 4 - одинаковые символы в первых двух и середине
                balance += 5;
                label4.Text = "Баланс: " + (bet * balance);
            }
            else if (i1 == i2 && i4 == i5)
            {
                // Комбинация 1 2 4 5 - одинаковые символы в первых двух и последних двух позициях
                balance += 1;
                label4.Text = "Баланс: " + (bet * balance);
            }
            else if (i1 == i2)
            {
                // Комбинация 1 2 - одинаковые символы в первых двух и последних двух позициях
                balance += 1;
                label4.Text = "Баланс: " + (bet * balance);
            }
            else
            {
                attempts--;
                balance -= Convert.ToInt32(textBox1.Text); // вычитаем ставку из баланса при проигрыше

            }
            label4.Text = "Баланс: " + balance;
            label21.Text = "Попытки: " + attempts;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            int bet = Convert.ToInt32(textBox1.Text);

            if (bet > balance)
            {
                // Ставка больше, чем баланс - выводим сообщение об ошибке
                MessageBox.Show("Недостаточно баланса");
                return;
            }            
            if (textBox1.Text == "" )
            {
                //ставка не введена
                 MessageBox.Show("Введите ставку");
            }
            if (attempts <= 0)
            {
                //закончились попытки
                MessageBox.Show("У вас закончились попытки!");
                return;
            }
            else
            {
                timer1.Enabled = true;
                textBox1.Enabled = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label21.Text = "Попытки: " + attempts;
            label4.Text = "Баланс: " + 100;
        }
    }
}