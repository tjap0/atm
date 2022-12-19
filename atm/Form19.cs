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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            //pogu citai darbība
            this.Hide();
            Form fr6 = new Form6();
            fr6.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form fr12 = new Form12();
            fr12.Show();
        }
    }
}
