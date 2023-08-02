using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZarOyun
{
    public partial class Zar_Oyunu : Form
    {
        public Zar_Oyunu()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        int birtop = 0;
        int ikitop = 0;
        private void Zar_Oyunu_Load(object sender, EventArgs e)
        {
            button1.Enabled= true;
            button2.Enabled= false;
            MessageBox.Show("Eşit miktarda zar atma sonucu 100'ü geçip en büyük olan oyunu kazanır");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled= false;
            button2.Enabled = true;
            int a=rastgele.Next(1,7);
            int b=rastgele.Next(1, 7);
            label2.Text=a.ToString();
            label3.Text=b.ToString();
            birtop += (a + b);
            label10.Text=birtop.ToString();
            if (a == 1) 
            {
                pictureBox2.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\1.png";
            }
            if (a == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\2.png";
            }
            if (a == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\3.png";
            }
            if (a == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\4.png";
            }
            if (a == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\5.png";
            }
            if (a == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\6.png";
            }
            //2.Görsel
            if (b == 1)
            {
                pictureBox3.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\1.png";
            }
            if (b == 2)
            {
                pictureBox3.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\2.png";
            }
            if (b == 3)
            {
                pictureBox3.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\3.png";
            }
            if (b == 4)
            {
                pictureBox3.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\4.png";
            }
            if (b == 5)
            {
                pictureBox3.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\5.png";
            }
            if (b == 6)
            {
                pictureBox3.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\6.png";
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled= false;
            int c = rastgele.Next(1, 7);
            int d = rastgele.Next(1, 7);
            label7.Text=c.ToString();
            label5.Text=d.ToString();
            ikitop += (c + d);
            label11.Text=ikitop.ToString();
            if (c == 1)
            {
                pictureBox5.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\1.png";
            }
            if (c == 2)
            {
                pictureBox5.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\2.png";
            }
            if (c == 3)
            {
                pictureBox5.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\3.png";
            }
            if (c == 4)
            {
                pictureBox5.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\4.png";
            }
            if (c == 5)
            {
                pictureBox5.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\5.png";
            }
            if (c == 6)
            {
                pictureBox5.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\6.png";
            }
            //2.Görsel
            if (d == 1)
            {
                pictureBox4.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\1.png";
            }
            if (d == 2)
            {
                pictureBox4.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\2.png";
            }
            if (d == 3)
            {
                pictureBox4.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\3.png";
            }
            if (d == 4)
            {
                pictureBox4.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\4.png";
            }
            if (d == 5)
            {
                pictureBox4.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\5.png";
            }
            if (d == 6)
            {
                pictureBox4.ImageLocation = "C:\\Users\\alihe\\OneDrive\\Masaüstü\\zar\\6.png";
            }
            if (birtop > 100 && birtop > ikitop)
            {
                label14.Text = "Kazanan Birinci Oyuncu";
                button1.Enabled = false;
                button2.Enabled = false;
                MessageBox.Show("Kazanan Birinci Oyuncu");
            }
            if (ikitop > 100 && ikitop > birtop)
            {
                label14.Text = "Kazanan İkinci Oyuncu";
                button1.Enabled = false;
                button2.Enabled = false;
                MessageBox.Show("Kazanan İkinci Oyuncu");
            }


        }
    }
}
