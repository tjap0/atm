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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            //pogu citai darbība
            Form1 fr1 = new Form1();
            fr1.Refresh();
            this.Hide();
            Form8 fr8 = new Form8();
            fr8.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form fr25 = new Form25();
            fr25.Show();
        }
    }
}
