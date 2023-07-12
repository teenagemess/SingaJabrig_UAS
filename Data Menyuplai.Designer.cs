namespace SingaJabrig_UAS
{
    partial class Data_Menyuplai
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
            this.btnMenyuplai = new System.Windows.Forms.Button();
            this.btnTransaksi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbxProdusen = new System.Windows.Forms.ComboBox();
            this.cbxPenjual = new System.Windows.Forms.ComboBox();
            this.DTPicker = new System.Windows.Forms.DateTimePicker();
            this.txtSupply = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(552, 441);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 38);
            this.btnDelete.TabIndex = 58;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(266, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 56;
            this.label4.Text = "Tanggal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 55;
            this.label3.Text = "ID Penjual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(266, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 54;
            this.label2.Text = "ID Produsen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(266, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "ID Supply";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(768, 82);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 38);
            this.btnAdd.TabIndex = 47;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(455, 441);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(91, 38);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(358, 441);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 38);
            this.btnClear.TabIndex = 45;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(768, 38);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(91, 38);
            this.btnOpen.TabIndex = 44;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(311, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 207);
            this.dataGridView1.TabIndex = 43;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnMenyuplai);
            this.panel1.Controls.Add(this.btnTransaksi);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(191, 654);
            this.panel1.TabIndex = 42;
            // 
            // btnMenyuplai
            // 
            this.btnMenyuplai.FlatAppearance.BorderSize = 0;
            this.btnMenyuplai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenyuplai.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnMenyuplai.Location = new System.Drawing.Point(0, 301);
            this.btnMenyuplai.Name = "btnMenyuplai";
            this.btnMenyuplai.Size = new System.Drawing.Size(191, 58);
            this.btnMenyuplai.TabIndex = 12;
            this.btnMenyuplai.Text = "Data Menyuplai";
            this.btnMenyuplai.UseVisualStyleBackColor = true;
            this.btnMenyuplai.Click += new System.EventHandler(this.btnKurir_Click);
            // 
            // btnTransaksi
            // 
            this.btnTransaksi.FlatAppearance.BorderSize = 0;
            this.btnTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaksi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTransaksi.Location = new System.Drawing.Point(0, 237);
            this.btnTransaksi.Name = "btnTransaksi";
            this.btnTransaksi.Size = new System.Drawing.Size(191, 58);
            this.btnTransaksi.TabIndex = 11;
            this.btnTransaksi.Text = "Data Transaksi";
            this.btnTransaksi.UseVisualStyleBackColor = true;
            this.btnTransaksi.Click += new System.EventHandler(this.btnProdusen_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 77);
            this.panel2.TabIndex = 0;
            // 
            // cbxProdusen
            // 
            this.cbxProdusen.FormattingEnabled = true;
            this.cbxProdusen.Location = new System.Drawing.Point(380, 300);
            this.cbxProdusen.Name = "cbxProdusen";
            this.cbxProdusen.Size = new System.Drawing.Size(263, 24);
            this.cbxProdusen.TabIndex = 60;
            this.cbxProdusen.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // cbxPenjual
            // 
            this.cbxPenjual.FormattingEnabled = true;
            this.cbxPenjual.Location = new System.Drawing.Point(380, 334);
            this.cbxPenjual.Name = "cbxPenjual";
            this.cbxPenjual.Size = new System.Drawing.Size(263, 24);
            this.cbxPenjual.TabIndex = 61;
            // 
            // DTPicker
            // 
            this.DTPicker.Location = new System.Drawing.Point(380, 381);
            this.DTPicker.Name = "DTPicker";
            this.DTPicker.Size = new System.Drawing.Size(263, 22);
            this.DTPicker.TabIndex = 62;
            // 
            // txtSupply
            // 
            this.txtSupply.Location = new System.Drawing.Point(380, 266);
            this.txtSupply.Name = "txtSupply";
            this.txtSupply.Size = new System.Drawing.Size(263, 22);
            this.txtSupply.TabIndex = 63;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(0, 593);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 58);
            this.button1.TabIndex = 13;
            this.button1.Text = "Back To Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Data_Menyuplai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 577);
            this.Controls.Add(this.txtSupply);
            this.Controls.Add(this.DTPicker);
            this.Controls.Add(this.cbxPenjual);
            this.Controls.Add(this.cbxProdusen);
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
            this.Name = "Data_Menyuplai";
            this.Text = "Data_Menyuplai";
            this.Load += new System.EventHandler(this.Data_Menyuplai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Button btnMenyuplai;
        private System.Windows.Forms.Button btnTransaksi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbxProdusen;
        private System.Windows.Forms.ComboBox cbxPenjual;
        private System.Windows.Forms.DateTimePicker DTPicker;
        private System.Windows.Forms.TextBox txtSupply;
        private System.Windows.Forms.Button button1;
    }
}