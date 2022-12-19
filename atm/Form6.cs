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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void labIevadietPin_Click(object sender, EventArgs e)
        {
        }

        private void btnGatavs_Click(object sender, EventArgs e)
        {
            //globālo mainīgo inicializācija
            global1.psw1 = File.ReadAllText("pasword1.txt");
            global2.psw2 = File.ReadAllText("pasword2.txt");
            global3.psw3 = File.ReadAllText("pasword3.txt");
            global4.psw4 = File.ReadAllText("pasword4.txt");

            //mainīgie vecajai un jaunajai parolei
            string lastPsw = textBoxPin1.Text;
            string newPsw = textBoxPin2.Text;

            if (lastPsw.Length == 4 && newPsw.Length == 4)
            {
                //noteikt, kura parole ir ievadīta Ienakt formā
                if (global.astr == global1.psw1)
                {
                    //pārbaudot, vai ievadītā parole ir vecā
                    if (global.astr != lastPsw)
                    {
                        MessageBox.Show("Jūs esat ievadījis nepareizu pašreizējo PIN kodu.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPin1.Clear();
                    }
                    //pārbaudot, vai lietotājs mēģina mainīt uz to pašu paroli, kāda viņam ir pašlaik
                    else if (global.astr == newPsw)
                    {
                        MessageBox.Show("Jūsu jaunais PIN kods nedrīkst būt tāds pats kā pašreizējais.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPin2.Clear();
                    }
                    //ja viss ir pareizi, pierakstiet jaunu paroli
                    else
                    {
                        File.WriteAllText("pasword1.txt", newPsw);
                        this.Hide();
                        Form fr2 = new Form2();
                        fr2.Show();
                    }
                }
                else if (global.astr == global2.psw2)
                {
                    if (global.astr != lastPsw)
                    {
                        MessageBox.Show("Jūs esat ievadījis nepareizu pašreizējo PIN kodu.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPin1.Clear();
                    }
                    else if (global.astr == newPsw)
                    {
                        MessageBox.Show("Jūsu jaunais PIN kods nedrīkst būt tāds pats kā pašreizējais.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPin2.Clear();
                    }
                    else
                    {
                        File.WriteAllText("pasword2.txt", newPsw);
                        this.Hide();
                        Form fr2 = new Form2();
                        fr2.Show();
                    }
                }
                else if (global.astr == global3.psw3)
                {
                    if (global.astr != lastPsw)
                    {
                        MessageBox.Show("Jūs esat ievadījis nepareizu pašreizējo PIN kodu.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPin1.Clear();
                    }
                    else if (global.astr == newPsw)
                    {
                        MessageBox.Show("Jūsu jaunais PIN kods nedrīkst būt tāds pats kā pašreizējais.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPin2.Clear();
                    }
                    else
                    {
                        File.WriteAllText("pasword3.txt", newPsw);
                        this.Hide();
                        Form fr2 = new Form2();
                        fr2.Show();
                    }
                }
                else
                {
                    if (global.astr != lastPsw)
                    {
                        MessageBox.Show("Jūs esat ievadījis nepareizu pašreizējo PIN kodu.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPin1.Clear();
                    }
                    else if (global.astr == newPsw)
                    {
                        MessageBox.Show("Jūsu jaunais PIN kods nedrīkst būt tāds pats kā pašreizējais.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxPin2.Clear();
                    }
                    else
                    {
                        File.WriteAllText("pasword4.txt", newPsw);
                        this.Hide();
                        Form fr2 = new Form2();
                        fr2.Show();
                    }
                }
            }
            //ja lietotājs kādā no laukiem ir ievadījis mazāk par 4 cipariem
            else
            {
                MessageBox.Show("Jums ir jāievada 4 cipari. \r\nLūdzu, pārbaudiet ciparu skaitu 1. un 2. laukā!", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCIta_Click(object sender, EventArgs e)
        {
            ////pogu citai darbībai
            this.Hide();
            Form fr4 = new Form4();
            fr4.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form fr19 = new Form19();
            fr19.Show();
        }

        private void textBoxPin1_TextChanged(object sender, EventArgs e)
        {
            /*kodu, lai lietotājs varētu ievadīt tikai 4 ciparus, 
            * un arī šie cipari tiek parādīti kā zvaigznītes*/
            textBoxPin1.PasswordChar = '*';
            textBoxPin1.MaxLength = 4;
        }

        private void textBoxPin2_TextChanged(object sender, EventArgs e)
        {
            /*kodu, lai lietotājs varētu ievadīt tikai 4 ciparus, 
            * un arī šie cipari tiek parādīti kā zvaigznītes*/
            textBoxPin2.PasswordChar= '*';
            textBoxPin2.MaxLength = 4;
        }

        private void textBoxPin1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kods, lai atspējotu burtu un simbolu ievadi, tikai burtus un atpakaļatkāpes atkāpi
            char numbers = e.KeyChar;

            if (!Char.IsDigit(numbers) && numbers != 8)
            {
                e.Handled = true;
            }
        }

        private void textBoxPin2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kods, lai atspējotu burtu un simbolu ievadi, tikai burtus un atpakaļatkāpes atkāpi
            char numbers = e.KeyChar;

            if (!Char.IsDigit(numbers) && numbers != 8)
            {
                e.Handled = true;
            }
        }
    }
}
