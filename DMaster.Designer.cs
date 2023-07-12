namespace SingaJabrig_UAS
{
    partial class DMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DMaster));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnProdusen = new System.Windows.Forms.Button();
            this.btnPenjual = new System.Windows.Forms.Button();
            this.btnPembeli = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGray;
            this.panel3.Location = new System.Drawing.Point(196, -3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(798, 34);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(269, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Datamaster";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnProdusen);
            this.panel1.Controls.Add(this.btnPenjual);
            this.panel1.Controls.Add(this.btnPembeli);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(198, 655);
            this.panel1.TabIndex = 3;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(3, 594);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(191, 58);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(0, 429);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(191, 58);
            this.button5.TabIndex = 13;
            this.button5.Text = "Data Barang";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(0, 301);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(191, 58);
            this.button4.TabIndex = 12;
            this.button4.Text = "Data Kurir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProdusen
            // 
            this.btnProdusen.FlatAppearance.BorderSize = 0;
            this.btnProdusen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdusen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProdusen.Location = new System.Drawing.Point(0, 237);
            this.btnProdusen.Name = "btnProdusen";
            this.btnProdusen.Size = new System.Drawing.Size(191, 58);
            this.btnProdusen.TabIndex = 11;
            this.btnProdusen.Text = "Data Produsen";
            this.btnProdusen.UseVisualStyleBackColor = true;
            this.btnProdusen.Click += new System.EventHandler(this.btnProdusen_Click);
            // 
            // btnPenjual
            // 
            this.btnPenjual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPenjual.FlatAppearance.BorderSize = 0;
            this.btnPenjual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenjual.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPenjual.Location = new System.Drawing.Point(0, 109);
            this.btnPenjual.Name = "btnPenjual";
            this.btnPenjual.Size = new System.Drawing.Size(191, 58);
            this.btnPenjual.TabIndex = 10;
            this.btnPenjual.Text = "Data Penjual";
            this.btnPenjual.UseVisualStyleBackColor = true;
            this.btnPenjual.Click += new System.EventHandler(this.btnPenjual_Click);
            // 
            // btnPembeli
            // 
            this.btnPembeli.FlatAppearance.BorderSize = 0;
            this.btnPembeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPembeli.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPembeli.Location = new System.Drawing.Point(0, 173);
            this.btnPembeli.Name = "btnPembeli";
            this.btnPembeli.Size = new System.Drawing.Size(191, 58);
            this.btnPembeli.TabIndex = 2;
            this.btnPembeli.Text = "Data Pembeli";
            this.btnPembeli.UseVisualStyleBackColor = true;
            this.btnPembeli.Click += new System.EventHandler(this.btnPembeli_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(287, 111);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(700, 433);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(7, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 58);
            this.button2.TabIndex = 15;
            this.button2.Text = "Data Nama Barang";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(859, 649);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "DMaster";
            this.Text = "Data Penjual";
            this.Load += new System.EventHandler(this.DMaster_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnProdusen;
        private System.Windows.Forms.Button btnPenjual;
        private System.Windows.Forms.Button btnPembeli;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button2;
    }
}