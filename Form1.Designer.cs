namespace WinFormsApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            cb_itembarang = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtboxtambahbarang = new TextBox();
            btnClose = new Button();
            btnBeli = new Button();
            btnBayar = new Button();
            btnClear = new Button();
            label6 = new Label();
            label7 = new Label();
            btnTambah = new Button();
            txtboxtotalharga = new TextBox();
            pb_gambarbarang = new PictureBox();
            cb_harga = new ComboBox();
            numericSebanyak = new NumericUpDown();
            lb_barang = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pb_gambarbarang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericSebanyak).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 37);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "DATA PENJUALAN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 91);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Nama Barang";
            // 
            // cb_itembarang
            // 
            cb_itembarang.FormattingEnabled = true;
            cb_itembarang.Location = new Point(146, 88);
            cb_itembarang.Name = "cb_itembarang";
            cb_itembarang.Size = new Size(121, 23);
            cb_itembarang.TabIndex = 2;
            cb_itembarang.SelectedIndexChanged += cb_itembarang_SelectedIndexChanged_1;
            cb_itembarang.TextChanged += cb_itembarang_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 133);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "Sebanyak";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 179);
            label4.Name = "label4";
            label4.Size = new Size(89, 15);
            label4.TabIndex = 4;
            label4.Text = "Tambah Barang";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 223);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 5;
            label5.Text = "Gambar Barang";
            // 
            // txtboxtambahbarang
            // 
            txtboxtambahbarang.Location = new Point(146, 176);
            txtboxtambahbarang.Name = "txtboxtambahbarang";
            txtboxtambahbarang.Size = new Size(100, 23);
            txtboxtambahbarang.TabIndex = 7;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(27, 493);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 9;
            btnClose.Text = "close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnBeli
            // 
            btnBeli.Location = new Point(306, 367);
            btnBeli.Name = "btnBeli";
            btnBeli.Size = new Size(75, 23);
            btnBeli.TabIndex = 10;
            btnBeli.Text = "beli";
            btnBeli.UseVisualStyleBackColor = true;
            btnBeli.Click += btnBeli_Click;
            // 
            // btnBayar
            // 
            btnBayar.Location = new Point(306, 409);
            btnBayar.Name = "btnBayar";
            btnBayar.Size = new Size(75, 23);
            btnBayar.TabIndex = 11;
            btnBayar.Text = "bayar";
            btnBayar.UseVisualStyleBackColor = true;
            btnBayar.Click += btnBayar_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(306, 450);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(446, 91);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 13;
            label6.Text = "Harga";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 133);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 14;
            label7.Text = "Total Harga";
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(446, 179);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(75, 23);
            btnTambah.TabIndex = 15;
            btnTambah.Text = "Tambah";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += btnTambah_Click;
            // 
            // txtboxtotalharga
            // 
            txtboxtotalharga.Location = new Point(548, 129);
            txtboxtotalharga.Name = "txtboxtotalharga";
            txtboxtotalharga.ReadOnly = true;
            txtboxtotalharga.Size = new Size(100, 23);
            txtboxtotalharga.TabIndex = 17;
            txtboxtotalharga.TextChanged += btnTambah_Click;
            // 
            // pb_gambarbarang
            // 
            pb_gambarbarang.Image = Properties.Resources.mie;
            pb_gambarbarang.Location = new Point(146, 223);
            pb_gambarbarang.Name = "pb_gambarbarang";
            pb_gambarbarang.Size = new Size(133, 117);
            pb_gambarbarang.SizeMode = PictureBoxSizeMode.StretchImage;
            pb_gambarbarang.TabIndex = 18;
            pb_gambarbarang.TabStop = false;
            pb_gambarbarang.Visible = false;
            pb_gambarbarang.Click += pb_gambarbarang_Click;
            // 
            // cb_harga
            // 
            cb_harga.FormattingEnabled = true;
            cb_harga.Items.AddRange(new object[] { "", "2000", "3000", "4000", "5000" });
            cb_harga.Location = new Point(548, 88);
            cb_harga.Name = "cb_harga";
            cb_harga.Size = new Size(121, 23);
            cb_harga.TabIndex = 19;
            cb_harga.TextChanged += cb_harga_SelectedIndexChanged;
            // 
            // numericSebanyak
            // 
            numericSebanyak.Location = new Point(146, 130);
            numericSebanyak.Name = "numericSebanyak";
            numericSebanyak.Size = new Size(120, 23);
            numericSebanyak.TabIndex = 20;
            numericSebanyak.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericSebanyak.ValueChanged += numericSebanyak_ValueChanged;
            // 
            // lb_barang
            // 
            lb_barang.FormattingEnabled = true;
            lb_barang.ItemHeight = 15;
            lb_barang.Location = new Point(27, 367);
            lb_barang.Name = "lb_barang";
            lb_barang.Size = new Size(239, 109);
            lb_barang.TabIndex = 21;
            lb_barang.SelectedIndexChanged += lb_barang_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 541);
            Controls.Add(lb_barang);
            Controls.Add(numericSebanyak);
            Controls.Add(cb_harga);
            Controls.Add(pb_gambarbarang);
            Controls.Add(txtboxtotalharga);
            Controls.Add(btnTambah);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnClear);
            Controls.Add(btnBayar);
            Controls.Add(btnBeli);
            Controls.Add(btnClose);
            Controls.Add(txtboxtambahbarang);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cb_itembarang);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "\\";
            ((System.ComponentModel.ISupportInitialize)pb_gambarbarang).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericSebanyak).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox cb_itembarang;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtboxtambahbarang;
        private Button btnClose;
        private Button btnBeli;
        private Button btnBayar;
        private Button btnClear;
        private Label label6;
        private Label label7;
        private Button btnTambah;
        private TextBox txtboxtotalharga;
        private PictureBox pb_gambarbarang;
        private ComboBox cb_harga;
        private NumericUpDown numericSebanyak;
        private ListBox lb_barang;
    }
}