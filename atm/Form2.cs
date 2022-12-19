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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void labAtvainojiet_Click(object sender, EventArgs e)
        {
        }

        private void btnCita_Click(object sender, EventArgs e)
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
            Form fr22 = new Form22();
            fr22.Show();
        }
    }
}
