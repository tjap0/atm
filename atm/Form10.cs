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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void btnCita_Click(object sender, EventArgs e)
        {
            //izejas poga
            this.Hide();
            Form fr4 = new Form4();
            fr4.Show();
        }

        private void btnIziet_Click(object sender, EventArgs e)
        {
            //pogu citai darbībai
            this.Hide();
            Form fr23 = new Form23();
            fr23.Show();
        }

        private void labIemaks_Click(object sender, EventArgs e)
        {

        }

        private void labPaldies_Click(object sender, EventArgs e)
        {

        }
    }
}
