// YANKI ÇİLİNGİR
// 2112705020
// CEYHAN-KIRIKKALE HAM PETROL BORU HATTI SCADA SİMÜLASYONU
// SON REVİZE 18.10.2026

using System;
using System.Drawing; //Renk kullanacağım için eklendi
using System.Windows.Forms; //Form ögeleri

// C#'ın hazır kütüphanelerinin dosyaya eklenmesi için using

namespace BoruHattiScada //Projedeki kodları bir arada tutan ad alan
{
    // ----------------------------------------------------------------------------
    // Projenin her yerinde kullanılabilmesi için public
    // AnaForm.Designer.cs ile AnaForm.cs olarak iki dosyaya bölündüğü için partial
    // Sınıf oluşturmak için class
    // Sınıfın adı AnaForm
    // Form: AnaForm, Windows'un hazır Form sınıfından türetilir.
    //       Başlık çubuğu, kapatma butonu, boyut gibi pencere özelliklerini hazır alır.
    //------ ↓ ↓ ↓ ↓ ↓ ↓ ↓ --------------------------------------------------------

    public partial class AnaForm : Form
    {
        // Değişkenler başka bir sınıf tarafından kullanılmayacağı için başına public yazmadım

        string[] istasyonAdi = { "Ceyhan", "Adana", "Pozantı", "Niğde", "Aksaray", "Kırıkkale" };  // İstasyon isimleri için dizi oluşturuldu
        int[] istasyonKm = { 0, 60, 112, 170, 300, 448 }; // Çıkış noktasından itibaren uzaklıklar diziye atandı, uyarı için

        bool[] vanaAcik = { true, true, true, true, true, true };        // Vana açık kapalı bilgisi 1 bit olduğu için bool
                                                                         // Başlangıç değerleri 0 olmasın diye true girildi
        bool[] baglantiVar = { true, true, true, true, true, true };     // İstasyon haberleşme bilgisi 1 bit olduğu için bool
                                                                         // Başlangıç değerleri 0 olmasın diye true girildi
        bool[] vanaArizali = new bool[6];                                // Vana arızalı bilgisi
        double[] debi = new double[6];                                   // İstasyonda ölçülen debi (m³/h)
        double[] basinc = new double[6];                                 // İstasyonda ölçülen basınç (bar)

        // Bilgileri tek tek değil döngü ile güncellemek içi etiket ve pannelleri diziye koydum
        // Atama işlemi aşağıda yapılmaktadır (Form bileşeni aşağıda oluşacağı için)
        Label[] vanaEtiketleri;     // V1 ... V6 vana etiketleri
        Label[] bilgiEtiketleri;    // istasyonların altındaki basınç ve debi yazıları
        Panel[] borular;            // istasyonlar arasındaki 5 boru parçası


        bool p101Calisiyor = false;          // Ceyhan pompası çalışıyor mu?
        bool p201Calisiyor = false;          // Pozantı pompası çalışıyor mu?
        bool p201Arizali = false;            // Pozantı pompası arızalı mı?

        double hatDebisi = 0;                // pompaların hatta bastığı petrol (m³/h)
        double tankSeviye = 62;              // rafineri tankının doluluğu (%)

        int sizintiBolum = -1;               // sızıntının olduğu bölüm. 0: V1-V2 arası, 1: V2-V3 arası ... -1: sızıntı yok
        double sizintiMiktari = 0;           // sızan petrol (m³/h)

        string hatDurumu = "Durduruldu";     // "Durduruldu", "Çalışıyor", "Sızıntı" veya "İzole"
        double ortalamaFark = 0;             // giriş ile çıkış arasındaki farkın ortalaması (%)
        int sinirAsimSuresi = 0;             // fark kaç saniyedir %1'in üstünde
        int sizintiBaslangic = 0;            // sızıntı bu iki istasyonun arasında
        int sizintiBitis = 0;                // (başlangıç ve bitiş istasyonunun sırası)
        bool yenidenBaslatmaKilidi = false;  // izole edilen bölüm kontrol edilmeden hat başlatılmaz
        bool basincKesmesi = false;          // basınç yükseldiği için pompaların durdurulma değişkeni
        bool tankKesmesi = false;            // tank dolduğu için pompaların durdurulma değişkeni
        int kapaliVanaSuresi = 0;            // pompa, kaç saniyedir kapalı vanaya karşı çalışıyor

        Random rastgele = new Random();      // rastgele sayı üretmek için ekledim
        bool yanik = false;                  // alarmların yanıp sönmesi için

        // Kulanılacak renklerin renk kodunu atadım
        Color yesil = Color.FromArgb(61, 139, 61);
        Color kirmizi = Color.FromArgb(208, 48, 47);
        Color turuncu = Color.FromArgb(232, 138, 0);
        Color koyuGri = Color.FromArgb(74, 74, 74);



        // Kurucu metot: sınıfla aynı isimde, form oluşturulurken (new AnaForm()) ilk bu çalışır
        public AnaForm()
        {
            InitializeComponent();   // tasarım ekranında eklenen bileşenleri oluşturmak için (AnaForm.Designer.cs 'teki kodu çalıştırır)
        }

        private void AnaForm_Load(object sender, EventArgs e) // Form ekranda ilk kez gösterilirken çalışır
        {
            vanaEtiketleri = new Label[] { lblV1, lblV2, lblV3, lblV4, lblV5, lblV6 }; // Yukarıda oluşturulan etikete atama yapıldı
            bilgiEtiketleri = new Label[] { lblCeyhan, lblAdana, lblPozanti, lblNigde, lblAksaray, lblKirikkale };  // istasyon yazılarını sırayla diziye koydum
            borular = new Panel[] { pnlBoru1, pnlBoru2, pnlBoru3, pnlBoru4, pnlBoru5 };  // boru panellerini sırayla diziye koydum

            // açılır listelerde ilk seçili gelecek satırlar program hata vermesin diye
            // SelectedIndex, listede kaçıncı satırın seçili olacağını belirler.
            cmbVana.SelectedIndex = 1;          // V2-Adana
            cmbIstasyon.SelectedIndex = 3;      // Niğde
            cmbSizintiBolum.SelectedIndex = 0;  // V1 - V2 (Ceyhan - Adana)

            tmrSimulasyon.Start();   // her saniye çalışan ana timer
            tmrYanipSonme.Start();   // alarmları yakıp söndüren timer
            EkraniGuncelle();        // program açılır açılmaz ekrandaki yazılar dolsun diye
        }


        // İşlemleri timera bağlı yaptırıyorum sürekli bir butona basılamaz
        private void tmrSimulasyon_Tick(object sender, EventArgs e)
        {
            DebiyiHesapla();       // önce istasyonlardaki debiyi buluyorum
            BasinciHesapla();      //Debiye bağlı olduğu için debinin altında
            TankiHesapla();        // Kırıkkale'ye gelen debiye göre tank dolar ya da boşalır
            SizintiKontrolEt();    // giriş ve çıkış debisini karşılaştırır
            AlarmlariKontrolEt();  // hesaplanan değerlere göre alarm listesini günceller
            EkraniGuncelle();      // en son bütün sonuçları ekrana yazar
        }

        // Hattaki 6 vanadan en az biri kapalıysa true döner
        bool KapaliVanaVarMi()
        {
            for (int i = 0; i < 6; i++)          // 6 vanaya sırayla bakıyorum
            {
                if (vanaAcik[i] == false)        // kapalı vana bulunduysa
                {
                    return true;                 // diğerlerine bakmadan metottan çıkar
                }
            }
            return false;                        // döngü bitti ve kapalı vana bulunmadı
        }

        // Ceyhan'dan başlayarak ilk kapalı vananın sırasını döndürür (V1 kapalıysa 0, V4 kapalıysa 3 ...).
        // Kapalı vana yoksa -1 döner.
        int IlkKapaliVana()
        {
            for (int i = 0; i < 6; i++)
            {
                if (vanaAcik[i] == false)
                {
                    return i;                    // ilk kapalı vananın sırasını gönderir
                }
            }
            return -1;                           // -1 diye bir sıra olmadığı için "kapalı vana yok" anlamında kullandım
        }

        void DebiyiHesapla()
        {
            // Pompaların basması gereken debi. Pompa hızı %80 iken 1100 m³/h olur. ( İnternetten alınan Ceyhan–Kırıkkale hattı bilgisi)
            double hedefDebi = 0;                // pompa çalışmıyorsa veya vana kapalıysa debi 0 olsun
            if (p101Calisiyor == true && KapaliVanaVarMi() == false)
            {
                hedefDebi = 1375 * (double)numHiz.Value / 100;   // 1375 = %100 hızdaki debi (1100 / 0,8). numHiz decimal olduğu için double'a çevirdim

                // Pozantı pompası çalışmıyorsa petrol tek pompayla itilir, debi yarıya düşer
                if (p201Calisiyor == false)
                {
                    hedefDebi = hedefDebi / 2;
                }
            }

            // Gerçekçi olması için debiyi her saniye hedefle arasındaki farkın %30u kadar arttırdım.
            hatDebisi = hatDebisi + (hedefDebi - hatDebisi) * 0.3;

            // Her istasyonun debisinin bulunması için döngü
            for (int i = 0; i < 6; i++)
            {
                // haberleşme yoksa yeni değer gelmez, ekranda eski değer kalır
                if (baglantiVar[i] == false)
                {
                    continue; // göndüyü bu tür atla
                }

                double gercekDebi = hatDebisi;   // sızıntı yoksa her istasyondan hattın debisi geçer

                // Sızıntıdan sonraki istasyonlara, sızan miktar kadar az petrol ulaşır.
                // Örnek: sızıntı 1. bölümdeyse (V2-V3 arası) Pozantı ve sonrasında debi düşer.
                // sızıntıda bölüm varsa ve bu istasyon sızıntıdan sonraysa ve hatta petrol akıyorsa( akmıyorsa debiyi etkilemesin diye)
                if (sizintiBolum != -1 && i > sizintiBolum && hatDebisi > 50)
                {
                    gercekDebi = hatDebisi - sizintiMiktari;
                }

                // Sensör için hata payı eklendi
                // rastgele.NextDouble() ile 0-1 arası sayı oluşturuldu
                // - 0.5 ile aralık ortaya kaydırıldı. (-0.5 ile 0.5 arası rastgele sayı oluşturulmuş gibi yapıldı)
                // %0,3 hata payı olması için 0.006 ile çarpıldı
                double hata = (rastgele.NextDouble() - 0.5) * 0.006;
                debi[i] = gercekDebi + gercekDebi * hata;   // gerçek debiye hata payını ekleyip sensörün okuduğu değeri buldum
            }
        }

        void BasinciHesapla()
        {
            // Basınç pompanın çıkışında en yüksektir. Bir sonraki pompaya kadar
            // borudaki sürtünme yüzünden azalarak 5 bar'a iner
            // Debi 1100 m³/h iken pompa çıkışı 60 bar olur. Debi artarsa basınç da artar. (60 bar temsili benim seçtiğim değer)
            double ceyhanCikis = 5 + 55 * hatDebisi / 1100; // (5) pompanın giriş basıncı, (55) pompanın normal debide eklediği basınç
                                                            // (hatDebisi / 1100) o anki debinin normal debiye oranı (hız %80 iken)

            double pozantiCikis = 5;                        // P-201 çalışmıyorsa basıncı yükseltemez, 5 bar'da kalır
            if (p201Calisiyor == true)
            {
                pozantiCikis = 5 + 55 * hatDebisi / 1100;   // P-201 basıncı yeniden yükseltir
            }

            for (int i = 0; i < 6; i++)
            {
                if (baglantiVar[i] == false)
                {
                    continue; // döngüyü bu tur için atla
                }

                // Bölge sınıflandırma
                if (istasyonKm[i] < 112)
                {
                    // Ceyhan ile Pozantı arası (112 km)
                    basinc[i] = ceyhanCikis - (ceyhanCikis - 5) * istasyonKm[i] / 112;
                    // İstasyon	   Km            Hesap	        Basınç
                    // Ceyhan       0       60 − 55 × 0 / 112     60,0
                    // Adana       60       60 − 55 × 60 / 112    30,5
                }
                else
                {
                    // Pozantı ile Kırıkkale arası (336 km)
                    basinc[i] = pozantiCikis - (pozantiCikis - 5) * (istasyonKm[i] - 112) / 336;

                    // İstasyon	   Km            Hesap	        Basınç
                    // Pozantı    112       60 − 55 × 0 / 336     60,0
                    // Niğde      170       60 − 55 × 58 / 336    50,5
                    // Aksaray    300       60 − 55 × 188 / 336   29,2
                    // Kırıkkale  448       60 − 55 × 336 / 336    5,0
                }
            }

            // Pompa çalışırken bir vana kapalıysa petrol gidecek yer bulamaz, hattın tamamında akış durur.
            // Pompalar petrolü itmeye devam ettiği için Ceyhan'dan kapalı vanaya kadar
            // bütün istasyonlarda (iki pompada da) basınç her saniye artar.
            int kapaliVana = IlkKapaliVana();
            if (p101Calisiyor == true && kapaliVana != -1)
            {
                kapaliVanaSuresi = kapaliVanaSuresi + 1;             // timer her saniye çalıştığı için saniye sayacı gibi artar
                double yukselenBasinc = 60 + 6 * kapaliVanaSuresi;   // 66, 72, 78, 84 

                // Ceyhan'dan (0) kapalı vananın olduğu istasyona kadar basınç yükselir
                for (int i = 0; i <= kapaliVana; i++)
                {
                    basinc[i] = yukselenBasinc;
                }

                // Basınç 78 bar'ı geçerse boru zarar görmesin diye pompalar durdurulur
                if (yukselenBasinc > 78)
                {
                    PompalariDurdur();
                    basincKesmesi = true;        // alarm listesinde "BASINÇ" alarmı çıksın diye
                }
            }
            else
            {
                kapaliVanaSuresi = 0;            // vana açıldıysa veya pompa durduysa sayacı sıfırladım
            }
        }

        void TankiHesapla()
        {
            // Kırıkkale'ye gelen petrol tankı doldurur, rafineri saatte 1100 m³ çekerek boşaltır.
            // Tank 1500 m³. Debi saatlik olduğu için 3600'e bölünür (1 saniyelik değişim).
            double cekilen = 1100;
            if (tankSeviye < 5)
            {
                cekilen = 0;   // tank neredeyse boşsa rafineri çekmeyi durdurur
            }
            tankSeviye = tankSeviye + (debi[5] - cekilen) / 1500 * 100 / 3600;   // (giren - çıkan) / tank hacmi * 100 ile yüzdeye çevirdim

            if (tankSeviye > 100) tankSeviye = 100;   // tank %100'ün üstüne çıkamaz
            if (tankSeviye < 0) tankSeviye = 0;       // tank %0'ın altına inemez

            // Tank taşmasın diye %95'te pompalar durdurulur
            if (tankSeviye > 95 && p101Calisiyor == true)
            {
                PompalariDurdur();
                tankKesmesi = true;      // alarm listesinde "TANK" alarmı çıksın diye
            }
        }

        void SizintiKontrolEt()
        {
            // Ceyhan veya Kırıkkale ile haberleşme yoksa giriş ve çıkış karşılaştırılamaz
            if (baglantiVar[0] == false || baglantiVar[5] == false)
            {
                ortalamaFark = 0;
                sinirAsimSuresi = 0;
                return;                  // metodun geri kalanı çalışmasın diye çıkıyorum
            }

            // Ceyhan'dan basılan ile Kırıkkale'ye ulaşan arasındaki fark (yüzde olarak)
            double fark = 0;
            if (debi[0] > 100)           // hat çalışmıyorken (debi 0 iken) sıfıra bölme olmasın diye
            {
                fark = (debi[0] - debi[5]) / debi[0] * 100;
            }

            // Sensör hatası yüzünden fark biraz oynar. Bu yüzden ortalama alınır:
            // eski ortalamanın %80'i + yeni farkın %20'si
            ortalamaFark = ortalamaFark * 0.8 + fark * 0.2;

            // Fark 5 saniye boyunca %1'in üstünde kalırsa sızıntı alarmı verilir
            if (ortalamaFark > 1)
            {
                sinirAsimSuresi = sinirAsimSuresi + 1;   // her saniye 1 artar
            }
            else
            {
                sinirAsimSuresi = 0;                     // fark düştüyse saymaya baştan başlar
            }

            if (sinirAsimSuresi >= 5 && hatDurumu == "Çalışıyor")
            {
                hatDurumu = "Sızıntı";
                SizintiYeriniBul();      // sızıntının hangi iki istasyon arasında olduğunu bulur
            }
        }

        void SizintiYeriniBul()
        {
            // İstasyonların debileri sırayla karşılaştırılır. Debinin düştüğü ilk iki istasyonun arasında sızıntı vardır.
            // Örnek: Ceyhan 1100, Adana 1100, Pozantı 1000 ise sızıntı Adana ile Pozantı arasındadır.
            int onceki = 0;              // karşılaştırmaya Ceyhan'dan başlıyorum
            for (int i = 1; i < 6; i++)
            {
                if (baglantiVar[i] == false)
                {
                    continue;   // haberleşme olmayan istasyon atlanır
                }

                if (debi[onceki] - debi[i] > 20)         // iki istasyon arasında 20 m³/h'ten fazla fark varsa (20 sensör hatası olmasın diye)
                {
                    sizintiBaslangic = onceki;
                    sizintiBitis = i;
                    return;                              // yeri bulduğum için döngüden çıkıyorum
                }
                onceki = i;                              // fark yoksa bir sonraki istasyona geçiyorum
            }
        }

    
        void AlarmlariKontrolEt()
        {
            // AlarmDurumu(ekipman adı, öncelik, alarm var mı, açıklama)
            AlarmDurumu("LDS-01", "1", hatDurumu == "Sızıntı" || hatDurumu == "İzole", "Sızıntı: " + SizintiYeri());
            AlarmDurumu("BASINÇ", "1", basincKesmesi, "Hat basıncı 78 bar'ı aştı, pompalar durduruldu");
            AlarmDurumu("P-201", "1", p201Arizali, "Pozantı pompası arızalı, debi yarıya düştü");
            AlarmDurumu("TANK", "1", tankKesmesi, "Tank doldu, pompalar durduruldu");
            AlarmDurumu("TANK-H", "2", tankSeviye > 85, "Tank seviyesi yüksek");
            AlarmDurumu("TANK-L", "2", tankSeviye < 20, "Tank seviyesi düşük");

            // Her istasyon için vana arızası ve haberleşme alarmı
            for (int i = 0; i < 6; i++)
            {
                AlarmDurumu("V" + (i + 1), "2", vanaArizali[i], "V" + (i + 1) + " vanası kendiliğinden kapandı");
                AlarmDurumu(istasyonAdi[i], "3", baglantiVar[i] == false, istasyonAdi[i] + " istasyonu ile haberleşme yok");
            }
        }

        // Alarm varsa listeye ekler, alarm geçtiyse listeden siler.
        // Yeni eklenen alarmın durumu "Yeni" olur ve yanıp söner. Operatör onaylayınca "Görüldü" olur.
        void AlarmDurumu(string ekipman, string oncelik, bool alarmVar, string aciklama)
        {
            ListViewItem satir = lvAlarmlar.Items[ekipman];   // bu alarm listede var mı? (yoksa null döner)

            if (alarmVar == true && satir == null)            // alarm var ama listede yoksa ekle
            {
                satir = new ListViewItem(DateTime.Now.ToString("HH:mm:ss"));   // 1. sütun: zaman
                satir.Name = ekipman;                                            // alarmı sonra bulmak için ad veriyoruz
                satir.SubItems.Add(oncelik);                                     // 2. sütun
                satir.SubItems.Add(ekipman);                                     // 3. sütun
                satir.SubItems.Add(aciklama);                                    // 4. sütun
                satir.SubItems.Add("Yeni");                                      // 5. sütun
                lvAlarmlar.Items.Insert(0, satir);                               // listenin en üstüne ekle
            }

            if (alarmVar == false && satir != null)           // alarm geçti ama listede duruyorsa sil
            {
                lvAlarmlar.Items.Remove(satir);
            }
        }

        // İkinci timer: her yarım saniyede çalışır (Interval = 500 ms) ve yeni alarmları yakıp söndürür
        private void tmrYanipSonme_Tick(object sender, EventArgs e)
        {
            yanik = !yanik;   // true ise false, false ise true yapar

            foreach (ListViewItem satir in lvAlarmlar.Items)   // listedeki her alarm satırına sırayla bakar
            {
                if (satir.SubItems[4].Text == "Yeni" && yanik == false)
                {
                    satir.BackColor = Color.White;                         // sönük
                }
                else
                {
                    satir.BackColor = AlarmRengi(satir.SubItems[1].Text);  // yanık
                }
            }

            // Üstteki alarm bandında listenin en üstündeki (en son gelen) alarm gösterilir
            if (lvAlarmlar.Items.Count == 0)
            {
                lblAlarm.Text = "Aktif alarm yok";
                pnlAlarm.BackColor = Color.FromArgb(228, 228, 228);   // alarm yoksa açık gri
            }
            else
            {
                ListViewItem ilk = lvAlarmlar.Items[0];              // listenin en üstündeki alarm
                lblAlarm.Text = ilk.Text + "     " + ilk.SubItems[2].Text + "     " + ilk.SubItems[3].Text;   // zaman, ekipman, açıklama
                pnlAlarm.BackColor = ilk.BackColor;                  // bant da alarmla birlikte yanıp söner
            }
        }

        // Alarmın önceliğine göre rengini döndürür
        Color AlarmRengi(string oncelik)
        {
            if (oncelik == "1") return Color.FromArgb(240, 120, 120);   // 1: kritik (kırmızı)
            if (oncelik == "2") return Color.FromArgb(250, 185, 90);    // 2: önemli (turuncu)
            return Color.FromArgb(245, 225, 110);                       // 3: uyarı (sarı)
        }

      
        void EkraniGuncelle()
        {
            lblSaat.Text = DateTime.Now.ToString("dd.MM.yyyy   HH:mm:ss");   // sağ üstteki tarih ve saat

            // Üstteki hat durumu
            if (hatDurumu == "Çalışıyor")
            {
                lblHatDurumu.Text = "Hat çalışıyor";
                lblHatDurumu.BackColor = yesil;
            }
            else if (hatDurumu == "Sızıntı")
            {
                lblHatDurumu.Text = "SIZINTI ALARMI";
                lblHatDurumu.BackColor = kirmizi;
            }
            else if (hatDurumu == "İzole")
            {
                lblHatDurumu.Text = "Bölüm izole edildi";
                lblHatDurumu.BackColor = turuncu;
            }
            else
            {
                lblHatDurumu.Text = "Hat durduruldu";
                lblHatDurumu.BackColor = Color.Gray;
            }

            // Pompalar: çalışıyorsa yeşil, duruyorsa gri, arızalıysa kırmızı
            if (p101Calisiyor == true) lblP101.BackColor = yesil;
            else lblP101.BackColor = Color.Gray;

            if (p201Arizali == true) lblP201.BackColor = kirmizi;
            else if (p201Calisiyor == true) lblP201.BackColor = yesil;
            else lblP201.BackColor = Color.Gray;

            // Vanalar ve istasyon bilgileri
            for (int i = 0; i < 6; i++)
            {
                // Vana: açık yeşil, kapalı beyaz, haberleşme yoksa gri
                if (baglantiVar[i] == false)
                {
                    vanaEtiketleri[i].BackColor = Color.Silver;
                    vanaEtiketleri[i].ForeColor = Color.Black;
                }
                else if (vanaAcik[i] == true)
                {
                    vanaEtiketleri[i].BackColor = yesil;
                    vanaEtiketleri[i].ForeColor = Color.White;
                }
                else
                {
                    vanaEtiketleri[i].BackColor = Color.White;
                    vanaEtiketleri[i].ForeColor = Color.Black;   // beyaz zemin üstünde yazı siyah olmalı
                }

                // İstasyonun altındaki yazı (\n alt satıra geçer)
                // ToString("0.0") virgülden sonra 1 basamak, ToString("0") hiç basamak göstermez
                string yazi = istasyonAdi[i] + " (km " + istasyonKm[i] + ")\n"
                            + "Basınç: " + basinc[i].ToString("0.0") + " bar\n"
                            + "Debi: " + debi[i].ToString("0") + " m³/h";

                if (baglantiVar[i] == false)
                {
                    yazi = yazi + "\nBağlantı yok!";              // haberleşme yoksa yazının altına ekledim
                    bilgiEtiketleri[i].ForeColor = Color.Gray;   // değerler eski olduğu için gri
                }
                else
                {
                    bilgiEtiketleri[i].ForeColor = Color.Black;
                }
                bilgiEtiketleri[i].Text = yazi;                  // hazırlanan yazıyı etikete yazdım
            }

            // Borular normalde koyu gri, sızıntı olan bölüm kırmızı
            for (int i = 0; i < 5; i++)
            {
                borular[i].BackColor = koyuGri;
            }
            lblSizintiYazi.Visible = false;      // sızıntı yoksa "SIZINTI" yazısı gizli

            if (hatDurumu == "Sızıntı" || hatDurumu == "İzole")
            {
                for (int i = sizintiBaslangic; i < sizintiBitis; i++)   // sızıntılı istasyonlar arasındaki boruları kırmızı yapar
                {
                    borular[i].BackColor = kirmizi;
                }

                // "SIZINTI" yazısını kırmızı borunun ortasına taşı
                Panel boru = borular[sizintiBaslangic];
                lblSizintiYazi.Left = boru.Left + boru.Width / 2 - lblSizintiYazi.Width / 2;
                lblSizintiYazi.Visible = true;

                if (hatDurumu == "İzole") lblSizintiYazi.Text = "İZOLE EDİLDİ";
                else lblSizintiYazi.Text = "SIZINTI";
            }

            // Tank: içteki mavi panelin yüksekliği doluluk kadar olur
            pnlTankDolu.Height = (int)(pnlTank.Height * tankSeviye / 100);   // yükseklik tam sayı olmalı, (int) ile çevirdim
            lblTankSeviye.Text = "%" + tankSeviye.ToString("0");

            // Sızıntı tespiti bölümü
            lblGiris.Text = "Ceyhan'dan basılan: " + debi[0].ToString("0") + " m³/h";
            lblCikis.Text = "Kırıkkale'ye ulaşan: " + debi[5].ToString("0") + " m³/h";

            double gosterilenFark = ortalamaFark;
            if (gosterilenFark < 0) gosterilenFark = 0;   // sensör hatası yüzünden eksi çıkabilir
            if (gosterilenFark > 10) gosterilenFark = 10;  // çubuk taşmasın diye en fazla %10
            lblFark.Text = "Fark: %" + gosterilenFark.ToString("0.0");
            prgFark.Value = (int)(gosterilenFark * 10);    // çubuk %10 farkta tamamen dolar (Maximum = 100)

            if (hatDurumu == "Sızıntı")
            {
                lblSizintiDurum.Text = "Durum: SIZINTI VAR";
                lblSizintiDurum.ForeColor = kirmizi;
            }
            else
            {
                lblSizintiDurum.ForeColor = Color.Black;
                if (hatDurumu == "İzole") lblSizintiDurum.Text = "Durum: Sızıntılı bölüm izole edildi";
                else if (p101Calisiyor == false) lblSizintiDurum.Text = "Durum: Hat çalışmıyor";
                else lblSizintiDurum.Text = "Durum: Normal";
            }

            if (hatDurumu == "Sızıntı" || hatDurumu == "İzole")
            {
                lblSizintiYeri.Text = "Sızıntı yeri: " + SizintiYeri();
            }
            else
            {
                lblSizintiYeri.Text = "Sızıntı yeri: -";
            }

            VanaDurumunuYaz();       // Hat Kontrolü'ndeki vana durumu yazısı da güncellensin
        }

        // Sızıntının yerini yazı olarak döndürür. Örnek: "Ceyhan ile Adana arası"
        string SizintiYeri()
        {
            return istasyonAdi[sizintiBaslangic] + " ile " + istasyonAdi[sizintiBitis] + " arası";
        }

        // Hat Kontrolü bölümünde seçili vananın durumunu yazar
        void VanaDurumunuYaz()
        {
            int i = cmbVana.SelectedIndex;   // listede seçili vananın sırası

            if (baglantiVar[i] == false)
            {
                lblVanaDurum.Text = "Bilinmiyor";        // haberleşme yoksa vananın durumunu bilemeyiz
                lblVanaDurum.ForeColor = Color.Gray;
            }
            else if (vanaAcik[i] == true)
            {
                lblVanaDurum.Text = "Açık";
                lblVanaDurum.ForeColor = yesil;
            }
            else
            {
                lblVanaDurum.Text = "Kapalı";
                lblVanaDurum.ForeColor = kirmizi;
            }
        }


        private void btnBaslat_Click(object sender, EventArgs e)
        {
            HattiBaslat();   // başlatma kodu vana açınca da kullanıldığı için ayrı metoda yazdım
        }

        void HattiBaslat()
        {
            // İzole edilen bölüm kontrol edilmeden hat çalıştırılmaz
            if (yenidenBaslatmaKilidi == true)
            {
                DialogResult cevap = MessageBox.Show("Sızıntılı bölüm kontrol edildi mi?", "Yeniden başlatma", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.No)
                {
                    return;                          // "Hayır" denirse hat başlatılmaz
                }
                yenidenBaslatmaKilidi = false;       // "Evet" denirse kilit kalkar
            }

            // Kapalı vana varsa hat başlatılmaz
            if (KapaliVanaVarMi() == true)
            {
                MessageBox.Show("Kapalı vana var. Önce vanaları açın.");
                return;
            }

            // Tank doluysa hat başlatılmaz, başlatılsa bile pompalar hemen durur
            if (tankSeviye > 95)
            {
                MessageBox.Show("Tank dolu (%" + tankSeviye.ToString("0") + "). Hat başlatılamaz.");
                return;
            }

            p101Calisiyor = true;
            if (p201Arizali == false)        // P-201 arızalıysa çalıştırılmaz
            {
                p201Calisiyor = true;
            }
            basincKesmesi = false;           // hat yeniden başladığı için eski kesme alarmları silinir
            tankKesmesi = false;
            ortalamaFark = 0;                // eski sızıntıdan kalan fark yeni çalışmada yanlış alarm vermesin diye sıfırladım
            sinirAsimSuresi = 0;
            hatDurumu = "Çalışıyor";
            EkraniGuncelle();
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            PompalariDurdur();
            EkraniGuncelle();
        }

        // İki pompayı birden durdurur
        void PompalariDurdur()
        {
            p101Calisiyor = false;
            p201Calisiyor = false;
            if (hatDurumu == "Çalışıyor")    // sızıntı veya izole durumundaysa o yazı ekranda kalsın diye
            {
                hatDurumu = "Durduruldu";
            }
        }

        // Listeden başka vana seçilince durumu yazılır
        private void cmbVana_SelectedIndexChanged(object sender, EventArgs e)
        {
            VanaDurumunuYaz();
        }

        private void btnVanaAc_Click(object sender, EventArgs e)
        {
            int i = cmbVana.SelectedIndex;   // listede seçili vananın sırası (0-5)

            if (baglantiVar[i] == false)
            {
                MessageBox.Show(istasyonAdi[i] + " istasyonu ile haberleşme yok. Vana açılamadı.");
                return;
            }

            vanaAcik[i] = true;
            vanaArizali[i] = false;          // vana açılınca arıza alarmı da gider
            EkraniGuncelle();

            // Bütün vanalar açıldıysa ve pompalar duruyorsa hattın yeniden başlatılması sorulur
            if (KapaliVanaVarMi() == false && p101Calisiyor == false)
            {
                DialogResult cevap = MessageBox.Show("Bütün vanalar açık ama pompalar duruyor. Hat yeniden başlatılsın mı?", "Vana", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.Yes)
                {
                    HattiBaslat();
                }
            }
        }

        private void btnVanaKapat_Click(object sender, EventArgs e)
        {
            int i = cmbVana.SelectedIndex;   // listede seçili vananın sırası (0-5)

            if (baglantiVar[i] == false)
            {
                MessageBox.Show(istasyonAdi[i] + " istasyonu ile haberleşme yok. Vana kapatılamadı.");
                return;
            }

            // Pompa çalışırken vana kapatmak basıncı yükseltir, bu yüzden operatöre sorulur
            if (p101Calisiyor == true)
            {
                DialogResult cevap = MessageBox.Show("Pompa çalışırken vana kapatılırsa basınç yükselir. Yine de kapatılsın mı?", "Vana", MessageBoxButtons.YesNo);
                if (cevap == DialogResult.No)
                {
                    return;
                }
            }

            vanaAcik[i] = false;
            EkraniGuncelle();
        }

        private void btnAlarmOnayla_Click(object sender, EventArgs e)
        {
            // Bütün yeni alarmlar "Görüldü" olur, yanıp sönmeleri durur
            foreach (ListViewItem satir in lvAlarmlar.Items)
            {
                satir.SubItems[4].Text = "Görüldü";   // 5. sütun (Durum)
            }
        }

        private void btnIzoleEt_Click(object sender, EventArgs e)
        {
            if (hatDurumu != "Sızıntı")      // sızıntı yokken butona basılırsa uyarı verir
            {
                MessageBox.Show("İzole edilecek bir sızıntı yok.");
                return;
            }

            string vanalar = "V" + (sizintiBaslangic + 1) + " ve V" + (sizintiBitis + 1);   // dizi 0'dan başladığı için +1 ekledim
            DialogResult cevap = MessageBox.Show("Pompalar durdurulacak, " + vanalar + " vanaları kapatılacak. Onaylıyor musunuz?", "Bölüm izolasyonu", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.No)
            {
                return;
            }

            // Pompalar durur, sızıntılı bölümün iki yanındaki vanalar kapanır
            PompalariDurdur();
            vanaAcik[sizintiBaslangic] = false;
            vanaAcik[sizintiBitis] = false;
            hatDurumu = "İzole";
            yenidenBaslatmaKilidi = true;    // tekrar başlatmadan önce "kontrol edildi mi?" diye sorulsun
            EkraniGuncelle();
        }


        private void btnSizintiOlustur_Click(object sender, EventArgs e)
        {
            double miktar;   // kutuya yazılan sayı buraya gelecek

            // Kutuya yazılan değer sayı mı ve 50 ile 300 arasında mı?
            // TryParse: yazı sayıya çevrilebiliyorsa true döner ve sayıyı "miktar" değişkenine yazar
            if (double.TryParse(txtSizintiMiktar.Text, out miktar) == false || miktar < 50 || miktar > 300)
            {
                MessageBox.Show("Sızıntı miktarı 50 ile 300 arasında bir sayı olmalıdır.");
                txtSizintiMiktar.Focus();    // imleci tekrar kutuya götürür
                return;
            }

            sizintiBolum = cmbSizintiBolum.SelectedIndex;   // listeden seçilen bölüm
            sizintiMiktari = miktar;
            lblArizaBilgi.Text = "Sızıntı oluşturuldu: V" + (sizintiBolum + 1) + " - V" + (sizintiBolum + 2) + " arası, " + miktar + " m³/h";

            if (p101Calisiyor == false)      // hat durmuşsa petrol akmadığı için sızıntı görünmez
            {
                lblArizaBilgi.Text = lblArizaBilgi.Text + " (hat çalışınca görülür)";
            }
        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            int i = cmbIstasyon.SelectedIndex;   // listeden seçilen istasyon
            baglantiVar[i] = false;
            lblArizaBilgi.Text = istasyonAdi[i] + " istasyonu ile haberleşme kesildi";
            EkraniGuncelle();
        }

        private void btnPompaArizasi_Click(object sender, EventArgs e)
        {
            p201Arizali = true;
            p201Calisiyor = false;           // arızalı pompa çalışamaz
            lblArizaBilgi.Text = "P-201 pompası arızalandı";
            EkraniGuncelle();
        }

        private void btnTankAyarla_Click(object sender, EventArgs e)
        {
            // Tank seviyesini elle değiştirip tank alarmlarını denemek için ekledim
            // NumericUpDown'da Minimum 0, Maximum 100 olduğu için yanlış değer girilemez
            // Value decimal olduğu için double'a çevirdim
            tankSeviye = (double)numTankSeviye.Value;
            lblArizaBilgi.Text = "Tank seviyesi %" + tankSeviye + " yapıldı";

            // %85 üstü yüksek, %20 altı düşük seviye alarmı verir. %95'i geçerse pompalar durur
            EkraniGuncelle();
        }

        private void btnRastgeleAriza_Click(object sender, EventArgs e)
        {
            // Üçüncü timer: arıza 5 ile 20 saniye arasında rastgele bir anda oluşur
            tmrRastgeleAriza.Interval = rastgele.Next(5000, 20001);   // Next(5000, 20001): 5000 ile 20000 arası (üst sınır dahil değil)
            tmrRastgeleAriza.Start();
            lblArizaBilgi.Text = "Rastgele arıza bekleniyor...";
        }

        private void tmrRastgeleAriza_Tick(object sender, EventArgs e)
        {
            tmrRastgeleAriza.Stop();   // sadece bir kez çalışsın

            int arizaTuru = rastgele.Next(0, 4);   // 0, 1, 2 veya 3 sayısından biri

            if (arizaTuru == 0)
            {
                // Rastgele bir bölümde sızıntı
                sizintiBolum = rastgele.Next(0, 5);          // 0-4 arası, 5 bölümden biri
                sizintiMiktari = rastgele.Next(50, 151);     // 50-150 m³/h arası
            }
            else if (arizaTuru == 1)
            {
                // V2, V3, V4 veya V5 vanası kendiliğinden kapanır
                int i = rastgele.Next(1, 5);
                vanaAcik[i] = false;
                vanaArizali[i] = true;
            }
            else if (arizaTuru == 2)
            {
                // Ceyhan dışındaki bir istasyonla haberleşme kopar
                int i = rastgele.Next(1, 6);
                baglantiVar[i] = false;
            }
            else
            {
                // Pozantı pompası arızalanır
                p201Arizali = true;
                p201Calisiyor = false;
            }

            // Arızanın ne olduğu yazılmaz, operatör ekrana bakarak bulmalıdır
            lblArizaBilgi.Text = "Rastgele arıza oluştu!";
        }

        private void btnArizalariGider_Click(object sender, EventArgs e)
        {
            // Bütün arıza değişkenlerini başlangıç değerine döndürdüm
            tmrRastgeleAriza.Stop();         // bekleyen rastgele arıza varsa iptal olur
            sizintiBolum = -1;               // -1: sızıntı yok
            sizintiMiktari = 0;
            p201Arizali = false;
            if (p101Calisiyor == true)       // hat çalışıyorsa P-201 de tekrar çalışır
            {
                p201Calisiyor = true;
            }
            for (int i = 0; i < 6; i++)
            {
                baglantiVar[i] = true;       // bütün istasyonlarla haberleşme geri gelir
            }
            if (hatDurumu == "Sızıntı")
            {
                hatDurumu = "Çalışıyor";
            }
            ortalamaFark = 0;                // sızıntı giderildiği için fark ve sayaç sıfırlanır
            sinirAsimSuresi = 0;
            lblArizaBilgi.Text = "Arızalar giderildi (kapalı vanaları operatör açmalı)";
            EkraniGuncelle();
        }
    }
}
