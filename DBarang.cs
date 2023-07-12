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
    public partial class DataNamaBarang : Form
    {
        private string stringConnection = "data source=getto⛧\\RAYNANDA_AQIYAS;" + "database=Toko_Laptop;User ID=sa;Password=Zidanlagoa13";
        private SqlConnection koneksi;

        private void refreshform()
        {
            txtId.Text = "";
            cbxKode.Enabled = false;    
            txtHarga.Text = "";
            btnAdd.Enabled = true;
            btnClear.Enabled = false;
            btnSave.Enabled = false;

        }
        public DataNamaBarang()
        {
            InitializeComponent();
            koneksi = new SqlConnection(stringConnection);
            LoadKodeBarang();
            refreshform();
        }

        private void LoadKodeBarang()
        {
            string query = "SELECT kode_barang FROM namabarang_barang";
            SqlDataAdapter adapter = new SqlDataAdapter(query, koneksi);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            cbxKode.DisplayMember = "kode_barang";
            cbxKode.ValueMember = "kode_barang";
            cbxKode.DataSource = dataTable;
        }

        private void dataGridView()
        {
            koneksi.Open();
            string str = "select id_barang, kode_barang, harga from dbo.barang";
            SqlDataAdapter da = new SqlDataAdapter(str, koneksi);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            koneksi.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            dataGridView();
            btnOpen.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string idBarang = txtId.Text;
            string kodeBarang = cbxKode.SelectedValue.ToString();
            string Harga = txtHarga.Text;



            if (kodeBarang == "")
            {
                MessageBox.Show("Masukkan Kode Barang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                koneksi.Open();
                string str = "insert into dbo.barang(id_barang, kode_barang, harga)" + "values(@id_barang, @kode_barang, @harga)";
                SqlCommand cmd = new SqlCommand(str, koneksi);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@kode_barang", kodeBarang);
                cmd.Parameters.Add(new SqlParameter("id_barang", idBarang));
                cmd.Parameters.Add(new SqlParameter("harga", Harga));
                cmd.ExecuteNonQuery();

                koneksi.Close();
                MessageBox.Show("Data berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView();
                refreshform();
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

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            cbxKode.Enabled = true;
            btnSave.Enabled = true;
            btnClear.Enabled = true;
            btnAdd.Enabled = false;
        }

        private void DataBarang_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DNamaBarang hu = new DNamaBarang();
            hu.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string idBarang = dataGridView1.SelectedRows[0].Cells["id_barang"].Value.ToString();

                string kodeBarang = cbxKode.SelectedValue.ToString();
                string harga = txtHarga.Text;

                if (kodeBarang == "")
                {
                    MessageBox.Show("Masukkan Kode Barang", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    koneksi.Open();
                    string str = "UPDATE dbo.barang SET kode_barang = @kode_barang, harga = @harga WHERE id_barang = @id_barang";
                    SqlCommand cmd = new SqlCommand(str, koneksi);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@kode_barang", kodeBarang);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@id_barang", idBarang);
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

        private void button2_Click(object sender, EventArgs e)
        {
            DMaster hu = new DMaster();
            hu.Show();
            this.Hide();
        }
    }
}
