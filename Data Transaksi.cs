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
    public partial class Data_Transaksi : Form
    {
        private string stringConnection = "data source=getto⛧\\RAYNANDA_AQIYAS;" + "database=Toko_Laptop;User ID=sa;Password=Zidanlagoa13";
        private SqlConnection koneksi;

        private void refreshform()
        {
            txtTransaksi.Text = "";
            cbxPenjual.Enabled = false;
            cbxPembeli.Enabled = false;
            cbxBarang.Enabled = false;
            cbxKurir.Enabled = false;
            cbxHarga.Enabled = false;
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnSave.Enabled = false;

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

        private void LoadIdPembeli()
        {
            string query = "SELECT id_pembeli FROM pembeli";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbxPembeli.DisplayMember = "id_pembeli";
            cbxPembeli.ValueMember = "id_pembeli";
            cbxPembeli.DataSource = dataTable;
        }

        private void LoadIdBarang()
        {
            string query = "SELECT id_barang FROM barang";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbxBarang.DisplayMember = "id_barang";
            cbxBarang.ValueMember = "id_barang";
            cbxBarang.DataSource = dataTable;
        }

        private void LoadIdKurir()
        {
            string query = "SELECT id_kurir FROM kurir";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbxKurir.DisplayMember = "id_kurir";
            cbxKurir.ValueMember = "id_kurir";
            cbxKurir.DataSource = dataTable;
        }

        private void LoadHarga()
        {
            string query = "SELECT harga FROM barang";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbxHarga.DisplayMember = "harga";
            cbxHarga.ValueMember = "harga";
            cbxHarga.DataSource = dataTable;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_transaksi, id_penjual, id_pembeli, id_barang, id_kurir, tanggal, harga from dbo.transaksi";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        public Data_Transaksi()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            refreshform();
            LoadHarga();
            LoadIdKurir();
            LoadIdBarang();
            LoadIdPembeli();
            LoadIdPenjual();
        }

        private void Data_Transaksi_Load(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            txtTransaksi.Enabled = true;
            cbxPenjual.Enabled = true;
            cbxPembeli.Enabled = true;
            cbxBarang.Enabled = true;
            cbxKurir.Enabled = true;
            DTPicker.Enabled = true;
            cbxHarga.Enabled = true;
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
            string idTransaksi = txtTransaksi.Text;
            string idPenjual = cbxPenjual.SelectedValue.ToString();
            string idPembeli = cbxPembeli.SelectedValue.ToString();
            string idBarang = cbxBarang.SelectedValue.ToString();
            string idKurir = cbxKurir.SelectedValue.ToString();
            string tanggal = DTPicker.Value.ToString("yyyy-MM-dd");
            string harga = cbxHarga.SelectedValue.ToString();

            if (idPenjual == "" || idPembeli == "" || idBarang == "" || idKurir == "" || tanggal == "" || harga == "")
            {
                MessageBox.Show("Lengkapi semua data transaksi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "INSERT INTO dbo.transaksi (id_transaksi, id_penjual, id_pembeli, id_barang, id_kurir, tanggal, harga)" +
                    "VALUES (@id_transaksi, @id_penjual, @id_pembeli, @id_barang, @id_kurir, @tanggal, @harga)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                cmd.Parameters.AddWithValue("@id_penjual", idPenjual);
                cmd.Parameters.AddWithValue("@id_pembeli", idPembeli);
                cmd.Parameters.AddWithValue("@id_barang", idBarang);
                cmd.Parameters.AddWithValue("@id_kurir", idKurir);
                cmd.Parameters.AddWithValue("@tanggal", tanggal);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data transaksi berhasil disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Anda yakin ingin menghapus data transaksi ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string idTransaksi = dataGridView1.SelectedRows[0].Cells["id_transaksi"].Value.ToString();

                    koneksi.Open();
                    string str = "DELETE FROM dbo.transaksi WHERE id_transaksi = @id_transaksi";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                    cmd.ExecuteNonQuery();
                    koneksi.Close();

                    MessageBox.Show("Data transaksi berhasil dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                    refreshform();
                }
            }
            else
            {
                MessageBox.Show("Pilih data transaksi yang akan dihapus", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idTransaksi = dataGridView1.SelectedRows[0].Cells["id_transaksi"].Value.ToString();
                string idPenjual = cbxPenjual.SelectedValue.ToString();
                string idPembeli = cbxPembeli.SelectedValue.ToString();
                string idBarang = cbxBarang.SelectedValue.ToString();
                string idKurir = cbxKurir.SelectedValue.ToString();
                string tanggal = DTPicker.Value.ToString("yyyy-MM-dd");
                string harga = cbxHarga.SelectedValue.ToString();

                if (idPenjual == "" || idPembeli == "" || idBarang == "" || idKurir == "" || tanggal == "" || harga == "")
                {
                    MessageBox.Show("Lengkapi semua data transaksi", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();
                    string str = "UPDATE dbo.transaksi SET id_penjual = @id_penjual, id_pembeli = @id_pembeli, id_barang = @id_barang, id_kurir = @id_kurir, tanggal = @tanggal, harga = @harga WHERE id_transaksi = @id_transaksi";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@id_penjual", idPenjual);
                    cmd.Parameters.AddWithValue("@id_pembeli", idPembeli);
                    cmd.Parameters.AddWithValue("@id_barang", idBarang);
                    cmd.Parameters.AddWithValue("@id_kurir", idKurir);
                    cmd.Parameters.AddWithValue("@tanggal", tanggal);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@id_transaksi", idTransaksi);
                    cmd.ExecuteNonQuery();

                    koneksi.Close();
                    MessageBox.Show("Data transaksi berhasil diperbarui", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView();
                    refreshform();
                }
            }
            else
            {
                MessageBox.Show("Pilih data transaksi yang akan diperbarui", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPenjual_Click(object sender, EventArgs e)
        {

        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {

        }

        private void btnMenyuplai_Click(object sender, EventArgs e)
        {
            Data_Menyuplai hu = new Data_Menyuplai();
            hu.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DataRelasi hu = new DataRelasi();
            hu.Show();
            this.Hide();
        }
    }
}
