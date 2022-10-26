using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapmakinasi
{
    public partial class Form1 : Form
    {
        char _islem;
        bool _ekrantemizlenecekmi;
        int _ilksayi;

        public Form1()
        {
            InitializeComponent();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (_ekrantemizlenecekmi == true)
            {
                ekranlabel1.Text = "";
                _ekrantemizlenecekmi = false;

            }
            if (ekranlabel1.Text == "0") ekranlabel1.Text = "";
            ekranlabel1.Text += "9";
        }     
        private void buttonartı_Click(object sender, EventArgs e)
        {
            _islem = '+';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel1.Text);
        }
        private void buttoncarpi_Click(object sender, EventArgs e)
        {
            _islem = '*';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel1.Text);
        }

        private void buttoneksi_Click(object sender, EventArgs e)
        {
            _islem = '-';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel1.Text);
        }

        private void buttonbolu_Click(object sender, EventArgs e)
        {
            _islem = '/';
            _ekrantemizlenecekmi = true;
            _ilksayi = Convert.ToInt32(ekranlabel1.Text);
        }
        private void buttonesit_Click(object sender, EventArgs e)
        {
            int ikincisayi = Convert.ToInt32(ekranlabel1.Text);
            int sonuc = 0;
            switch (_islem)
            {
                case '+':
                    sonuc = _ilksayi + ikincisayi;
                    break;
                case '-':
                    sonuc = _ilksayi - ikincisayi;
                    break;
                case '*':
                    sonuc = _ilksayi * ikincisayi;
                    break;
                case '/':
                    sonuc = _ilksayi / ikincisayi;
                    break;
            }
            ekranlabel1.Text = Convert.ToString(sonuc);
        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            ekranlabel1.Text = "0";
        }
    }
}
