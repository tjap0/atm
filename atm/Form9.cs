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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnGatavs_Click(object sender, EventArgs e)
        {
            //veidojot mainīgo ar vērtību no teksta lauka
            string astr = textBoxRegistreties.Text;

            //ja lietotājs ievadīja 4 ciparus
            if (astr.Length == 4) 
            {
                //konta brīvas vietas pārbaude
                if (global1.psw1.Length == 0)
                {
                    File.WriteAllText("pasword1.txt", astr);
                    this.Hide();
                    Form fr14 = new Form14();
                    fr14.Show();
                }
                else if (global2.psw2.Length == 0)
                {
                    File.WriteAllText("pasword2.txt", astr);
                    this.Hide();
                    Form fr14 = new Form14();
                    fr14.Show();
                }
                else if (global3.psw3.Length == 0)
                {
                    File.WriteAllText("pasword3.txt", astr);
                    this.Hide();
                    Form fr14 = new Form14();
                    fr14.Show();
                }
                else if (global4.psw4.Length == 0)
                {
                    File.WriteAllText("pasword4.txt", astr);
                    this.Hide();
                    Form fr14 = new Form14();
                    fr14.Show();
                }
                else
                {
                    MessageBox.Show("Šobrīd visas vietas aizņemtas, vari sazināties ar adminu un viņš šo problēmu atrisinās", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    this.Hide();
                    Form fr12 = new Form12();
                    fr12.Show();
                }
            }
            //ja lietotājs ievadījis mazāk par 4 cipariem
            else
            {
                MessageBox.Show("Jums ir jāievada 4 cipari", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRegistreties.Clear();
            }
        }

        private void textBoxRegistreties_TextChanged(object sender, EventArgs e)
        {
            /*kodu, lai lietotājs varētu ievadīt tikai 4 ciparus, 
            * un arī šie cipari tiek parādīti kā zvaigznītes*/
            textBoxRegistreties.PasswordChar= '*';
            textBoxRegistreties.MaxLength = 4;
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            //pogu citai darbībai
            this.Hide();
            Form fr1 = new Form1();
            fr1.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form fr16 = new Form16();
            fr16.Show();
        }

        private void textBoxRegistreties_KeyPress(object sender, KeyPressEventArgs e)
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
