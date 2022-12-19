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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
       
        private void labPin_Click(object sender, EventArgs e)
        {
        }

        private void labIenakt_Click(object sender, EventArgs e)
        {
        }

        private void textBoxIenakt_TextChanged(object sender, EventArgs e)
        {
            /*kodu, lai lietotājs varētu ievadīt tikai 4 ciparus, 
            * un arī šie cipari tiek parādīti kā zvaigznītes*/
            textBoxIenakt.PasswordChar = '*';
            textBoxIenakt.MaxLength = 4;
        }

        private void btnGatavs_Click(object sender, EventArgs e)
        {
            //globālo mainīgo inicializācija
            global.astr = textBoxIenakt.Text;
            global1.psw1 = File.ReadAllText("pasword1.txt");
            global2.psw2 = File.ReadAllText("pasword2.txt");
            global3.psw3 = File.ReadAllText("pasword3.txt");
            global4.psw4 = File.ReadAllText("pasword4.txt");

            //ja lietotājs ievadīja 4 ciparus
            if (global.astr.Length == 4)
            {
                //pārbaudot, vai lietotājs pastāv vai nē
                if (global.astr == global1.psw1 || global.astr == global2.psw2 || global.astr == global3.psw3 || global.astr == global4.psw4)
                {
                    //ja tā, tas tiks atvērts operāciju veidlapā
                    this.Hide();
                    Form fr4 = new Form4();
                    fr4.Show();
                }
                else
                {
                    //ja nē, tiek parādīts kļūdas ziņojums
                    MessageBox.Show("Jūs ievadījāt nepareizu paroli", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxIenakt.Clear();
                }
            }
            //ja lietotājs ievadījis mazāk par 4 cipariem
            else
            {
                MessageBox.Show("Jums ir jāievada 4 cipari", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxIenakt.Clear();
            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {
        }

        private void textBoxIenakt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //kods, lai atspējotu burtu un simbolu ievadi, tikai burtus un atpakaļatkāpes atkāpi
            char numbers = e.KeyChar;

            if (!Char.IsDigit(numbers) && numbers != 8)
            {
                e.Handled = true;
            }
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form13 fr13 = new Form13();
            fr13.Show();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            //pogu citai darbībai
            this.Hide();
            Form1 fr1 = new Form1();
            fr1.Show();
        }
    }
}
