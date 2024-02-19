using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult hasil = MessageBox.Show("Apakah Anda yakin ingin menutup?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (hasil == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string tambahBarang = txtboxtambahbarang.Text;


            if (!string.IsNullOrEmpty(tambahBarang))
            {
                cb_itembarang.Items.Add(tambahBarang);

                txtboxtambahbarang.Text = "";

            }

        }

        private void cb_itembarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            String barang = cb_itembarang.ToString();

            if (barang.ToLower().Equals("geprek"))
            {

            }
            else if (barang.ToLower().Equals("rujak"))
            {
                pb_gambarbarang.Image = Properties.Resources.rujak;
            }
            else if (barang.ToLower().Equals("mie"))
            {
                pb_gambarbarang.Image = Properties.Resources.mie;
            }
            cb_itembarang.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            string itemBarang = cb_itembarang.Text.Trim();
            int jumlah = (int)numericSebanyak.Value;
            string harga = cb_harga.Text.Trim();


            List<string> list = new List<string>();

            string arrayDataBarang =
                "Nama Barang : " + itemBarang;

            string arrayBanyakBarang =
                "Banyak Barang : " + jumlah;

            string arrayHargaBarang =
                "Harga Barang : " + harga;

            string arrayVoid =
                " ";

            list.Add(arrayDataBarang);
            list.Add(arrayBanyakBarang);
            list.Add(arrayHargaBarang);

            list.Add(arrayVoid);

            foreach (string item in list)
            {
                lb_barang.Items.Add(item); // Menambahkan setiap item dari List ke dalam ListBox
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {

            int perkalianValue = (int)numericSebanyak.Value;
            string total = txtboxtotalharga.Text.Trim();


            if (int.TryParse(cb_harga.Text, out int hargaValue))
            {

                int totalHarga = perkalianValue * hargaValue;

                string totalHargaPerkalian = totalHarga.ToString();

                txtboxtotalharga.Text = totalHargaPerkalian;

                string arrayTotalBarang =
                "Total Harga : " + totalHargaPerkalian;

                lb_barang.Items.Add(arrayTotalBarang);
            }
            else
            {

                MessageBox.Show("Harga Invalid");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lb_barang.Items.Clear();

            cb_itembarang.Items.Clear();
            cb_harga.SelectedIndex = -1;



            numericSebanyak.Value = 0;


            txtboxtotalharga.Text = "";


            pb_gambarbarang.Visible = false;
        }

        private void cb_harga_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_harga.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void pb_gambarbarang_Click(object sender, EventArgs e)
        {

        }

        private void cb_itembarang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string namaBarang = cb_itembarang.Text;
            pb_gambarbarang.Visible = true;
            if (namaBarang == ("mie"))
            {
                pb_gambarbarang.Image = Properties.Resources.mie;

            }
            if (namaBarang == ("geprek"))
            {
                pb_gambarbarang.Image = Properties.Resources.geprek;

            }
            if (namaBarang == ("rujak"))
            {
                pb_gambarbarang.Image = Properties.Resources.rujak;

            }
        }

        private void lb_barang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numericSebanyak_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}