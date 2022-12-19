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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void textBoxSum_TextChanged(object sender, EventArgs e)
        {
            //kodu, lai lietotājs varētu ievadīt tikai 7 ciparus
            textBoxSum.MaxLength = 7;
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
            Form fr20 = new Form20();
            fr20.Show();
        }

        private void btnGatavs_Click(object sender, EventArgs e)
        {
            /*mainīgais, lai saglabātu, cik daudz viņi vēlas izņemt, 
             * un starpību starp atlikumiem un summu, cik daudz viņi vēlas izņemt*/
            string getMoney = textBoxSum.Text;
            int minus;

            //mainīgo lielumu atkārtota inicializācija
            global1.balance1 = File.ReadAllText("balance1.txt");
            global2.balance2 = File.ReadAllText("balance2.txt");
            global3.balance3 = File.ReadAllText("balance3.txt");
            global4.balance4 = File.ReadAllText("balance4.txt");

            //noteikt, kura parole ir ievadīta Ienakt formā
            if (global.astr == global1.psw1)
            {
                //pārbaudiet, vai vēlamā izņemamā summa ir lielāka nekā atlikumā
                if (Convert.ToInt32(getMoney) > Convert.ToInt32(global1.balance1))
                {
                    MessageBox.Show("Jūsu kontā nav pietiekami daudz līdzekļu.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //pārbaudot, vai vēlamā izņemamā summa ir lielāka par 10 000 (maksimālā sējamā summa)
                else if (Convert.ToInt32(getMoney) > 10000)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs nevarat izņemt vairāk par        10 000 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //pārbaudot, vai vēlamā summa ir 0
                else if (Convert.ToInt32(getMoney) == 0)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs varat izņemt tikai vairāk par 0 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //ja viss ir pareizi, izņemam naudu
                else
                {
                    minus = Convert.ToInt32(global1.balance1) - Convert.ToInt32(getMoney);
                    File.WriteAllText("balance1.txt", Convert.ToString(minus));
                    this.Hide();
                    Form fr11 = new Form11();
                    fr11.Show();
                }
            }
            else if (global.astr == global2.psw2)
            {
                if (Convert.ToInt32(getMoney) > Convert.ToInt32(global2.balance2))
                {
                    MessageBox.Show("Jūsu kontā nav pietiekami daudz līdzekļu.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(getMoney) > 10000)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs nevarat izņemt vairāk par        10 000 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(getMoney) == 0)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs varat izņemt tikai vairāk par 0 €", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    minus = Convert.ToInt32(global2.balance2) - Convert.ToInt32(getMoney);
                    File.WriteAllText("balance2.txt", Convert.ToString(minus));
                    this.Hide();
                    Form fr11 = new Form11();
                    fr11.Show();
                }
            }
            else if (global.astr == global3.psw3)
            {
                if (Convert.ToInt32(getMoney) > Convert.ToInt32(global3.balance3))
                {
                    MessageBox.Show("Jūsu kontā nav pietiekami daudz līdzekļu.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(getMoney) > 10000)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs nevarat izņemt vairāk par        10 000 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(getMoney) == 0)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs varat izņemt tikai vairāk par 0 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    minus = Convert.ToInt32(global3.balance3) - Convert.ToInt32(getMoney);
                    File.WriteAllText("balance3.txt", Convert.ToString(minus));
                    this.Hide();
                    Form fr11 = new Form11();
                    fr11.Show();
                }
            }
            else
            {
                if (Convert.ToInt32(getMoney) > Convert.ToInt32(global4.balance4))
                {
                    MessageBox.Show("Jūsu kontā nav pietiekami daudz līdzekļu.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(getMoney) > 10000)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs nevarat izņemt vairāk par        10 000 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Convert.ToInt32(getMoney) == 0)
                {
                    MessageBox.Show("Atvainojiet! No sava konta Jūs varat izņemt tikai vairāk par 0 €.", "Kļūda", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    minus = Convert.ToInt32(global4.balance4) - Convert.ToInt32(getMoney);
                    File.WriteAllText("balance4.txt", Convert.ToString(minus));
                    this.Hide();
                    Form fr11 = new Form11();
                    fr11.Show();
                }
            }
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
