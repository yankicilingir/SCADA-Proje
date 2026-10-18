namespace BoruHattiScada
{
    partial class AnaForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlBaslik = new System.Windows.Forms.Panel();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblHatDurumu = new System.Windows.Forms.Label();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.pnlAlarm = new System.Windows.Forms.Panel();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.pnlHat = new System.Windows.Forms.Panel();
            this.lblRenkler = new System.Windows.Forms.Label();
            this.lblSizintiYazi = new System.Windows.Forms.Label();
            this.lblTankSeviye = new System.Windows.Forms.Label();
            this.lblTankAdi = new System.Windows.Forms.Label();
            this.pnlTank = new System.Windows.Forms.Panel();
            this.pnlTankDolu = new System.Windows.Forms.Panel();
            this.lblKirikkale = new System.Windows.Forms.Label();
            this.lblAksaray = new System.Windows.Forms.Label();
            this.lblNigde = new System.Windows.Forms.Label();
            this.lblPozanti = new System.Windows.Forms.Label();
            this.lblAdana = new System.Windows.Forms.Label();
            this.lblCeyhan = new System.Windows.Forms.Label();
            this.pnlBoruTank = new System.Windows.Forms.Panel();
            this.lblV6 = new System.Windows.Forms.Label();
            this.pnlBoru5 = new System.Windows.Forms.Panel();
            this.lblV5 = new System.Windows.Forms.Label();
            this.pnlBoru4 = new System.Windows.Forms.Panel();
            this.lblV4 = new System.Windows.Forms.Label();
            this.pnlBoru3 = new System.Windows.Forms.Panel();
            this.lblV3 = new System.Windows.Forms.Label();
            this.lblP201 = new System.Windows.Forms.Label();
            this.pnlBoru2 = new System.Windows.Forms.Panel();
            this.lblV2 = new System.Windows.Forms.Label();
            this.pnlBoru1 = new System.Windows.Forms.Panel();
            this.lblV1 = new System.Windows.Forms.Label();
            this.lblP101 = new System.Windows.Forms.Label();
            this.grpAlarmlar = new System.Windows.Forms.GroupBox();
            this.lvAlarmlar = new System.Windows.Forms.ListView();
            this.colZaman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOncelik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEkipman = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grpKontrol = new System.Windows.Forms.GroupBox();
            this.btnIzoleEt = new System.Windows.Forms.Button();
            this.btnAlarmOnayla = new System.Windows.Forms.Button();
            this.btnVanaKapat = new System.Windows.Forms.Button();
            this.btnVanaAc = new System.Windows.Forms.Button();
            this.lblVanaDurum = new System.Windows.Forms.Label();
            this.cmbVana = new System.Windows.Forms.ComboBox();
            this.lblVana = new System.Windows.Forms.Label();
            this.numHiz = new System.Windows.Forms.NumericUpDown();
            this.lblHiz = new System.Windows.Forms.Label();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.grpSizinti = new System.Windows.Forms.GroupBox();
            this.lblSizintiYeri = new System.Windows.Forms.Label();
            this.lblSizintiDurum = new System.Windows.Forms.Label();
            this.prgFark = new System.Windows.Forms.ProgressBar();
            this.lblFark = new System.Windows.Forms.Label();
            this.lblCikis = new System.Windows.Forms.Label();
            this.lblGiris = new System.Windows.Forms.Label();
            this.grpAriza = new System.Windows.Forms.GroupBox();
            this.btnArizalariGider = new System.Windows.Forms.Button();
            this.lblArizaBilgi = new System.Windows.Forms.Label();
            this.btnRastgeleAriza = new System.Windows.Forms.Button();
            this.btnPompaArizasi = new System.Windows.Forms.Button();
            this.btnBaglantiKes = new System.Windows.Forms.Button();
            this.cmbIstasyon = new System.Windows.Forms.ComboBox();
            this.lblIstasyon = new System.Windows.Forms.Label();
            this.btnSizintiOlustur = new System.Windows.Forms.Button();
            this.txtSizintiMiktar = new System.Windows.Forms.TextBox();
            this.lblSizintiMiktar = new System.Windows.Forms.Label();
            this.cmbSizintiBolum = new System.Windows.Forms.ComboBox();
            this.lblSizintiBolum = new System.Windows.Forms.Label();
            this.lblTankAyar = new System.Windows.Forms.Label();
            this.numTankSeviye = new System.Windows.Forms.NumericUpDown();
            this.btnTankAyarla = new System.Windows.Forms.Button();
            this.tmrSimulasyon = new System.Windows.Forms.Timer(this.components);
            this.tmrYanipSonme = new System.Windows.Forms.Timer(this.components);
            this.tmrRastgeleAriza = new System.Windows.Forms.Timer(this.components);
            this.pnlBaslik.SuspendLayout();
            this.pnlAlarm.SuspendLayout();
            this.pnlHat.SuspendLayout();
            this.pnlTank.SuspendLayout();
            this.grpAlarmlar.SuspendLayout();
            this.grpKontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHiz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTankSeviye)).BeginInit();
            this.grpSizinti.SuspendLayout();
            this.grpAriza.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlBaslik
            //
            this.pnlBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.pnlBaslik.Controls.Add(this.lblSaat);
            this.pnlBaslik.Controls.Add(this.lblHatDurumu);
            this.pnlBaslik.Controls.Add(this.lblBaslik);
            this.pnlBaslik.Location = new System.Drawing.Point(0, 0);
            this.pnlBaslik.Name = "pnlBaslik";
            this.pnlBaslik.Size = new System.Drawing.Size(1240, 40);
            this.pnlBaslik.TabIndex = 0;
            //
            // lblSaat
            //
            this.lblSaat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSaat.ForeColor = System.Drawing.Color.White;
            this.lblSaat.Location = new System.Drawing.Point(1030, 9);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(200, 22);
            this.lblSaat.TabIndex = 2;
            this.lblSaat.Text = "00:00:00";
            this.lblSaat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // lblHatDurumu
            //
            this.lblHatDurumu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(93)))), ((int)(((byte)(98)))));
            this.lblHatDurumu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblHatDurumu.ForeColor = System.Drawing.Color.White;
            this.lblHatDurumu.Location = new System.Drawing.Point(400, 8);
            this.lblHatDurumu.Name = "lblHatDurumu";
            this.lblHatDurumu.Size = new System.Drawing.Size(220, 24);
            this.lblHatDurumu.TabIndex = 1;
            this.lblHatDurumu.Text = "Hat durduruldu";
            this.lblHatDurumu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblBaslik
            //
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(10, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(327, 21);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ceyhan - Kırıkkale Ham Petrol Boru Hattı";
            //
            // pnlAlarm
            //
            this.pnlAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.pnlAlarm.Controls.Add(this.lblAlarm);
            this.pnlAlarm.Location = new System.Drawing.Point(0, 40);
            this.pnlAlarm.Name = "pnlAlarm";
            this.pnlAlarm.Size = new System.Drawing.Size(1240, 28);
            this.pnlAlarm.TabIndex = 1;
            //
            // lblAlarm
            //
            this.lblAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlarm.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblAlarm.Location = new System.Drawing.Point(0, 0);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblAlarm.Size = new System.Drawing.Size(1240, 28);
            this.lblAlarm.TabIndex = 0;
            this.lblAlarm.Text = "Aktif alarm yok";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlHat
            //
            this.pnlHat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.pnlHat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHat.Controls.Add(this.lblRenkler);
            this.pnlHat.Controls.Add(this.lblSizintiYazi);
            this.pnlHat.Controls.Add(this.lblTankSeviye);
            this.pnlHat.Controls.Add(this.lblTankAdi);
            this.pnlHat.Controls.Add(this.pnlTank);
            this.pnlHat.Controls.Add(this.lblKirikkale);
            this.pnlHat.Controls.Add(this.lblAksaray);
            this.pnlHat.Controls.Add(this.lblNigde);
            this.pnlHat.Controls.Add(this.lblPozanti);
            this.pnlHat.Controls.Add(this.lblAdana);
            this.pnlHat.Controls.Add(this.lblCeyhan);
            this.pnlHat.Controls.Add(this.pnlBoruTank);
            this.pnlHat.Controls.Add(this.lblV6);
            this.pnlHat.Controls.Add(this.pnlBoru5);
            this.pnlHat.Controls.Add(this.lblV5);
            this.pnlHat.Controls.Add(this.pnlBoru4);
            this.pnlHat.Controls.Add(this.lblV4);
            this.pnlHat.Controls.Add(this.pnlBoru3);
            this.pnlHat.Controls.Add(this.lblV3);
            this.pnlHat.Controls.Add(this.lblP201);
            this.pnlHat.Controls.Add(this.pnlBoru2);
            this.pnlHat.Controls.Add(this.lblV2);
            this.pnlHat.Controls.Add(this.pnlBoru1);
            this.pnlHat.Controls.Add(this.lblV1);
            this.pnlHat.Controls.Add(this.lblP101);
            this.pnlHat.Location = new System.Drawing.Point(8, 76);
            this.pnlHat.Name = "pnlHat";
            this.pnlHat.Size = new System.Drawing.Size(1224, 250);
            this.pnlHat.TabIndex = 2;
            //
            // lblRenkler
            //
            this.lblRenkler.AutoSize = true;
            this.lblRenkler.ForeColor = System.Drawing.Color.DimGray;
            this.lblRenkler.Location = new System.Drawing.Point(10, 222);
            this.lblRenkler.Name = "lblRenkler";
            this.lblRenkler.Size = new System.Drawing.Size(560, 15);
            this.lblRenkler.TabIndex = 24;
            this.lblRenkler.Text = "Yeşil: çalışıyor / açık     Gri: durdu     Beyaz: kapalı     Kırmızı: arıza     V1-V6: vanalar     P-101, P-201: pompalar";
            //
            // lblSizintiYazi
            //
            this.lblSizintiYazi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(48)))), ((int)(((byte)(47)))));
            this.lblSizintiYazi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSizintiYazi.ForeColor = System.Drawing.Color.White;
            this.lblSizintiYazi.Location = new System.Drawing.Point(110, 72);
            this.lblSizintiYazi.Name = "lblSizintiYazi";
            this.lblSizintiYazi.Size = new System.Drawing.Size(100, 22);
            this.lblSizintiYazi.TabIndex = 23;
            this.lblSizintiYazi.Text = "SIZINTI";
            this.lblSizintiYazi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSizintiYazi.Visible = false;
            //
            // lblTankSeviye
            //
            this.lblTankSeviye.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTankSeviye.Location = new System.Drawing.Point(1110, 174);
            this.lblTankSeviye.Name = "lblTankSeviye";
            this.lblTankSeviye.Size = new System.Drawing.Size(100, 18);
            this.lblTankSeviye.TabIndex = 22;
            this.lblTankSeviye.Text = "%62";
            this.lblTankSeviye.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblTankAdi
            //
            this.lblTankAdi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTankAdi.Location = new System.Drawing.Point(1110, 28);
            this.lblTankAdi.Name = "lblTankAdi";
            this.lblTankAdi.Size = new System.Drawing.Size(100, 18);
            this.lblTankAdi.TabIndex = 21;
            this.lblTankAdi.Text = "Rafineri Tankı";
            this.lblTankAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlTank
            //
            this.pnlTank.BackColor = System.Drawing.Color.White;
            this.pnlTank.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTank.Controls.Add(this.pnlTankDolu);
            this.pnlTank.Location = new System.Drawing.Point(1130, 50);
            this.pnlTank.Name = "pnlTank";
            this.pnlTank.Size = new System.Drawing.Size(60, 120);
            this.pnlTank.TabIndex = 20;
            //
            // pnlTankDolu
            //
            this.pnlTankDolu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlTankDolu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTankDolu.Location = new System.Drawing.Point(0, 44);
            this.pnlTankDolu.Name = "pnlTankDolu";
            this.pnlTankDolu.Size = new System.Drawing.Size(58, 74);
            this.pnlTankDolu.TabIndex = 0;
            //
            // lblKirikkale
            //
            this.lblKirikkale.Location = new System.Drawing.Point(1000, 132);
            this.lblKirikkale.Name = "lblKirikkale";
            this.lblKirikkale.Size = new System.Drawing.Size(120, 70);
            this.lblKirikkale.TabIndex = 19;
            this.lblKirikkale.Text = "Kırıkkale (km 448)";
            this.lblKirikkale.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblAksaray
            //
            this.lblAksaray.Location = new System.Drawing.Point(694, 132);
            this.lblAksaray.Name = "lblAksaray";
            this.lblAksaray.Size = new System.Drawing.Size(112, 70);
            this.lblAksaray.TabIndex = 18;
            this.lblAksaray.Text = "Aksaray (km 300)";
            this.lblAksaray.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblNigde
            //
            this.lblNigde.Location = new System.Drawing.Point(408, 132);
            this.lblNigde.Name = "lblNigde";
            this.lblNigde.Size = new System.Drawing.Size(112, 70);
            this.lblNigde.TabIndex = 17;
            this.lblNigde.Text = "Niğde (km 170)";
            this.lblNigde.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblPozanti
            //
            this.lblPozanti.Location = new System.Drawing.Point(290, 132);
            this.lblPozanti.Name = "lblPozanti";
            this.lblPozanti.Size = new System.Drawing.Size(114, 70);
            this.lblPozanti.TabIndex = 16;
            this.lblPozanti.Text = "Pozantı (km 112)";
            this.lblPozanti.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblAdana
            //
            this.lblAdana.Location = new System.Drawing.Point(166, 132);
            this.lblAdana.Name = "lblAdana";
            this.lblAdana.Size = new System.Drawing.Size(112, 70);
            this.lblAdana.TabIndex = 15;
            this.lblAdana.Text = "Adana (km 60)";
            this.lblAdana.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // lblCeyhan
            //
            this.lblCeyhan.Location = new System.Drawing.Point(4, 132);
            this.lblCeyhan.Name = "lblCeyhan";
            this.lblCeyhan.Size = new System.Drawing.Size(120, 70);
            this.lblCeyhan.TabIndex = 14;
            this.lblCeyhan.Text = "Ceyhan (km 0)";
            this.lblCeyhan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            //
            // pnlBoruTank
            //
            this.pnlBoruTank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pnlBoruTank.Location = new System.Drawing.Point(1089, 106);
            this.pnlBoruTank.Name = "pnlBoruTank";
            this.pnlBoruTank.Size = new System.Drawing.Size(41, 8);
            this.pnlBoruTank.TabIndex = 13;
            //
            // lblV6
            //
            this.lblV6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(139)))), ((int)(((byte)(61)))));
            this.lblV6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblV6.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblV6.ForeColor = System.Drawing.Color.White;
            this.lblV6.Location = new System.Drawing.Point(1063, 100);
            this.lblV6.Name = "lblV6";
            this.lblV6.Size = new System.Drawing.Size(26, 20);
            this.lblV6.TabIndex = 12;
            this.lblV6.Text = "V6";
            this.lblV6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlBoru5
            //
            this.pnlBoru5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pnlBoru5.Location = new System.Drawing.Point(763, 106);
            this.pnlBoru5.Name = "pnlBoru5";
            this.pnlBoru5.Size = new System.Drawing.Size(300, 8);
            this.pnlBoru5.TabIndex = 11;
            //
            // lblV5
            //
            this.lblV5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(139)))), ((int)(((byte)(61)))));
            this.lblV5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblV5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblV5.ForeColor = System.Drawing.Color.White;
            this.lblV5.Location = new System.Drawing.Point(737, 100);
            this.lblV5.Name = "lblV5";
            this.lblV5.Size = new System.Drawing.Size(26, 20);
            this.lblV5.TabIndex = 10;
            this.lblV5.Text = "V5";
            this.lblV5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlBoru4
            //
            this.pnlBoru4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pnlBoru4.Location = new System.Drawing.Point(477, 106);
            this.pnlBoru4.Name = "pnlBoru4";
            this.pnlBoru4.Size = new System.Drawing.Size(260, 8);
            this.pnlBoru4.TabIndex = 9;
            //
            // lblV4
            //
            this.lblV4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(139)))), ((int)(((byte)(61)))));
            this.lblV4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblV4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblV4.ForeColor = System.Drawing.Color.White;
            this.lblV4.Location = new System.Drawing.Point(451, 100);
            this.lblV4.Name = "lblV4";
            this.lblV4.Size = new System.Drawing.Size(26, 20);
            this.lblV4.TabIndex = 8;
            this.lblV4.Text = "V4";
            this.lblV4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlBoru3
            //
            this.pnlBoru3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pnlBoru3.Location = new System.Drawing.Point(390, 106);
            this.pnlBoru3.Name = "pnlBoru3";
            this.pnlBoru3.Size = new System.Drawing.Size(61, 8);
            this.pnlBoru3.TabIndex = 7;
            //
            // lblV3
            //
            this.lblV3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(139)))), ((int)(((byte)(61)))));
            this.lblV3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblV3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblV3.ForeColor = System.Drawing.Color.White;
            this.lblV3.Location = new System.Drawing.Point(364, 100);
            this.lblV3.Name = "lblV3";
            this.lblV3.Size = new System.Drawing.Size(26, 20);
            this.lblV3.TabIndex = 6;
            this.lblV3.Text = "V3";
            this.lblV3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblP201
            //
            this.lblP201.BackColor = System.Drawing.Color.Gray;
            this.lblP201.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblP201.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblP201.ForeColor = System.Drawing.Color.White;
            this.lblP201.Location = new System.Drawing.Point(308, 95);
            this.lblP201.Name = "lblP201";
            this.lblP201.Size = new System.Drawing.Size(56, 30);
            this.lblP201.TabIndex = 5;
            this.lblP201.Text = "P-201";
            this.lblP201.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlBoru2
            //
            this.pnlBoru2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pnlBoru2.Location = new System.Drawing.Point(235, 106);
            this.pnlBoru2.Name = "pnlBoru2";
            this.pnlBoru2.Size = new System.Drawing.Size(73, 8);
            this.pnlBoru2.TabIndex = 4;
            //
            // lblV2
            //
            this.lblV2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(139)))), ((int)(((byte)(61)))));
            this.lblV2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblV2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblV2.ForeColor = System.Drawing.Color.White;
            this.lblV2.Location = new System.Drawing.Point(209, 100);
            this.lblV2.Name = "lblV2";
            this.lblV2.Size = new System.Drawing.Size(26, 20);
            this.lblV2.TabIndex = 3;
            this.lblV2.Text = "V2";
            this.lblV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlBoru1
            //
            this.pnlBoru1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.pnlBoru1.Location = new System.Drawing.Point(103, 106);
            this.pnlBoru1.Name = "pnlBoru1";
            this.pnlBoru1.Size = new System.Drawing.Size(106, 8);
            this.pnlBoru1.TabIndex = 2;
            //
            // lblV1
            //
            this.lblV1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(139)))), ((int)(((byte)(61)))));
            this.lblV1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblV1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblV1.ForeColor = System.Drawing.Color.White;
            this.lblV1.Location = new System.Drawing.Point(77, 100);
            this.lblV1.Name = "lblV1";
            this.lblV1.Size = new System.Drawing.Size(26, 20);
            this.lblV1.TabIndex = 1;
            this.lblV1.Text = "V1";
            this.lblV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblP101
            //
            this.lblP101.BackColor = System.Drawing.Color.Gray;
            this.lblP101.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblP101.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblP101.ForeColor = System.Drawing.Color.White;
            this.lblP101.Location = new System.Drawing.Point(20, 95);
            this.lblP101.Name = "lblP101";
            this.lblP101.Size = new System.Drawing.Size(56, 30);
            this.lblP101.TabIndex = 0;
            this.lblP101.Text = "P-101";
            this.lblP101.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // grpAlarmlar
            //
            this.grpAlarmlar.Controls.Add(this.lvAlarmlar);
            this.grpAlarmlar.Location = new System.Drawing.Point(8, 332);
            this.grpAlarmlar.Name = "grpAlarmlar";
            this.grpAlarmlar.Size = new System.Drawing.Size(740, 200);
            this.grpAlarmlar.TabIndex = 3;
            this.grpAlarmlar.TabStop = false;
            this.grpAlarmlar.Text = "Alarmlar";
            //
            // lvAlarmlar
            //
            this.lvAlarmlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colZaman,
            this.colOncelik,
            this.colEkipman,
            this.colAciklama,
            this.colDurum});
            this.lvAlarmlar.FullRowSelect = true;
            this.lvAlarmlar.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvAlarmlar.HideSelection = false;
            this.lvAlarmlar.Location = new System.Drawing.Point(8, 20);
            this.lvAlarmlar.MultiSelect = false;
            this.lvAlarmlar.Name = "lvAlarmlar";
            this.lvAlarmlar.Size = new System.Drawing.Size(724, 172);
            this.lvAlarmlar.TabIndex = 0;
            this.lvAlarmlar.UseCompatibleStateImageBehavior = false;
            this.lvAlarmlar.View = System.Windows.Forms.View.Details;
            //
            // colZaman
            //
            this.colZaman.Text = "Zaman";
            this.colZaman.Width = 70;
            //
            // colOncelik
            //
            this.colOncelik.Text = "Öncelik";
            this.colOncelik.Width = 60;
            //
            // colEkipman
            //
            this.colEkipman.Text = "Ekipman";
            this.colEkipman.Width = 80;
            //
            // colAciklama
            //
            this.colAciklama.Text = "Açıklama";
            this.colAciklama.Width = 375;
            //
            // colDurum
            //
            this.colDurum.Text = "Durum";
            this.colDurum.Width = 130;
            //
            // grpKontrol
            //
            this.grpKontrol.Controls.Add(this.btnIzoleEt);
            this.grpKontrol.Controls.Add(this.btnAlarmOnayla);
            this.grpKontrol.Controls.Add(this.btnVanaKapat);
            this.grpKontrol.Controls.Add(this.btnVanaAc);
            this.grpKontrol.Controls.Add(this.lblVanaDurum);
            this.grpKontrol.Controls.Add(this.cmbVana);
            this.grpKontrol.Controls.Add(this.lblVana);
            this.grpKontrol.Controls.Add(this.numHiz);
            this.grpKontrol.Controls.Add(this.lblHiz);
            this.grpKontrol.Controls.Add(this.btnDurdur);
            this.grpKontrol.Controls.Add(this.btnBaslat);
            this.grpKontrol.Location = new System.Drawing.Point(756, 332);
            this.grpKontrol.Name = "grpKontrol";
            this.grpKontrol.Size = new System.Drawing.Size(476, 170);
            this.grpKontrol.TabIndex = 4;
            this.grpKontrol.TabStop = false;
            this.grpKontrol.Text = "Hat Kontrolü";
            //
            // btnIzoleEt
            //
            this.btnIzoleEt.Location = new System.Drawing.Point(243, 120);
            this.btnIzoleEt.Name = "btnIzoleEt";
            this.btnIzoleEt.Size = new System.Drawing.Size(220, 36);
            this.btnIzoleEt.TabIndex = 10;
            this.btnIzoleEt.Text = "Bölümü İzole Et";
            this.btnIzoleEt.UseVisualStyleBackColor = true;
            this.btnIzoleEt.Click += new System.EventHandler(this.btnIzoleEt_Click);
            //
            // btnAlarmOnayla
            //
            this.btnAlarmOnayla.Location = new System.Drawing.Point(12, 120);
            this.btnAlarmOnayla.Name = "btnAlarmOnayla";
            this.btnAlarmOnayla.Size = new System.Drawing.Size(220, 36);
            this.btnAlarmOnayla.TabIndex = 9;
            this.btnAlarmOnayla.Text = "Alarmları Onayla";
            this.btnAlarmOnayla.UseVisualStyleBackColor = true;
            this.btnAlarmOnayla.Click += new System.EventHandler(this.btnAlarmOnayla_Click);
            //
            // btnVanaKapat
            //
            this.btnVanaKapat.Location = new System.Drawing.Point(353, 72);
            this.btnVanaKapat.Name = "btnVanaKapat";
            this.btnVanaKapat.Size = new System.Drawing.Size(110, 30);
            this.btnVanaKapat.TabIndex = 8;
            this.btnVanaKapat.Text = "Vanayı Kapat";
            this.btnVanaKapat.UseVisualStyleBackColor = true;
            this.btnVanaKapat.Click += new System.EventHandler(this.btnVanaKapat_Click);
            //
            // btnVanaAc
            //
            this.btnVanaAc.Location = new System.Drawing.Point(237, 72);
            this.btnVanaAc.Name = "btnVanaAc";
            this.btnVanaAc.Size = new System.Drawing.Size(110, 30);
            this.btnVanaAc.TabIndex = 7;
            this.btnVanaAc.Text = "Vanayı Aç";
            this.btnVanaAc.UseVisualStyleBackColor = true;
            this.btnVanaAc.Click += new System.EventHandler(this.btnVanaAc_Click);
            //
            // lblVanaDurum
            //
            this.lblVanaDurum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVanaDurum.Location = new System.Drawing.Point(160, 78);
            this.lblVanaDurum.Name = "lblVanaDurum";
            this.lblVanaDurum.Size = new System.Drawing.Size(75, 18);
            this.lblVanaDurum.TabIndex = 6;
            this.lblVanaDurum.Text = "Açık";
            //
            // cmbVana
            //
            this.cmbVana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVana.FormattingEnabled = true;
            this.cmbVana.Items.AddRange(new object[] {
            "V1 - Ceyhan",
            "V2 - Adana",
            "V3 - Pozantı",
            "V4 - Niğde",
            "V5 - Aksaray",
            "V6 - Kırıkkale"});
            this.cmbVana.Location = new System.Drawing.Point(52, 75);
            this.cmbVana.Name = "cmbVana";
            this.cmbVana.Size = new System.Drawing.Size(102, 23);
            this.cmbVana.TabIndex = 5;
            this.cmbVana.SelectedIndexChanged += new System.EventHandler(this.cmbVana_SelectedIndexChanged);
            //
            // lblVana
            //
            this.lblVana.AutoSize = true;
            this.lblVana.Location = new System.Drawing.Point(12, 78);
            this.lblVana.Name = "lblVana";
            this.lblVana.Size = new System.Drawing.Size(34, 15);
            this.lblVana.TabIndex = 4;
            this.lblVana.Text = "Vana";
            //
            // numHiz
            //
            this.numHiz.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numHiz.Location = new System.Drawing.Point(413, 30);
            this.numHiz.Name = "numHiz";
            this.numHiz.Size = new System.Drawing.Size(50, 23);
            this.numHiz.TabIndex = 3;
            this.numHiz.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            //
            // lblHiz
            //
            this.lblHiz.AutoSize = true;
            this.lblHiz.Location = new System.Drawing.Point(318, 33);
            this.lblHiz.Name = "lblHiz";
            this.lblHiz.Size = new System.Drawing.Size(89, 15);
            this.lblHiz.TabIndex = 2;
            this.lblHiz.Text = "Pompa hızı (%)";
            //
            // btnDurdur
            //
            this.btnDurdur.Location = new System.Drawing.Point(160, 24);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(140, 34);
            this.btnDurdur.TabIndex = 1;
            this.btnDurdur.Text = "Hattı Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            //
            // btnBaslat
            //
            this.btnBaslat.Location = new System.Drawing.Point(12, 24);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(140, 34);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Hattı Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            //
            // grpSizinti
            //
            this.grpSizinti.Controls.Add(this.lblSizintiYeri);
            this.grpSizinti.Controls.Add(this.lblSizintiDurum);
            this.grpSizinti.Controls.Add(this.prgFark);
            this.grpSizinti.Controls.Add(this.lblFark);
            this.grpSizinti.Controls.Add(this.lblCikis);
            this.grpSizinti.Controls.Add(this.lblGiris);
            this.grpSizinti.Location = new System.Drawing.Point(756, 508);
            this.grpSizinti.Name = "grpSizinti";
            this.grpSizinti.Size = new System.Drawing.Size(476, 164);
            this.grpSizinti.TabIndex = 5;
            this.grpSizinti.TabStop = false;
            this.grpSizinti.Text = "Sızıntı Tespiti";
            //
            // lblSizintiYeri
            //
            this.lblSizintiYeri.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSizintiYeri.Location = new System.Drawing.Point(12, 132);
            this.lblSizintiYeri.Name = "lblSizintiYeri";
            this.lblSizintiYeri.Size = new System.Drawing.Size(452, 20);
            this.lblSizintiYeri.TabIndex = 5;
            this.lblSizintiYeri.Text = "Sızıntı yeri: -";
            //
            // lblSizintiDurum
            //
            this.lblSizintiDurum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSizintiDurum.Location = new System.Drawing.Point(12, 106);
            this.lblSizintiDurum.Name = "lblSizintiDurum";
            this.lblSizintiDurum.Size = new System.Drawing.Size(452, 20);
            this.lblSizintiDurum.TabIndex = 4;
            this.lblSizintiDurum.Text = "Durum: Hat çalışmıyor";
            //
            // prgFark
            //
            this.prgFark.Location = new System.Drawing.Point(140, 78);
            this.prgFark.Name = "prgFark";
            this.prgFark.Size = new System.Drawing.Size(324, 18);
            this.prgFark.TabIndex = 3;
            //
            // lblFark
            //
            this.lblFark.Location = new System.Drawing.Point(12, 78);
            this.lblFark.Name = "lblFark";
            this.lblFark.Size = new System.Drawing.Size(125, 18);
            this.lblFark.TabIndex = 2;
            this.lblFark.Text = "Fark: %0,0";
            //
            // lblCikis
            //
            this.lblCikis.Location = new System.Drawing.Point(12, 52);
            this.lblCikis.Name = "lblCikis";
            this.lblCikis.Size = new System.Drawing.Size(452, 18);
            this.lblCikis.TabIndex = 1;
            this.lblCikis.Text = "Kırıkkale'ye ulaşan: 0 m³/h";
            //
            // lblGiris
            //
            this.lblGiris.Location = new System.Drawing.Point(12, 28);
            this.lblGiris.Name = "lblGiris";
            this.lblGiris.Size = new System.Drawing.Size(452, 18);
            this.lblGiris.TabIndex = 0;
            this.lblGiris.Text = "Ceyhan'dan basılan: 0 m³/h";
            //
            // grpAriza
            //
            this.grpAriza.Controls.Add(this.btnTankAyarla);
            this.grpAriza.Controls.Add(this.numTankSeviye);
            this.grpAriza.Controls.Add(this.lblTankAyar);
            this.grpAriza.Controls.Add(this.btnArizalariGider);
            this.grpAriza.Controls.Add(this.lblArizaBilgi);
            this.grpAriza.Controls.Add(this.btnRastgeleAriza);
            this.grpAriza.Controls.Add(this.btnPompaArizasi);
            this.grpAriza.Controls.Add(this.btnBaglantiKes);
            this.grpAriza.Controls.Add(this.cmbIstasyon);
            this.grpAriza.Controls.Add(this.lblIstasyon);
            this.grpAriza.Controls.Add(this.btnSizintiOlustur);
            this.grpAriza.Controls.Add(this.txtSizintiMiktar);
            this.grpAriza.Controls.Add(this.lblSizintiMiktar);
            this.grpAriza.Controls.Add(this.cmbSizintiBolum);
            this.grpAriza.Controls.Add(this.lblSizintiBolum);
            this.grpAriza.Location = new System.Drawing.Point(8, 538);
            this.grpAriza.Name = "grpAriza";
            this.grpAriza.Size = new System.Drawing.Size(740, 134);
            this.grpAriza.TabIndex = 6;
            this.grpAriza.TabStop = false;
            this.grpAriza.Text = "Arıza Simülasyonu";
            //
            // btnArizalariGider
            //
            this.btnArizalariGider.Location = new System.Drawing.Point(582, 94);
            this.btnArizalariGider.Name = "btnArizalariGider";
            this.btnArizalariGider.Size = new System.Drawing.Size(145, 30);
            this.btnArizalariGider.TabIndex = 11;
            this.btnArizalariGider.Text = "Arızaları Gider";
            this.btnArizalariGider.UseVisualStyleBackColor = true;
            this.btnArizalariGider.Click += new System.EventHandler(this.btnArizalariGider_Click);
            //
            // lblArizaBilgi
            //
            this.lblArizaBilgi.Location = new System.Drawing.Point(180, 101);
            this.lblArizaBilgi.Name = "lblArizaBilgi";
            this.lblArizaBilgi.Size = new System.Drawing.Size(395, 18);
            this.lblArizaBilgi.TabIndex = 10;
            //
            // btnRastgeleAriza
            //
            this.btnRastgeleAriza.Location = new System.Drawing.Point(14, 94);
            this.btnRastgeleAriza.Name = "btnRastgeleAriza";
            this.btnRastgeleAriza.Size = new System.Drawing.Size(155, 30);
            this.btnRastgeleAriza.TabIndex = 9;
            this.btnRastgeleAriza.Text = "Rastgele Arıza";
            this.btnRastgeleAriza.UseVisualStyleBackColor = true;
            this.btnRastgeleAriza.Click += new System.EventHandler(this.btnRastgeleAriza_Click);
            //
            // btnPompaArizasi
            //
            this.btnPompaArizasi.Location = new System.Drawing.Point(360, 58);
            this.btnPompaArizasi.Name = "btnPompaArizasi";
            this.btnPompaArizasi.Size = new System.Drawing.Size(130, 30);
            this.btnPompaArizasi.TabIndex = 8;
            this.btnPompaArizasi.Text = "P-201 Arızası";
            this.btnPompaArizasi.UseVisualStyleBackColor = true;
            this.btnPompaArizasi.Click += new System.EventHandler(this.btnPompaArizasi_Click);
            //
            // btnBaglantiKes
            //
            this.btnBaglantiKes.Location = new System.Drawing.Point(222, 58);
            this.btnBaglantiKes.Name = "btnBaglantiKes";
            this.btnBaglantiKes.Size = new System.Drawing.Size(130, 30);
            this.btnBaglantiKes.TabIndex = 7;
            this.btnBaglantiKes.Text = "Bağlantıyı Kes";
            this.btnBaglantiKes.UseVisualStyleBackColor = true;
            this.btnBaglantiKes.Click += new System.EventHandler(this.btnBaglantiKes_Click);
            //
            // cmbIstasyon
            //
            this.cmbIstasyon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIstasyon.FormattingEnabled = true;
            this.cmbIstasyon.Items.AddRange(new object[] {
            "Ceyhan",
            "Adana",
            "Pozantı",
            "Niğde",
            "Aksaray",
            "Kırıkkale"});
            this.cmbIstasyon.Location = new System.Drawing.Point(110, 62);
            this.cmbIstasyon.Name = "cmbIstasyon";
            this.cmbIstasyon.Size = new System.Drawing.Size(103, 23);
            this.cmbIstasyon.TabIndex = 6;
            //
            // lblIstasyon
            //
            this.lblIstasyon.AutoSize = true;
            this.lblIstasyon.Location = new System.Drawing.Point(12, 65);
            this.lblIstasyon.Name = "lblIstasyon";
            this.lblIstasyon.Size = new System.Drawing.Size(49, 15);
            this.lblIstasyon.TabIndex = 5;
            this.lblIstasyon.Text = "İstasyon";
            //
            // btnSizintiOlustur
            //
            this.btnSizintiOlustur.Location = new System.Drawing.Point(482, 22);
            this.btnSizintiOlustur.Name = "btnSizintiOlustur";
            this.btnSizintiOlustur.Size = new System.Drawing.Size(130, 30);
            this.btnSizintiOlustur.TabIndex = 4;
            this.btnSizintiOlustur.Text = "Sızıntı Oluştur";
            this.btnSizintiOlustur.UseVisualStyleBackColor = true;
            this.btnSizintiOlustur.Click += new System.EventHandler(this.btnSizintiOlustur_Click);
            //
            // txtSizintiMiktar
            //
            this.txtSizintiMiktar.Location = new System.Drawing.Point(418, 26);
            this.txtSizintiMiktar.Name = "txtSizintiMiktar";
            this.txtSizintiMiktar.Size = new System.Drawing.Size(55, 23);
            this.txtSizintiMiktar.TabIndex = 3;
            this.txtSizintiMiktar.Text = "100";
            this.txtSizintiMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            //
            // lblSizintiMiktar
            //
            this.lblSizintiMiktar.AutoSize = true;
            this.lblSizintiMiktar.Location = new System.Drawing.Point(328, 29);
            this.lblSizintiMiktar.Name = "lblSizintiMiktar";
            this.lblSizintiMiktar.Size = new System.Drawing.Size(84, 15);
            this.lblSizintiMiktar.TabIndex = 2;
            this.lblSizintiMiktar.Text = "Miktar (m³/h)";
            // 
            // cmbSizintiBolum
            // 
            this.cmbSizintiBolum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizintiBolum.FormattingEnabled = true;
            this.cmbSizintiBolum.Items.AddRange(new object[] {
            "V1 - V2  (Ceyhan - Adana)",
            "V2 - V3  (Adana - Pozantı)",
            "V3 - V4  (Pozantı - Niğde)",
            "V4 - V5  (Niğde - Aksaray)",
            "V5 - V6  (Aksaray - Kırıkkale)"});
            this.cmbSizintiBolum.Location = new System.Drawing.Point(110, 26);
            this.cmbSizintiBolum.Name = "cmbSizintiBolum";
            this.cmbSizintiBolum.Size = new System.Drawing.Size(205, 23);
            this.cmbSizintiBolum.TabIndex = 1;
            // 
            // lblSizintiBolum
            // 
            this.lblSizintiBolum.AutoSize = true;
            this.lblSizintiBolum.Location = new System.Drawing.Point(12, 29);
            this.lblSizintiBolum.Name = "lblSizintiBolum";
            this.lblSizintiBolum.Size = new System.Drawing.Size(66, 15);
            this.lblSizintiBolum.TabIndex = 0;
            this.lblSizintiBolum.Text = "Sızıntı yeri";
            // 
            // lblTankAyar
            // 
            this.lblTankAyar.AutoSize = true;
            this.lblTankAyar.Location = new System.Drawing.Point(500, 65);
            this.lblTankAyar.Name = "lblTankAyar";
            this.lblTankAyar.Size = new System.Drawing.Size(48, 15);
            this.lblTankAyar.TabIndex = 12;
            this.lblTankAyar.Text = "Tank %";
            // 
            // numTankSeviye
            // 
            this.numTankSeviye.Location = new System.Drawing.Point(554, 62);
            this.numTankSeviye.Name = "numTankSeviye";
            this.numTankSeviye.Size = new System.Drawing.Size(50, 23);
            this.numTankSeviye.TabIndex = 13;
            this.numTankSeviye.Value = new decimal(new int[] {
            62,
            0,
            0,
            0});
            // 
            // btnTankAyarla
            // 
            this.btnTankAyarla.Location = new System.Drawing.Point(612, 58);
            this.btnTankAyarla.Name = "btnTankAyarla";
            this.btnTankAyarla.Size = new System.Drawing.Size(115, 30);
            this.btnTankAyarla.TabIndex = 14;
            this.btnTankAyarla.Text = "Seviyeyi Ayarla";
            this.btnTankAyarla.UseVisualStyleBackColor = true;
            this.btnTankAyarla.Click += new System.EventHandler(this.btnTankAyarla_Click);
            //
            // tmrSimulasyon
            //
            this.tmrSimulasyon.Interval = 1000;
            this.tmrSimulasyon.Tick += new System.EventHandler(this.tmrSimulasyon_Tick);
            //
            // tmrYanipSonme
            //
            this.tmrYanipSonme.Interval = 500;
            this.tmrYanipSonme.Tick += new System.EventHandler(this.tmrYanipSonme_Tick);
            //
            // tmrRastgeleAriza
            //
            this.tmrRastgeleAriza.Tick += new System.EventHandler(this.tmrRastgeleAriza_Tick);
            //
            // AnaForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1240, 680);
            this.Controls.Add(this.grpAriza);
            this.Controls.Add(this.grpSizinti);
            this.Controls.Add(this.grpKontrol);
            this.Controls.Add(this.grpAlarmlar);
            this.Controls.Add(this.pnlHat);
            this.Controls.Add(this.pnlAlarm);
            this.Controls.Add(this.pnlBaslik);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boru Hattı SCADA";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.pnlBaslik.ResumeLayout(false);
            this.pnlBaslik.PerformLayout();
            this.pnlAlarm.ResumeLayout(false);
            this.pnlHat.ResumeLayout(false);
            this.pnlHat.PerformLayout();
            this.pnlTank.ResumeLayout(false);
            this.grpAlarmlar.ResumeLayout(false);
            this.grpKontrol.ResumeLayout(false);
            this.grpKontrol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHiz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTankSeviye)).EndInit();
            this.grpSizinti.ResumeLayout(false);
            this.grpAriza.ResumeLayout(false);
            this.grpAriza.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBaslik;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblHatDurumu;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Panel pnlAlarm;
        private System.Windows.Forms.Label lblAlarm;
        private System.Windows.Forms.Panel pnlHat;
        private System.Windows.Forms.Label lblP101;
        private System.Windows.Forms.Label lblV1;
        private System.Windows.Forms.Panel pnlBoru1;
        private System.Windows.Forms.Label lblV2;
        private System.Windows.Forms.Panel pnlBoru2;
        private System.Windows.Forms.Label lblP201;
        private System.Windows.Forms.Label lblV3;
        private System.Windows.Forms.Panel pnlBoru3;
        private System.Windows.Forms.Label lblV4;
        private System.Windows.Forms.Panel pnlBoru4;
        private System.Windows.Forms.Label lblV5;
        private System.Windows.Forms.Panel pnlBoru5;
        private System.Windows.Forms.Label lblV6;
        private System.Windows.Forms.Panel pnlBoruTank;
        private System.Windows.Forms.Label lblCeyhan;
        private System.Windows.Forms.Label lblAdana;
        private System.Windows.Forms.Label lblPozanti;
        private System.Windows.Forms.Label lblNigde;
        private System.Windows.Forms.Label lblAksaray;
        private System.Windows.Forms.Label lblKirikkale;
        private System.Windows.Forms.Panel pnlTank;
        private System.Windows.Forms.Panel pnlTankDolu;
        private System.Windows.Forms.Label lblTankAdi;
        private System.Windows.Forms.Label lblTankSeviye;
        private System.Windows.Forms.Label lblSizintiYazi;
        private System.Windows.Forms.Label lblRenkler;
        private System.Windows.Forms.GroupBox grpAlarmlar;
        private System.Windows.Forms.ListView lvAlarmlar;
        private System.Windows.Forms.ColumnHeader colZaman;
        private System.Windows.Forms.ColumnHeader colOncelik;
        private System.Windows.Forms.ColumnHeader colEkipman;
        private System.Windows.Forms.ColumnHeader colAciklama;
        private System.Windows.Forms.ColumnHeader colDurum;
        private System.Windows.Forms.GroupBox grpKontrol;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Label lblHiz;
        private System.Windows.Forms.NumericUpDown numHiz;
        private System.Windows.Forms.Label lblVana;
        private System.Windows.Forms.ComboBox cmbVana;
        private System.Windows.Forms.Label lblVanaDurum;
        private System.Windows.Forms.Button btnVanaAc;
        private System.Windows.Forms.Button btnVanaKapat;
        private System.Windows.Forms.Button btnAlarmOnayla;
        private System.Windows.Forms.Button btnIzoleEt;
        private System.Windows.Forms.GroupBox grpSizinti;
        private System.Windows.Forms.Label lblGiris;
        private System.Windows.Forms.Label lblCikis;
        private System.Windows.Forms.Label lblFark;
        private System.Windows.Forms.ProgressBar prgFark;
        private System.Windows.Forms.Label lblSizintiDurum;
        private System.Windows.Forms.Label lblSizintiYeri;
        private System.Windows.Forms.GroupBox grpAriza;
        private System.Windows.Forms.Label lblSizintiBolum;
        private System.Windows.Forms.ComboBox cmbSizintiBolum;
        private System.Windows.Forms.Label lblSizintiMiktar;
        private System.Windows.Forms.TextBox txtSizintiMiktar;
        private System.Windows.Forms.Button btnSizintiOlustur;
        private System.Windows.Forms.Label lblIstasyon;
        private System.Windows.Forms.ComboBox cmbIstasyon;
        private System.Windows.Forms.Button btnBaglantiKes;
        private System.Windows.Forms.Button btnPompaArizasi;
        private System.Windows.Forms.Button btnRastgeleAriza;
        private System.Windows.Forms.Label lblArizaBilgi;
        private System.Windows.Forms.Button btnArizalariGider;
        private System.Windows.Forms.Label lblTankAyar;
        private System.Windows.Forms.NumericUpDown numTankSeviye;
        private System.Windows.Forms.Button btnTankAyarla;
        private System.Windows.Forms.Timer tmrSimulasyon;
        private System.Windows.Forms.Timer tmrYanipSonme;
        private System.Windows.Forms.Timer tmrRastgeleAriza;
    }
}
