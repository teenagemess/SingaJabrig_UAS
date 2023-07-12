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
    public partial class DNamaBarang : Form
    {
        private string stringConnection = "data source=getto⛧\\RAYNANDA_AQIYAS;" + "database=Toko_Laptop;User ID=sa;Password=Zidanlagoa13";
        private SqlConnection koneksi;

        private void refreshform()
        {
            txtKode.Text = "";
            txtNama.Text = "";
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnSave.Enabled = false;

        }
        public DNamaBarang()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select kode_barang, nama_barang from dbo.namabarang_barang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void DNamaBarang_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtKode.Enabled = true;
            txtNama.Enabled = true; 
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nmBarang = txtNama.Text;
            string kodeBarang = txtKode.Text;




            if (nmBarang == "")
            {
                MessageBox.Show("Masukkan Nama Barang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.namabarang_barang(nama_barang, kode_barang)" + "values(@nama_barang, @kode_barang)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("kode_barang", kodeBarang));
                cmd.Parameters.Add(new SqlParameter("nama_barang", nmBarang));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string kodeBarang = dataGridView1.SelectedRows[0].Cells["kode_barang"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.namabarang_barang WHERE kode_barang = @kode_barang";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("kode_barang", kodeBarang));
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string kodeBarang = dataGridView1.SelectedRows[0].Cells["kode_barang"].Value.ToString();

                string nmBarang = txtNama.Text;

                if (nmBarang == "")
                {
                    MessageBox.Show("Masukkan Nama Barang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();
                    string str = "UPDATE dbo.namabarang_barang SET nama_barang = @nama_barang WHERE kode_barang = @kode_barang";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("nama_barang", nmBarang));
                    cmd.Parameters.Add(new SqlParameter("kode_barang", kodeBarang));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                    refreshform();
                }
            }
            else
            {
                MessageBox.Show("Pilih data yang akan diperbarui", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataNamaBarang hu = new DataNamaBarang();
            hu.Show();
            this.Hide();
        }

        private void btnPembeli_Click(object sender, EventArgs e)
        {
            DataPembeli hu = new DataPembeli();
            hu.Show();
            this.Hide();
        }

        private void btnPenjual_Click(object sender, EventArgs e)
        {
            DataPenjual hu = new DataPenjual();
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

        private void button2_Click(object sender, EventArgs e)
        {
            DMaster hu = new DMaster();
            hu.Show();
            this.Hide();
        }
    }
}
