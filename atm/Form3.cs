using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void labAtvainojiet_Click(object sender, EventArgs e)
        {
        }

        private void btnVelreiz_Click(object sender, EventArgs e)
        {

            //nosūta, lai atkārtoti ievadītu paroli
            this.Hide();
            Form fr8 = new Form8();
            fr8.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            ////izejas poga
            this.Hide();
            Form fr15 = new Form15();
            fr15.Show();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            ////pogu citai darbībai
            this.Hide();
            Form fr1 = new Form1();
            fr1.Show();
        }
    }
}
