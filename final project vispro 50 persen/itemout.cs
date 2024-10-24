using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project_vispro_50_persen
{
    public partial class itemout : Form
    {
        public itemout()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblitemin_Click(object sender, EventArgs e)
        {
            itemin Itemin = new itemin();
            Itemin.Show();
            this.Hide();
        }

        private void lblservice_Click(object sender, EventArgs e)
        {
            service Service = new service();
            Service.Show();
            this.Hide();
        }

        private void lblkitchen_Click(object sender, EventArgs e)
        {
            kitchen Kitchen = new kitchen();
            Kitchen.Show();
            this.Hide();
        }

        private void lblbar_Click(object sender, EventArgs e)
        {
            bar Bar = new bar();
            Bar.Show();
            this.Hide();
        }
    }
}
