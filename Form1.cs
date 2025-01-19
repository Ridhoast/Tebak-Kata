using System;
using System.Collections.Generic; // Tambahkan namespace ini untuk HashSet
using System.Linq;
using System.Windows.Forms;

namespace TebakKataGame
{
    public partial class Form1 : Form
    {
        private string[] daftarKata = System.IO.File.ReadAllLines("daftarKata.txt");
        private string kataRahasia;
        private char[] tebakan;
        private int nyawa = 5;
        private int skor = 0;
        private HashSet<char> hurufTebakanBenar = new HashSet<char>();
        private string namaPemain;
        private int permainanKe = 0;
 private System.Windows.Forms.TextBox txtNamaPemain;
 private System.Windows.Forms.Label lblNamaPemain; 
        private List<int> recordSkor = new List<int>(); // Menyimpan skor dari 3 permainan terakhir
        // @rdhoast
        public Form1()
        {
            InitializeComponent();
            InitGame();
        }

        private void InitGame()
        {
            // Pilih kata secara acak dari daftar kata
            Random acak = new Random();
            kataRahasia = daftarKata[acak.Next(daftarKata.Length)];
            
            // Inisialisasi tebakan dengan karakter '*' sebanyak panjang kata rahasia
            tebakan = new char[kataRahasia.Length];
            for (int i = 0; i < kataRahasia.Length; i++)
            {
                tebakan[i] = '*';
            }

            // Update tampilan
            lblKata.Text = new string(tebakan);
            lblNyawa.Text = $"Nyawa: {nyawa}";
            lblSkor.Text = $"Skor: {skor}";
            txtInput.Clear();
            txtInput.Focus();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            // Ambil nama pemain dari input
            namaPemain = txtNamaPemain.Text.Trim();
            if (string.IsNullOrEmpty(namaPemain))
            {
                MessageBox.Show("Silakan masukkan nama pemain.");
                return;
            }

            InitGame(); // Inisialisasi permainan
        }
        
private void txtInput_KeyPress(object sender, KeyPressEventArgs e)
{
    // Contoh logika, misalnya cuma bisa  menerima karakter huruf
    if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
    {
        e.Handled = true; // Mencegah input yang tidak valid
    }

    // Cek jika tombol yang ditekan adalah Enter
    if (e.KeyChar == (char)Keys.Enter)
    {
        btnTebak.PerformClick(); // Memicu klik pada tombol Tebak
        e.Handled = true; // Mencegah suara beep jika perlu
    }
}
    private void btnRestart_Click(object sender, EventArgs e)
{
    // Logika untuk mereset permainan
    nyawa = 5; 
    skor = 0; 
    hurufTebakanBenar.Clear(); 
    btnTebak.Enabled = true;
    InitGame(); 
}
        private void btnTebak_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length == 1)
            {
                char tebakHuruf = txtInput.Text[0];
                bool benar = false;

                // Cek apakah huruf ada dalam kata rahasia
                for (int i = 0; i < kataRahasia.Length; i++)
                {
                    if (tebakHuruf == kataRahasia[i])
                    {
                        tebakan[i] = tebakHuruf;
                        benar = true;
                    }
                }

                if (benar)
                {
                    // Cek apakah huruf sudah pernah ditebak sebelumnya
                    if (!hurufTebakanBenar.Contains(tebakHuruf))
                    {
                        skor += 10; // Tambah skor hanya jika huruf belum pernah ditebak
                        hurufTebakanBenar.Add(tebakHuruf); // Tambahkan huruf ke set yang sudah ditebak
                    }
                    lblPesan.Text = "Tebakan benar!";
                }
                else
                {
                    nyawa--;
                    lblPesan.Text = "Tebakan salah!";
                }

                // Update tampilan
                lblKata.Text = new string(tebakan);
                lblNyawa.Text = $"Nyawa: {nyawa}";
                lblSkor.Text = $"Skor: {skor}";

                // Cek jika kata sudah lengkap
                if (new string(tebakan) == kataRahasia)
                {
                    permainanKe++; // Tambah jumlah permainan
                    recordSkor.Add(skor); // Simpan skor ke dalam record
                    if (recordSkor.Count > 3) recordSkor.RemoveAt(0); // Hanya simpan 3 skor terakhir
                    lblPesan.Text = $"Selamat, {namaPemain}! Anda menebak kata dengan benar. Kata Rahasia nya adalah: " + kataRahasia;

                    // Cek jika sudah 3 permainan
                    if (permainanKe % 3 == 0)
                    {
                        string skorRecord = string.Join(", ", recordSkor);
                        MessageBox.Show($"Rekaman Skor: {skorRecord}, Nyawa: {nyawa} setelah {permainanKe} permainan.");
                    }
                    btnTebak.Enabled = false;
                }

                // Cek jika nyawa habis
                if (nyawa == 0)
                {
                    lblPesan.Text = $"Sayang sekali, nyawa Anda habis! Kata yang benar adalah: {kataRahasia}";
                    btnTebak.Enabled = false;
                }

                // Bersihkan inputan
                txtInput.Clear();
                txtInput.Focus();
            }
            else
            {
                lblPesan.Text = "Masukkan hanya satu huruf!";
            }
        }
    }
}
