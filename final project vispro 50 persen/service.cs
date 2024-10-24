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
    public partial class service : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public service()
        {
            alamat = "server=localhost; database=db_alaise; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void lbldashboard_Click(object sender, EventArgs e)
        {

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

        private void service_Load(object sender, EventArgs e)
        {

        }
    }
}
