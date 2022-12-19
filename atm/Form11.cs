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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            //pogu citai darbība
            this.Hide();
            Form fr4 = new Form4();
            fr4.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form fr24 = new Form24();
            fr24.Show();
        }
    }
}
