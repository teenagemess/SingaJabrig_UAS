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
    public partial class DataProdusen : Form
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
        public DataProdusen()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_produsen, nama_produsen, telepon from dbo.produsen";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void DataProdusen_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            {
                string idProdusen = txtId.Text;
                string nmProdusen = txtNama.Text;
                string Telepon = txtTlp.Text;

                if (nmProdusen == "")
                {
                    MessageBox.Show("Masukkan Nama Pembeli", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();
                    string str = "insert into dbo.produsen (id_produsen, nama_produsen, telepon)" + "values(@id_produsen, @nama_produsen, @telepon)";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("nama_produsen", nmProdusen));
                    cmd.Parameters.Add(new SqlParameter("id_produsen", idProdusen));
                    cmd.Parameters.Add(new SqlParameter("telepon", Telepon));
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                    refreshform();
                }
            }
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
                    string idPRODUSEN = dataGridView1.SelectedRows[0].Cells["id_produsen"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.produsen WHERE id_produsen = @id_produsen";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("id_produsen", idPRODUSEN));
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

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtNama.Enabled = true;
            txtTlp.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idProdusen = txtId.Text;
                string nmProdusen = txtNama.Text;
                string Telepon = txtTlp.Text;

                if (string.IsNullOrEmpty(nmProdusen))
                {
                    MessageBox.Show("Masukkan Nama Produsen", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    string selectedIdProdusen = dataGridView1.SelectedRows[0].Cells["id_produsen"].Value.ToString();

                    koneksi.Open();
                    string query = "UPDATE produsen SET id_produsen = @id_produsen, nama_produsen = @nama_produsen, telepon = @telepon WHERE id_produsen = @selectedIdProdusen";
                    SqlCommand cmd = new SqlCommand(query, koneksi);
                    cmd.Parameters.AddWithValue("@id_produsen", idProdusen);
                    cmd.Parameters.AddWithValue("@nama_produsen", nmProdusen);
                    cmd.Parameters.AddWithValue("@telepon", Telepon);
                    cmd.Parameters.AddWithValue("@selectedIdProdusen", selectedIdProdusen);
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
