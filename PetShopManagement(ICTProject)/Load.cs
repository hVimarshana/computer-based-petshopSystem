using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShopManagement_ICTProject_
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            flowLayoutPanel1.Width += 3;

            if (flowLayoutPanel1.Width >= 599)
            {
                timer1.Stop();
                Login frm2 = new Login();
                frm2.Show();
                this.Hide();
            }
        }
    }
}
