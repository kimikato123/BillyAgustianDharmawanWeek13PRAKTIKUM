using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_week_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonKonversi_Click(object sender, EventArgs e)
        {
            if (textBoxKalimat.Text == "")
            {
                MessageBox.Show("Tolong Kalimatnya Diisi");
            }
            else if(textBoxHurufPertama.Text == "")
            {
                MessageBox.Show("Tolong Huruf Pertama Diisi");
            }
            else if (textBoxHurufKedua.Text == "")
            {
                MessageBox.Show("Tolong Huruf Kedua Diisi");
            }
            else
            {
                int perbedaan = 0;
                String kalimat = textBoxKalimat.Text.ToLower();
                char[] kalimat1 = kalimat.ToCharArray();
                string kalimathasil ="" ;
                int[] Kalimat = new int[textBoxKalimat.Text.Length];
                for (int U = 0; U < textBoxKalimat.Text.Length; U++)
                {
                    Kalimat[U] = kalimat1[U];
                }
                string huruf1 = textBoxHurufPertama.Text.ToLower();
                char[] hurufpertama = huruf1.ToCharArray();
                int value1 = hurufpertama[0];
                string huruf2 = textBoxHurufKedua.Text.ToLower();
                char[] hurufkedua = huruf2.ToCharArray();
                int value2 = hurufkedua[0];
                if (value1 > value2)
                {
                    perbedaan = value1 - value2;
                    for (int y =0; y< textBoxKalimat.Text.Length; y++)
                    {
                        Kalimat[y] = Kalimat[y] - perbedaan;
                        if (Kalimat[y] < 97)
                        {
                            Kalimat[y] = Kalimat[y] + 26;
                        }
                        char kalimat2 = (char)Kalimat[y];
                        if (kalimathasil == "")
                        {
                            kalimathasil = kalimat2.ToString();
                        }
                        else
                        {
                            kalimathasil = kalimathasil + kalimat2.ToString();
                        }
                    }
                    labelFinal.Text = kalimathasil;
                }
                else if (value1 < value2)
                {
                    perbedaan = value2 - value1;
                    for (int y = 0; y < textBoxKalimat.Text.Length; y++)
                    {
                        Kalimat[y] = Kalimat[y] + perbedaan;
                        if (Kalimat[y] > 122)
                        {
                            Kalimat[y] = Kalimat[y] - 26;
                        }
                        char kalimat2 = (char)Kalimat[y];
                        if (kalimathasil == "")
                        {
                            kalimathasil = kalimat2.ToString();
                        }
                        else
                        {
                            kalimathasil = kalimathasil + kalimat2.ToString();
                        }
                    }
                    labelFinal.Text = kalimathasil;
                }
            }
        }
    }
}
