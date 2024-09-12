using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //процессор
        private static string GetProcessorInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Name"].ToString();
            }
            return string.Empty;
        }
        //производитель
        private string GetManufacturerProcessorInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Manufacturer"].ToString();
            }
            return string.Empty;
        }
        //описание процессора 
        private string GetProcessorDescription()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Description"].ToString();
            }
            return string.Empty;
        }
        //видеокарта
        public string GetVideoCardName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Name"].ToString();
            }
            return string.Empty;
        }
        //видеопроцессор
        private string GetVideoProcessor()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("select * from Win32_Processor");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Name"].ToString();
            }
            return string.Empty;
        }
        //накопитель
        public string GetHardwareInfo()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            foreach (ManagementObject obj in searcher.Get())
            {
                return obj["Caption"].ToString();
            }
            return string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string processorInfo = GetProcessorInfo();
            string videoCardName = GetVideoCardName();
            string videoprocessor = GetVideoProcessor();
            string nakop = GetHardwareInfo();
            string description = GetProcessorDescription();
            string manufacturer = GetManufacturerProcessorInfo();
            //процессор
            if (processorInfo.Contains("Intel"))
            {
                pictureBox2.Image = Properties.Resources.logo;
            }
            else if (processorInfo.Contains("AMD"))
            {
                pictureBox2.Image = Properties.Resources.AMD_Logo;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.err;
            }

            //видеокарта
            if (videoCardName.Contains("NVIDIA"))
            {
                pictureBox4.Image = Properties.Resources.n;
            }
            else if (videoCardName.Contains("AMD"))
            {
                pictureBox4.Image = Properties.Resources.AMD_Logo;
            }
            else if (videoCardName.Contains("MSI"))
            {
                pictureBox4.Image = Properties.Resources.msai;
            }
            else if (videoCardName.Contains("Asus"))
            {
                pictureBox4.Image = Properties.Resources.asus1;
            }
            else if (videoCardName.Contains("Intel"))
            {
                pictureBox4.Image = Properties.Resources.logo;
            }
            else if (videoCardName.Contains("Gigabyte"))
            {
                pictureBox4.Image = Properties.Resources.gigabyte;
            }
            else
            {
                pictureBox4.Image = Properties.Resources.err;
            }

            //видеопроцессор
            if (videoprocessor.Contains("NVIDIA"))
            {
                pictureBox1.Image = Properties.Resources.n;
            }
            else if (videoprocessor.Contains("AMD"))
            {
                pictureBox1.Image = Properties.Resources.AMD_Logo;
            }
            else if (videoprocessor.Contains("MSI"))
            {
                pictureBox1.Image = Properties.Resources.msai;
            }
            else if (videoprocessor.Contains("Asus"))
            {
                pictureBox1.Image = Properties.Resources.asus1;
            }
            else if (videoprocessor.Contains("Intel"))
            {
                pictureBox1.Image = Properties.Resources.logo;
            }
            else if (videoprocessor.Contains("Intel"))
            {
                pictureBox1.Image = Properties.Resources.gigabyte;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.err;
            }

            // Создаем объект ManagementObjectSearcher
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            // Получаем коллекцию объектов ManagementObject
            ManagementObjectCollection collection = searcher.Get();

            // Перебираем каждый объект ManagementObject в коллекции
            foreach (ManagementObject obj in collection)
            {
                // Получаем информацию о жестком диске
                string model = obj["Model"].ToString();
                string size = obj["Size"].ToString();

                // Выводим информацию в TextBox
                label8.Text = model;
                label10.Text = size;
            }

            // Добавьте другие проверки на видеокарту и установите соответствующие логотипы
            label1.Text = processorInfo;
            label2.Text = videoCardName;
            label7.Text = videoprocessor;
            label8.Text = nakop;
            label12.Text = description;
            label9.Text = manufacturer;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
