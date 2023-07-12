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
    public partial class DataPembeli : Form
    {
        private string stringConnection = "data source=getto⛧\\RAYNANDA_AQIYAS;" + "database=Toko_Laptop;User ID=sa;Password=Zidanlagoa13";
        private SqlConnection koneksi;

        private void refreshform()
        {
            txtId.Text = "";
            txtNama.Text = "";
            txtKec.Text = "";
            txtJl.Text = "";
            txtTlp.Text = "";
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnSave.Enabled = false;

        }
        public DataPembeli()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }
        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_pembeli, nama_pembeli, kecamatan, jalan, telepon from dbo.pembeli";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }
        private void DataPembeli_Load(object sender, EventArgs e)
        {
 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idPembeli = txtId.Text;
            string nmPembeli = txtNama.Text;
            string alKecamatan = txtKec.Text;
            string alJalan = txtJl.Text;
            string Telepon = txtTlp.Text;

            if (nmPembeli == "")
            {
                MessageBox.Show("Masukkan Nama Pembeli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.pembeli (id_pembeli, nama_pembeli, kecamatan, jalan, telepon)" + "values(@id_pembeli, @nama_pembeli, @kecamatan, @jalan, @telepon)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("nama_pembeli", nmPembeli));
                cmd.Parameters.Add(new SqlParameter("id_pembeli", idPembeli));
                cmd.Parameters.Add(new SqlParameter("kecamatan", alKecamatan));
                cmd.Parameters.Add(new SqlParameter("jalan", alJalan));
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
            txtKec.Enabled = true;
            txtJl.Enabled = true;
            txtTlp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnPenjual_Click(object sender, EventArgs e)
        {
            DataPenjual hu = new DataPenjual();
            hu.Show();
            this.Hide();
        }

        private void btnPembeli_Click(object sender, EventArgs e)
        {

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string idPEMBELI = dataGridView1.SelectedRows[0].Cells["id_pembeli"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.pembeli WHERE id_pembeli = @id_pembeli";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id_pembeli", idPEMBELI));
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idPembeli = txtId.Text;
                string nmPembeli = txtNama.Text;
                string alKecamatan = txtKec.Text;
                string alJalan = txtJl.Text;
                string Telepon = txtTlp.Text;

                if (string.IsNullOrEmpty(nmPembeli))
                {
                    MessageBox.Show("Masukkan Nama Pembeli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string selectedIdPembeli = dataGridView1.SelectedRows[0].Cells["id_pembeli"].Value.ToString();

                    koneksi.Open();
                    string query = "UPDATE pembeli SET id_pembeli = @id_pembeli, nama_pembeli = @nama_pembeli, kecamatan = @kecamatan, jalan = @jalan, telepon = @telepon WHERE id_pembeli = @selectedIdPembeli";
                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@id_pembeli", idPembeli);
                    cmd.Parameters.AddWithValue("@nama_pembeli", nmPembeli);
                    cmd.Parameters.AddWithValue("@kecamatan", alKecamatan);
                    cmd.Parameters.AddWithValue("@jalan", alJalan);
                    cmd.Parameters.AddWithValue("@telepon", Telepon);
                    cmd.Parameters.AddWithValue("@selectedIdPembeli", selectedIdPembeli);
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
