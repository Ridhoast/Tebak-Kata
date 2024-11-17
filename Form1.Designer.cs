namespace TebakKataGame
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblKata;
        private Label lblNyawa;
        private Label lblSkor;
        private Label lblPesan;
        private TextBox txtInput;
        private Button btnTebak;
        private Button btnRestart;
        private PictureBox pictureBox1;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblKata = new Label();
            this.lblNyawa = new Label();
            this.lblSkor = new Label();
            this.lblPesan = new Label();
            this.txtInput = new TextBox();
            this.btnTebak = new Button();
            this.btnRestart = new Button();
            this.pictureBox1 = new PictureBox();
            txtNamaPemain = new System.Windows.Forms.TextBox();
    txtNamaPemain.Location = new System.Drawing.Point(20, 20); // Atur lokasi
    txtNamaPemain.Size = new System.Drawing.Size(200, 20); // Atur ukuran
    this.Controls.Add(txtNamaPemain);
    lblNamaPemain = new System.Windows.Forms.Label();
    lblNamaPemain.Text = "Nama Pemain:";
    lblNamaPemain.Location = new System.Drawing.Point(20, 0); // Atur lokasi label
    this.Controls.Add(lblNamaPemain); // Tambahkan ke form

            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            

            // lblKata
            this.lblKata.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold);
            this.lblKata.ForeColor = System.Drawing.Color.Orange;
            this.lblKata.Location = new System.Drawing.Point(100, 50);
            this.lblKata.Name = "lblKata";
            this.lblKata.Size = new System.Drawing.Size(300, 50);
            this.lblKata.Text = "*****";
            this.lblKata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblNyawa
            this.lblNyawa.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblNyawa.ForeColor = System.Drawing.Color.Red;
            this.lblNyawa.Location = new System.Drawing.Point(50, 120);
            this.lblNyawa.Name = "lblNyawa";
            this.lblNyawa.Size = new System.Drawing.Size(150, 30);
            this.lblNyawa.Text = "Nyawa: 5";

            // lblSkor
            this.lblSkor.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.lblSkor.ForeColor = System.Drawing.Color.Green;
            this.lblSkor.Location = new System.Drawing.Point(220, 120);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(150, 30);
            this.lblSkor.Text = "Skor: 0";

            // lblPesan
            this.lblPesan.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Italic);
            this.lblPesan.ForeColor = System.Drawing.Color.Blue;
            this.lblPesan.Location = new System.Drawing.Point(50, 200);
            this.lblPesan.Name = "lblPesan";
            this.lblPesan.Size = new System.Drawing.Size(700, 50);
            this.lblPesan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // txtInput
            this.txtInput.Font = new System.Drawing.Font("Comic Sans MS", 14F);
            this.txtInput.Location = new System.Drawing.Point(50, 150);
            this.txtInput.MaxLength = 1;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(50, 34);
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);

            // btnTebak
            this.btnTebak.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnTebak.Location = new System.Drawing.Point(120, 150);
            this.btnTebak.Name = "btnTebak";
            this.btnTebak.Size = new System.Drawing.Size(100, 40);
            this.btnTebak.Text = "Tebak";
            this.btnTebak.Click += new System.EventHandler(this.btnTebak_Click);

            // btnRestart
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.btnRestart.Location = new System.Drawing.Point(250, 150);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(100, 40);
            this.btnRestart.Text = "Restart";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);

            // Form1
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.lblKata);
            this.Controls.Add(this.lblNyawa);
            this.Controls.Add(this.lblSkor);
            this.Controls.Add(this.lblPesan);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnTebak);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Game Tebak Kata";
            
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
