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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form fr12 = new Form12();
            fr12.Show();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            //pogu citai darbība
            this.Hide();
            Form fr3 = new Form3();
            fr3.Show();
        }

        private void labIzmaks_Click(object sender, EventArgs e)
        {
        }

        private void labTiesi_Click(object sender, EventArgs e)
        {
        }
    }
}
