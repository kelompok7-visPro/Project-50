using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace final_project_vispro_50_persen
{
    public partial class dashboard : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public dashboard()
        {
            alamat = "server=localhost; database=db_alaise; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            service Service = new service();
            Service.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
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

        private void lblservices_Click(object sender, EventArgs e)
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

        private void lblkitchens_Click(object sender, EventArgs e)
        {
            kitchen Kitchen = new kitchen();
            Kitchen.Show();
            this.Hide();
        }

        private void lblbars_Click(object sender, EventArgs e)
        {
            bar Bar = new bar();
            Bar.Show();
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
            itemout Itemout = new itemout();
            Itemout.Show();
            this.Hide();
        }
    }
}
