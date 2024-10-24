using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace final_project_vispro_50_persen
{
    public partial class itemin : Form
    {
        public itemin()
        {
            alamat = "server=localhost; database=db_alaise; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void lblitemout_Click(object sender, EventArgs e)
        {
            itemout Itemout = new itemout();
            Itemout.Show();
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
