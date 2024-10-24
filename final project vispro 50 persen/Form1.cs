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
    public partial class Form1 : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;

        private DataSet ds = new DataSet();
        private string alamat, query;
        public Form1()
        {
            alamat = "server=localhost; database=db_alaise; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click_1(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("select * from tbl_admin where username = '{0}'", txtusername.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        sandi = kolom["password"].ToString();
                        if (sandi == txtpassword.Text)
                        {
                            dashboard Home = new dashboard();
                            Home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Anda salah input password");
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username tidak ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            
        }
    }
}
