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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnKonta_Click(object sender, EventArgs e)
        {
        }

        private void labNumbers_Click(object sender, EventArgs e)
        {
        }

        private void btnShowBalance_Click(object sender, EventArgs e)
        {
            //slēpt bankas kontu
            labNumbers.Text = "**********************";
            button1.Show();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            ////pogu citai darbībai
            this.Hide();
            Form fr4 = new Form4();
            fr4.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            ////izejas poga
            this.Hide();
            Form fr18 = new Form18();
            fr18.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mainīgo lielumu atkārtota inicializācija
            global1.balance1 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\balance1.txt");
            global2.balance2 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\balance2.txt");
            global3.balance3 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\balance3.txt");
            global4.balance4 = File.ReadAllText(@"C:\Users\nikvi\Documents\c#\atm\atm\bin\Debug\balance4.txt");

            //noteikt, kura parole ir ievadīta Ienakt formā
            if (global.astr == global1.psw1)
            {
                button1.Hide();
                labNumbers.Text = global1.balance1 + " €";
            }
            else if (global.astr == global2.psw2)
            {
                button1.Hide();
                labNumbers.Text = global2.balance2 + " €";
            }
            else if (global.astr == global3.psw3)
            {
                button1.Hide();
                labNumbers.Text = global3.balance3 + " €";
            }
            else
            {
                button1.Hide();
                labNumbers.Text = global4.balance4 + " €";
            }
        }
    }
}
