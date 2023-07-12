using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingaJabrig_UAS
{
    public partial class DataKurir : Form
    {
        private string stringConnection = "data source=getto⛧\\RAYNANDA_AQIYAS;" + "database=Toko_Laptop;User ID=sa;Password=Zidanlagoa13";
        private SqlConnection koneksi;

        private void refreshform()
        {
            txtId.Text = "";
            txtNama.Text = "";
            txtTlp.Text = "";
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnSave.Enabled = false;

        }
        public DataKurir()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_kurir, nama_kurir, telepon from dbo.kurir";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataKurir_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idKurir = txtId.Text;
            string nmKurir = txtNama.Text;
            string Telepon = txtTlp.Text;

            if (nmKurir == "")
            {
                MessageBox.Show("Masukkan Nama Kurir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.kurir (id_kurir, nama_kurir, telepon)" + "values(@id_kurir, @nama_kurir, @telepon)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("nama_kurir", nmKurir));
                cmd.Parameters.Add(new SqlParameter("id_kurir", idKurir));
                cmd.Parameters.Add(new SqlParameter("telepon", Telepon));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNama.Enabled = true;
            txtTlp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string idKURIR = dataGridView1.SelectedRows[0].Cells["id_kurir"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.kurir WHERE id_kurir = @id_kurir";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id_kurir", idKURIR));
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                    refreshform();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPenjual_Click(object sender, EventArgs e)
        {
            DataPenjual hu = new DataPenjual();
            hu.Show();
            this.Hide();
        }

        private void btnPembeli_Click(object sender, EventArgs e)
        {
            DataPembeli hu = new DataPembeli();
            hu.Show();
            this.Hide();
        }

        private void btnProdusen_Click(object sender, EventArgs e)
        {
            DataProdusen hu = new DataProdusen();
            hu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataKurir hu = new DataKurir();
            hu.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataNamaBarang hu = new DataNamaBarang();
            hu.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idKurir = txtId.Text;
                string nmKurir = txtNama.Text;
                string Telepon = txtTlp.Text;

                if (string.IsNullOrEmpty(nmKurir))
                {
                    MessageBox.Show("Masukkan Nama Kurir", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string selectedIdKurir = dataGridView1.SelectedRows[0].Cells["id_kurir"].Value.ToString();

                    koneksi.Open();
                    string query = "UPDATE kurir SET id_kurir = @id_kurir, nama_kurir = @nama_kurir, telepon = @telepon WHERE id_kurir = @selectedIdKurir";
                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@id_kurir", idKurir);
                    cmd.Parameters.AddWithValue("@nama_kurir", nmKurir);
                    cmd.Parameters.AddWithValue("@telepon", Telepon);
                    cmd.Parameters.AddWithValue("@selectedIdKurir", selectedIdKurir);
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data Berhasil Diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                    refreshform();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diperbarui", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DNamaBarang hu = new DNamaBarang();
            hu.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DMaster hu = new DMaster();
            hu.Show();
            this.Hide();
        }
    }
}
