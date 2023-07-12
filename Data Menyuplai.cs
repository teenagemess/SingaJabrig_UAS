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
    public partial class Data_Menyuplai : Form
    {
        private string stringConnection = "data source=getto⛧\\RAYNANDA_AQIYAS;" + "database=Toko_Laptop;User ID=sa;Password=Zidanlagoa13";
        private SqlConnection koneksi;

        private void refreshform()
        {
            cbxPenjual.Enabled = false;
            txtSupply.Text = "";
            cbxPenjual.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnSave.Enabled = false;

        }

        private void LoadIdProdusen()
        {
            string query = "SELECT id_produsen FROM produsen";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbxProdusen.DisplayMember = "id_produsen";
            cbxProdusen.ValueMember = "id_produsen";
            cbxProdusen.DataSource = dataTable;
        }

        private void LoadIdPenjual()
        {
            string query = "SELECT id_penjual FROM penjual";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbxPenjual.DisplayMember = "id_penjual";
            cbxPenjual.ValueMember = "id_penjual";
            cbxPenjual.DataSource = dataTable;
        }
        public Data_Menyuplai()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            LoadIdPenjual();
            LoadIdProdusen();
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_suplai, id_produsen, id_penjual, tanggal from dbo.menyuplai";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cbxPenjual.Enabled = true;
            txtSupply.Enabled = true;
            cbxPenjual.Enabled = true;
            btnAdd.Enabled = false;
            btnClear.Enabled = true;
            btnSave.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            refreshform();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idSupply = txtSupply.Text;
            string idProdusen = cbxProdusen.SelectedValue.ToString();
            string idPenjual = cbxPenjual.SelectedValue.ToString();
            DateTime tgl = DTPicker.Value;

            if (string.IsNullOrEmpty(idProdusen) || string.IsNullOrEmpty(idPenjual) || tgl == null || idSupply == "")
            {
                MessageBox.Show("Please fill in all the required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string query = "INSERT INTO menyuplai (id_suplai, id_produsen, id_penjual, tanggal) VALUES (@id_suplai, @id_produsen, @id_penjual, @tanggal)";
                SqlCommand cmd = new SqlCommand(query, koneksi);
                cmd.Parameters.AddWithValue("@id_suplai", idSupply);
                cmd.Parameters.AddWithValue("@id_produsen", idProdusen);
                cmd.Parameters.AddWithValue("@id_penjual", idPenjual);
                cmd.Parameters.AddWithValue("@tanggal", tgl);
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data Berhasil Disimpan", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Mengecek apakah ada baris yang dipilih di DataGridView
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Mendapatkan id_suplai dari baris yang dipilih
                string idSuplai = dataGridView1.SelectedRows[0].Cells["id_suplai"].Value.ToString();

                // Konfirmasi penghapusan data
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        // Menghapus data dari database
                        koneksi.Open();
                        string query = "DELETE FROM menyuplai WHERE id_suplai = @id_suplai";
                        SqlCommand cmd = new SqlCommand(query, koneksi);
                        cmd.Parameters.AddWithValue("@id_suplai", idSuplai);
                        cmd.ExecuteNonQuery();
                        koneksi.Close();
                        MessageBox.Show("Data successfully deleted!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dataGridView();
                        refreshform();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while deleting the record: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Data_Menyuplai_Load(object sender, EventArgs e)
        {

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
            Data_Transaksi hu = new Data_Transaksi();
            hu.Show();
            this.Hide();
        }

        private void btnKurir_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataNamaBarang hu = new DataNamaBarang();
            hu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DNamaBarang hu = new DNamaBarang();
            hu.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DataRelasi hu = new DataRelasi();
            hu.Show();
            this.Hide();
        }
    }
}
