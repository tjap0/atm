using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atm
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //kodu, lai aizvērtu programmu pēc 2 sekundēm
            new Thread(() => { Thread.Sleep(2000); Application.Exit(); }).Start();
        }
    }
}
