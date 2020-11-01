using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabaOzellikleri
{
    public partial class Form1 : Form
    {
        Customer customer;
        public Form1()
        {
            InitializeComponent();
        }

        public void bKaydet_Click(object sender, EventArgs e)
        {
            customer = new Customer()
            
            {
                Id = tbId.Text,
                Marka = tbMarka.Text,
                Model = tbModel.Text,
                ArabaTuru = tbArabaTuru.Text,
                KapiSayisi = tbKapiSayisi.Text,
                CekisTuru = tbCekisTuru.Text,
                BeygirGucu = tbBeygirGucu.Text,
                MotorHacmi = tbMotorHacmi.Text,
                Hizlanma = tbHizlanma.Text,
                MaksimumHiz = tbMaksimumHiz.Text,
                Agirlik = tbAgirlik.Text,

            };
            tbId.Text = "";
            tbMarka.Text = "";
            tbModel.Text = "";
            tbArabaTuru.Text = "";
            tbKapiSayisi.Text = "";
            tbCekisTuru.Text = "";
            tbBeygirGucu.Text = "";
            tbMotorHacmi.Text = "";
            tbHizlanma.Text = "";
            tbMaksimumHiz.Text = "";
            tbAgirlik.Text = "";


        }

        private void bGoster_Click(object sender, EventArgs e)
        {
            rtbSonuc.Text = "Id: " + customer.Id + "\n";
            rtbSonuc.Text += "Marka: " + customer.Marka + "\n";
            rtbSonuc.Text += "Model: " + customer.Model + "\n";
            rtbSonuc.Text += "Araba Türü: " + customer.ArabaTuru + "\n";
            rtbSonuc.Text += "Kapı Sayısı: " + customer.KapiSayisi + "\n";
            rtbSonuc.Text += "Çekiş Türü: " + customer.CekisTuru + "\n";
            rtbSonuc.Text += "Beygir Gücü: " + customer.BeygirGucu + "\n";
            rtbSonuc.Text += "Motor Hacmi: " + customer.MotorHacmi + "\n";
            rtbSonuc.Text += "Hızlanma: " + customer.Hizlanma + "\n";
            rtbSonuc.Text += "Maksimum Hız: " + customer.MaksimumHiz + "\n";
            rtbSonuc.Text += "Ağırlık: " + customer.Agirlik;
            
        }

        private void rtbSonuc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
