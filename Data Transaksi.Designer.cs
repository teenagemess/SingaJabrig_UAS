namespace SingaJabrig_UAS
{
    partial class Data_Transaksi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtTransaksi = new System.Windows.Forms.TextBox();
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.cbxPenjual = new System.Windows.Forms.ComboBox();
            this.cbxPembeli = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbxBarang = new System.Windows.Forms.ComboBox();
            this.cbxKurir = new System.Windows.Forms.ComboBox();
            this.cbxHarga = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.btnMenyuplai = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtTransaksi
            // 
            this.txtTransaksi.Location = new System.Drawing.Point(401, 235);
            this.txtTransaksi.Name = "txtTransaksi";
            this.txtTransaksi.Size = new System.Drawing.Size(263, 22);
            this.txtTransaksi.TabIndex = 78;
            // 
            // DTPicker
            // 
            this.DTPicker.Location = new System.Drawing.Point(401, 411);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(263, 22);
            this.DTPicker.TabIndex = 77;
            // 
            // cbxPenjual
            // 
            this.cbxPenjual.FormattingEnabled = true;
            this.cbxPenjual.Location = new System.Drawing.Point(401, 274);
            this.cbxPenjual.Name = "cbxPenjual";
            this.cbxPenjual.Size = new System.Drawing.Size(263, 24);
            this.cbxPenjual.TabIndex = 76;
            // 
            // cbxPembeli
            // 
            this.cbxPembeli.FormattingEnabled = true;
            this.cbxPembeli.Location = new System.Drawing.Point(401, 308);
            this.cbxPembeli.Name = "cbxPembeli";
            this.cbxPembeli.Size = new System.Drawing.Size(263, 24);
            this.cbxPembeli.TabIndex = 75;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(529, 499);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 38);
            this.btnDelete.TabIndex = 74;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 73;
            this.label4.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 72;
            this.label3.Text = "ID Pembeli";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 71;
            this.label2.Text = "ID Penjual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(287, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "ID Transaksi";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(739, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 38);
            this.btnAdd.TabIndex = 69;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(432, 499);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 38);
            this.btnSave.TabIndex = 68;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(335, 499);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 38);
            this.btnClear.TabIndex = 67;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(739, 7);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(91, 38);
            this.btnOpen.TabIndex = 66;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(282, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 207);
            this.dataGridView1.TabIndex = 65;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.btnMenyuplai);
            this.panel1.Controls.Add(this.btnTransaksi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 673);
            this.panel1.TabIndex = 64;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 77);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 79;
            this.label5.Text = "ID Barang";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(287, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 16);
            this.label6.TabIndex = 80;
            this.label6.Text = "ID Kurir";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 456);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "Harga";
            // 
            // cbxBarang
            // 
            this.cbxBarang.FormattingEnabled = true;
            this.cbxBarang.Location = new System.Drawing.Point(401, 338);
            this.cbxBarang.Name = "cbxBarang";
            this.cbxBarang.Size = new System.Drawing.Size(263, 24);
            this.cbxBarang.TabIndex = 82;
            // 
            // cbxKurir
            // 
            this.cbxKurir.FormattingEnabled = true;
            this.cbxKurir.Location = new System.Drawing.Point(401, 374);
            this.cbxKurir.Name = "cbxKurir";
            this.cbxKurir.Size = new System.Drawing.Size(263, 24);
            this.cbxKurir.TabIndex = 83;
            // 
            // cbxHarga
            // 
            this.cbxHarga.FormattingEnabled = true;
            this.cbxHarga.Location = new System.Drawing.Point(401, 448);
            this.cbxHarga.Name = "cbxHarga";
            this.cbxHarga.Size = new System.Drawing.Size(263, 24);
            this.cbxHarga.TabIndex = 84;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(626, 499);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 38);
            this.btnUpdate.TabIndex = 85;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 294);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(191, 58);
            this.btnTransaksi.TabIndex = 12;
            this.btnTransaksi.Text = "Data Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnMenyuplai
            // 
            this.btnMenyuplai.FlatAppearance.BorderSize = 0;
            this.btnMenyuplai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenyuplai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenyuplai.Location = new System.Drawing.Point(0, 358);
            this.btnMenyuplai.Name = "btnMenyuplai";
            this.btnMenyuplai.Size = new System.Drawing.Size(191, 58);
            this.btnMenyuplai.TabIndex = 13;
            this.btnMenyuplai.Text = "Data Menyuplai";
            this.btnMenyuplai.UseVisualStyleBackColor = true;
            this.btnMenyuplai.Click += new System.EventHandler(this.btnMenyuplai_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(0, 612);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(191, 58);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Data_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 567);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.cbxHarga);
            this.Controls.Add(this.cbxKurir);
            this.Controls.Add(this.cbxBarang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTransaksi);
            this.Controls.Add(this.DTPicker);
            this.Controls.Add(this.cbxPenjual);
            this.Controls.Add(this.cbxPembeli);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Data_Transaksi";
            this.Text = "Data_Transaksi";
            this.Load += new System.EventHandler(this.Data_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransaksi;
        private System.Windows.Forms.DateTimePicker DTPicker;
        private System.Windows.Forms.ComboBox cbxPenjual;
        private System.Windows.Forms.ComboBox cbxPembeli;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbxBarang;
        private System.Windows.Forms.ComboBox cbxKurir;
        private System.Windows.Forms.ComboBox cbxHarga;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Button btnMenyuplai;
        private System.Windows.Forms.Button btnBack;
    }
}