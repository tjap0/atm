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
    public partial class Form7Switch : Form
    {
        public Form7Switch()
        {
            InitializeComponent();
        }

        private void btnCIta_Click(object sender, EventArgs e)
        {
            //pogu citai darbībai
            this.Hide();
            Form fr4 = new Form4();
            fr4.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form fr21 = new Form21();
            fr21.Show();
        }

        private void btnGatavs_Click(object sender, EventArgs e)
        {
            /*mainīgais, lai saglabātu, cik daudz viņi vēlas iemakst, 
             * un starpību starp atlikumiem un summu, cik daudz viņi vēlas iemakst*/
            string putMoney = textBoxSum.Text;
            int putBalance;

            //mainīgo lielumu atkārtota inicializācija
            global1.balance1 = File.ReadAllText("balance1.txt");
            global2.balance2 = File.ReadAllText("balance2.txt");
            global3.balance3 = File.ReadAllText("balance3.txt");
            global4.balance4 = File.ReadAllText("balance4.txt");

            //noteikt, kura parole ir ievadīta Ienakt formā
            if (global.astr == global1.psw1)
            {
                //pārbaudot, vai vēlamā iemaksas summa ir lielāka par 10 000 (maksimālā sējamā summa)
                if (Convert.ToInt32(putMoney) > 10000)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs nevarat iemaksāt vairāk par        10 000 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //pārbaudot, vai vēlamā summa ir 0
                else if (Convert.ToInt32(putMoney) == 0)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs varat iemaksāt tikai vairāk nekā 0 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //ja viss ir pareizi, mēs ieskaitām naudu kontā
                else
                {
                    putBalance = Convert.ToInt32(putMoney) + Convert.ToInt32(global1.balance1);
                    File.WriteAllText("balance1.txt", Convert.ToString(putBalance));
                    this.Hide();
                    Form fr10 = new Form10();
                    fr10.Show();
                }
            }
            else if (global.astr == global2.psw2)
            {
                if (Convert.ToInt32(putMoney) > 10000)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs nevarat iemaksāt vairāk par        10 000 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(putMoney) == 0)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs varat iemaksāt tikai vairāk nekā 0 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    putBalance = Convert.ToInt32(putMoney) + Convert.ToInt32(global2.balance2);
                    File.WriteAllText("balance2.txt", Convert.ToString(putBalance));
                    this.Hide();
                    Form fr10 = new Form10();
                    fr10.Show();
                }
            }
            else if (global.astr == global3.psw3)
            {
                if (Convert.ToInt32(putMoney) > 10000)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs nevarat iemaksāt vairāk par        10 000 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(putMoney) == 0)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs varat iemaksāt tikai vairāk nekā 0 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    putBalance = Convert.ToInt32(putMoney) + Convert.ToInt32(global3.balance3);
                    File.WriteAllText("balance3.txt", Convert.ToString(putBalance));
                    this.Hide();
                    Form fr10 = new Form10();
                    fr10.Show();
                }
            }
            else
            {
                if (Convert.ToInt32(putMoney) > 10000)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs nevarat iemaksāt vairāk par        10 000 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(putMoney) == 0)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs varat iemaksāt tikai vairāk nekā 0 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    putBalance = Convert.ToInt32(putMoney) + Convert.ToInt32(global4.balance4);
                    File.WriteAllText("balance4.txt", Convert.ToString(putBalance));
                    this.Hide();
                    Form fr10 = new Form10();
                    fr10.Show();
                }
            }
        }     

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            //kodu, lai lietotājs varētu ievadīt tikai 7 ciparus
            textBoxSum.MaxLength = 7;
        }

        private void textBoxSum_KeyPress(object sender, KeyPressEventArgs e)
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
