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

namespace atm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labLabdien_Click(object sender, EventArgs e)
        {
        }

        private void btnIenakt_Click(object sender, EventArgs e)
        {
            //poga aizvedīs uz pieteikšanās formu
            this.Hide();
            Form fr2 = new Form8();
            fr2.Show();
        }

        private void btnRegistreties_Click(object sender, EventArgs e)
        {
            //poga aizvedīs uz reģistrācijas veidlapu
            this.Hide();
            Form fr9 = new Form9();
            fr9.Show();
        }
    }

    class global
    {
        //globālais mainīgais, lai saprastu, kurš lietotājs ir pieteicies
        public static string astr;
    }

    class global1
    {
        //globālo mainīgo izveidošana pirmajam lietotājam
        public static string psw1 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\pasword1.txt");
        public static string balance1 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\balance1.txt");
    }

    class global2
    {
        //globālo mainīgo izveidošana otrajam lietotājam
        public static string psw2 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\pasword2.txt");
        public static string balance2 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\balance2.txt");
    }

    class global3
    {
        //globālo mainīgo izveide trešajam lietotājam
        public static string psw3 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\pasword3.txt");
        public static string balance3 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\balance3.txt");
    }

    class global4
    {
        //globālo mainīgo izveide ceturtajam lietotājam
        public static string psw4 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\pasword4.txt");
        public static string balance4 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\balance4.txt");
    }
}
