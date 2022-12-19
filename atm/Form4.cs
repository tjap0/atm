using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void labDarijumu_Click(object sender, EventArgs e)
        {
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form fr17 = new Form17();
            fr17.Show();
        }

        private void btnAtlikums_Click(object sender, EventArgs e)
        {
            //pārskaitījums uz veidlapu ar atlikumu kontā
            this.Hide();
            Form fr5 = new Form5();
            fr5.Show();
        }

        private void btnMainitPin_Click(object sender, EventArgs e)
        {
            //pārsūtiet uz formu, kurā varat mainīt paroli
            this.Hide();
            Form fr6 = new Form6();
            fr6.Show();
        }

        private void btnNaudasIzm_Click(object sender, EventArgs e)
        {
            //pārskaitījums uz veidlapu, kurā var izņemt naudu
            this.Hide();
            Form fr7 = new Form7();
            fr7.Show();
        }

        private void btnNaudasIem_Click(object sender, EventArgs e)
        {
            //pārskaitījumu uz formu, kur var ielikt naudu
            this.Hide();
            Form fr7s = new Form7Switch();
            fr7s.Show();
        }
    }
}
