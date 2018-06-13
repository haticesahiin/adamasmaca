using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorselfinal
{
    public partial class Form1 : Form
    {
        //1140208
        Random r = new Random();
        List<String> egit = new List<string> { };//ağırlık hesaplanacak kelimeler
        List<String> fliste = new List<string> { };//
        List<string> ara = new List<string> { };//tutulacak kelimeler seçim listi
        int[] alfabe = new int[29];
        int[] sırala = new int[29];
        string kelime = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         

            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Metin dosyaları|*.txt|" + "Bütün dosyalar|*.*";
            openFileDialog1.Title = "Açılacak dosyayı seçiniz";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string dosya_adi;
                dosya_adi = openFileDialog1.FileName;
                StreamReader sr = new StreamReader(dosya_adi);
                
                int indis = 0;
                while (!sr.EndOfStream && indis<1140208)
                {
                   
                    if (indis % 4 == 0)
                    {
                        ara.Add(sr.ReadLine());
                    }
                    else
                    {
                        egit.Add(sr.ReadLine());
                        
                    }
                    indis++;
                }
                button2.Enabled = true;
            }
            frekans();
            
        }

        private void frekans()
        {
            foreach (var item in egit)
            {
                char[] harf = item.ToCharArray();
                foreach (var h in harf)
                {
                    harfler(h);
                }
            }
            int max = 0;
            for (int i = 0; i < alfabe.Length; i++)
            {
                
                for (int t = 0; t < alfabe.Length; t++)
                {
                    if (max < alfabe[t])
                    {
                        max = alfabe[t];
                        sırala[i] = t;
                    }
                }
                max = 0;
                alfabe[sırala[i]]= 0;
            }

        }


        private void filtrele(char a)
        {
            List<string> tut = new List<string> { };
            foreach (var item in fliste)
            {
                tut.Add(item);
            }
            
            fliste.Clear();
            foreach (var item in tut)
            {
                if (kelime.Contains(a) )
                {

                    if (hsayi(kelime, a) == hsayi(item, a))
                    {
                        fliste.Add(item);
                    }

                }
                else
                {
                    fliste = tut;

                }
            }
            

        }

        private int hsayi(string a, char b)
        {
            int c = 0;
            foreach (char item in a)
            {
                if (item==b)
                {
                    c++;
                }
            }
            return c;
        }

        private void harfler(char a)
        {
            //MessageBox.Show("Test");
            if (a=='a')
            {
                alfabe[0]++;
            }
            else if (a=='b')
            {
                alfabe[1]++;
            }
            else if (a == 'c')
            {
                alfabe[2]++;
            }
            else if (a == 'ç')
            {
                alfabe[3]++;
            }
            else if (a == 'd')
            {
                alfabe[4]++;
            }
            else if (a == 'e')
            {
                alfabe[5]++;
            }
            else if (a == 'f')
            {
                alfabe[6]++;
            }
            else if (a == 'g')
            {
                alfabe[7]++;
            }
            else if (a == 'ğ')
            {
                alfabe[8]++;
            }
            else if (a == 'h')
            {
                alfabe[9]++;
            }
            else if (a == 'ı')
            {
                alfabe[10]++;
            }
            else if (a == 'i')
            {
                alfabe[11]++;
            }
            else if (a == 'j')
            {
                alfabe[12]++;
            }
            else if (a == 'k')
            {
                alfabe[13]++;
            }
            else if (a == 'l')
            {
                alfabe[14]++;
            }
            else if (a == 'm')
            {
                alfabe[15]++;
            }
            else if (a == 'n')
            {
                alfabe[16]++;
            }
            else if (a == 'o')
            {
                alfabe[17]++;
            }
            else if (a == 'ö')
            {
                alfabe[18]++;
            }
            else if (a == 'p')
            {
                alfabe[19]++;
            }
            else if (a == 'r')
            {
                alfabe[20]++;
            }
            else if (a == 's')
            {
                alfabe[21]++;
            }
            else if (a == 'ş')
            {
                alfabe[22]++;
            }
            else if (a == 't')
            {
                alfabe[23]++;
            }
            else if (a == 'u')
            {
                alfabe[24]++;
            }
            else if (a == 'ü')
            {
                alfabe[25]++;
            }
            else if (a == 'v')
            {
                alfabe[26]++;
            }
            else if (a == 'y')
            {
                alfabe[27]++;
            }
            else if (a == 'z')
            {
                alfabe[28]++;
            }
           
        }

        private char cevir(int i)
        {
            if (i==0 )
            {
                return 'a';
            }
            else if (i == 1)
            {
                return 'b';
            }
            else if (i == 2)
            {
                return 'c';
            }
            else if (i == 3)
            {
                return 'ç';
            }
            else if (i == 4)
            {
                return 'd';
            }
            else if (i == 5)
            {
                return 'e';
            }
            else if (i == 6)
            {
                return 'f';
            }
            else if (i == 7)
            {
                return 'g';
            }
            else if (i == 8)
            {
                return 'ğ';
            }
            else if (i == 9)
            {
                return 'h';
            }
            else if (i == 10)
            {
                return 'ı';
            }
            else if (i == 11)
            {
                return 'i';
            }
            else if (i == 12)
            {
                return 'j';
            }
            else if (i == 13)
            {
                return 'k';
            }
            else if (i == 14)
            {
                return 'l';
            }
            else if (i == 15)
            {
                return 'm';
            }
            else if (i == 16)
            {
                return 'n';
            }
            else if (i == 17)
            {
                return 'o';
            }
            else if (i == 18)
            {
                return 'ö';
            }
            else if (i == 19)
            {
                return 'p';
            }
            else if (i == 20)
            {
                return 'r';
            }
            else if (i == 21)
            {
                return 's';
            }
            else if (i == 22)
            {
                return 'ş';
            }
            else if (i == 23)
            {
                return 't';
            }
            else if (i == 24)
            {
                return 'u';
            }
            else if (i == 25)
            {
                return 'ü';
            }
            else if (i == 26)
            {
                return 'v';
            }
            else if (i == 27)
            {
                return 'y';
            }
            //else (alfabe[i] == 28)
            //{
            //    return 'z';
            //}
            return 'z';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < kelime.Length; j++)
            {
                var lblrmv = this.Controls["lbl"+j];
                this.Controls.Remove(lblrmv);
            }
            

            int tutulan = r.Next(ara.Count);
            kelime = ara[tutulan];

            Label[] lbl = new Label[kelime.Length];

            for (int j = 0; j < kelime.Length; j++)
            {
                lbl[j] = new Label();
                lbl[j].Name = "lbl" + j;
                lbl[j].Text = "_";
                lbl[j].Location = new Point(50 + (j * 13), 125);
                lbl[j].Size = new Size(13, 13);
                this.Controls.Add(lbl[j]);
            }
            label2.Text= kelime;

            foreach (var item in ara)
            {
                if (item.Length==kelime.Length)
                {
                    fliste.Add(item);
                }
            }
            button3.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (var item in sırala)
            {
                filtrele(cevir(item));
            }
            

            for (int j = 0; j < kelime.Length; j++)
            {
                var lblrmv = this.Controls["lbl" + j];
                this.Controls.Remove(lblrmv);
            }
            char[] h = fliste[0].ToCharArray();
            Label[] lbl = new Label[h.Length];
            for (int j = 0; j < h.Length; j++)
            {
                lbl[j] = new Label();
                lbl[j].Name = "lbl" + j;
                lbl[j].Text = h[j].ToString();
                lbl[j].Location = new Point(50 + (j * 17), 125);
                lbl[j].Size = new Size(17, 17);
                lbl[j].Font = new Font("Microsoft Sans Serif", 10.0f, FontStyle.Bold);
                this.Controls.Add(lbl[j]);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = false;
        }
    }
}
