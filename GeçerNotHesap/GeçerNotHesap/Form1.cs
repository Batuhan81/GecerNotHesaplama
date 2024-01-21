using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GeçerNotHesap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Program başladığında dosyayı aç ve başlıkları yaz
            if (!File.Exists(dosyaYolu))
            {
                using (StreamWriter sw = new StreamWriter(dosyaYolu, true, Encoding.GetEncoding(1254)))
                {
                    sw.WriteLine($"{"Öğrenci No",-20}{"Vize Notu",-20}{"Final Notu",-20}{"Geçer Not",-20}");
                }
            }
        }
        int araNot, finalNot,geçmeNot;
        string ÖgrNo;
        void dönüştür()
        {
            araNot = Convert.ToInt32( AraNot.Text);
            finalNot = Convert.ToInt32(FinalNot.Text);
            ÖgrNo = ögrNo.Text;
        }
        string dosyaYolu = Application.StartupPath + @"\Notlar.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            dönüştür();
            if(finalNot >= 30)
            {
               geçmeNot = (araNot * 40) / 100 + (finalNot * 60) / 100;
            }
            else
            {
                geçmeNot = 0;
            }
            GeçerNot.Text=geçmeNot.ToString();
            dosayayakayıtt();
        }
        private void dosayayakayıtt()
        {
            if (string.IsNullOrWhiteSpace(ögrNo.Text) ||
                string.IsNullOrWhiteSpace(AraNot.Text) ||
                string.IsNullOrWhiteSpace(FinalNot.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            

            // Dosya yoksa başlıkları ekle, varsa verileri ekleyelim
            if (!File.Exists(dosyaYolu))
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(dosyaYolu, true, Encoding.GetEncoding(1254)))
                    {
                        // Başlıkları dosyaya yaz
                        sw.WriteLine($"{"Öğrenci No",-20}{"Vize Notu",-20}{"Final Notu",-20}{"Geçer Not",-20}");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }

            // Dosyaya verileri ekleyelim
            try
            {
                using (StreamWriter sw = new StreamWriter(dosyaYolu, true, Encoding.GetEncoding(1254)))
                {
                    string ogrenciNo = ögrNo.Text;
                    string vizeNotu = AraNot.Text;
                    string finalNotu = FinalNot.Text;

                    // Vize ve final notlarını alarak geçer notu hesapla
                    double vize = Convert.ToDouble(vizeNotu);
                    double final = Convert.ToDouble(finalNotu);
                    double gecerNot = (vize * 0.4) + (final * 0.6);

                    // Verileri dosyaya yaz
                    sw.WriteLine($"{ogrenciNo,-20}{vizeNotu,-20}{finalNotu,-20}{gecerNot,-20}");
                }

                MessageBox.Show("Veriler dosyaya başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            // TextBox'ları temizle
            ögrNo.Clear();
            AraNot.Clear();
            FinalNot.Clear();
            GeçerNot.Clear();
        }
    }
}

