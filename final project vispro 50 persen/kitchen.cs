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
    public partial class kitchen : Form
    {
        public kitchen()
        {
            InitializeComponent();
        }

        private void lblout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void lblservice_Click(object sender, EventArgs e)
        {
            service Service = new service();
            Service.Show();
            this.Hide();
        }

        private void lblbar_Click(object sender, EventArgs e)
        {
            bar Bar = new bar();
            Bar.Show();
            this.Hide();
        }

        private void lblitemin_Click(object sender, EventArgs e)
        {
            itemin Itemin = new itemin();
            Itemin.Show();
            this.Hide();
        }

        private void lblitemout_Click(object sender, EventArgs e)
        {

        }
    }
}
