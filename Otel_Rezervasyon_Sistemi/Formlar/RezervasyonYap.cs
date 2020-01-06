using Otel_Rezervasyon_Sistemi.BLL;
using Otel_Rezervasyon_Sistemi.EF;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Otel_Rezervasyon_Sistemi.Formlar
{
    public partial class RezervasyonYap : Form
    {
        Rezervasyon rezervasyon;
        public static int kayitliUyeID;
        RezervasyonController RezervasyonController = new RezervasyonController();
        RezervasyonTipiController RezervasyonTipiController = new RezervasyonTipiController();
        FiyatController fiyatController = new FiyatController();
        Musteri musteri;
        MusteriController MusteriController = new MusteriController();
        Oda Oda = new Oda();
        OdaController OdaController = new OdaController();
        MusteriEkran MusteriEkran = new MusteriEkran();
        int standart = (int)RezervasyonTipi.Standart;
        int full = (int)RezervasyonTipi.Full;
        int fullartifull = (int)RezervasyonTipi.FullArtıFull;

        
        public Yonetici Yonetici;


        decimal sabitFiyat,
         haftaSonuFiyat,
         haftaSonuFiyatOran,
         tekKisilikOdaFiyat,
         tekKisilikOdaFiyatOran,
         kisiSayisiUcFiyat,
         kisiSayisiUcFiyatOran,
         fullOdaFiyat,
         fullArtıFullOdaFiyat,
         fullOdaOran,
         fullArtıFullOdaOran,
         fiyat,
         toplamTutar;
         int c = 0;

     
        private void cmbRezervasyonTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 1; i <= cmbRezervasyonTipi.Items.Count; i++)
            {
                if (cmbRezervasyonTipi.SelectedIndex == i - 1)
                {
                    lblRezTipAcıklama.Text = RezervasyonTipiController.RezervasyonTipiAcıklamaGetir(i).ToString();
                    
                }
            }

        }

        string rezervasyonTipi;

        private void btnBosOda_Click(object sender, EventArgs e)
        {
            cmbOdaNo.DataSource = OdaController.BosOdalariGetir();
            cmbOdaNo.DisplayMember = "OdaNumarasi";
            cmbOdaNo.ValueMember = "OdaID";
        }

        private void btnFiyatGor_Click(object sender, EventArgs e)
        {
            try
            {
                FiyatHesapla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public RezervasyonYap()
        {
            InitializeComponent();
          
        }

        private void RezervasyonYap_Load(object sender, EventArgs e)
        {
            

            sabitFiyat = fiyatController.FiyatOranGetir(1);
            tekKisilikOdaFiyatOran = fiyatController.FiyatOranGetir(2);
            kisiSayisiUcFiyatOran = fiyatController.FiyatOranGetir(3);
            haftaSonuFiyatOran = fiyatController.FiyatOranGetir(4);
            fullOdaOran = fiyatController.FiyatOranGetir(5);
            fullArtıFullOdaOran = fiyatController.FiyatOranGetir(6);

            lblYatakSayisi.Text = nudKisiSayisi.Value.ToString();
            lblFiyat.Text = string.Empty;
           

            nudOdaSayisi.Minimum = 0;
            nudOdaSayisi.Maximum = 6;

            dtpGirisTarihi.MinDate = DateTime.Now;
            dtpCikisTarihi.MinDate = dtpGirisTarihi.MinDate.AddDays(1);

            cmbRezervasyonTipi.DataSource = RezervasyonTipiController.RezervasyonTipleriniGetir();
            cmbRezervasyonTipi.DisplayMember = "Tipi";
            cmbRezervasyonTipi.ValueMember = "RezervasyonTipiId";
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            rezervasyon = new Rezervasyon();

            do
            {

            try
            {
                if (dtpGirisTarihi.Value.Date >= DateTime.Now.Date)
                {
                    rezervasyon.GirisTarihi = dtpGirisTarihi.Value;
                }
                else
                {
                    throw new Exception("Giriş Tarihini Kontrol Ediniz.!");
                    
                }
                if (dtpCikisTarihi.Value.Date > dtpGirisTarihi.Value.Date)
                {
                    rezervasyon.CikisTarihi = dtpCikisTarihi.Value;
                }
                else
                {
                    throw new Exception("Çıkış Tarihini Kontrol Ediniz.!");
                    
                }
                rezervasyon.KayitliUyeID = kayitliUyeID;
                rezervasyon.KisiSayisi = (int)nudKisiSayisi.Value;
                rezervasyon.OdaID = (int)cmbOdaNo.SelectedValue;
                rezervasyon.RezervasyonTipiID = (int)cmbRezervasyonTipi.SelectedValue;
                rezervasyon.OdaSayisi = (int)nudOdaSayisi.Value;
                rezervasyon.YatakSayisi = Convert.ToInt32(lblYatakSayisi.Text);
                rezervasyon.Fiyat = toplamTutar;
                



                    for (int i = 0; i < nudKisiSayisi.Value; i++)
                {
                        musteri = new Musteri();
                    var adGetir = gBoxMusteri.Controls.OfType<TextBox>().Where(x => x.Name.StartsWith("textbox1_")).Select(x => x.Text).ToList();

                    foreach (var txtAd in adGetir)
                    {
                        AdList.Add(txtAd);
                        musteri.Ad = AdList[i];
                    }
                    var soyadGetir = gBoxMusteri.Controls.OfType<TextBox>().Where(x => x.Name.StartsWith("textbox2_")).Select(x => x.Text).ToList();

                    foreach (var txtSoyad in soyadGetir)
                    {
                        SoyadList.Add(txtSoyad);
                        musteri.Soyad = SoyadList[i];
                    }
                    var tcGetir = gBoxMusteri.Controls.OfType<TextBox>().Where(x => x.Name.StartsWith("textbox3_")).Select(x => x.Text).ToList();

                    foreach (var txtTC in tcGetir)
                    {
                        TcList.Add(txtTC);
                        musteri.TcNO = TcList[i];
                    }
                        musteri.OdaId = (int)cmbOdaNo.SelectedValue;
                       
                        MusterilerList.Add(musteri);
                }
                    

                    if (OdaController.OdaDurum((int)cmbOdaNo.SelectedValue) == false)
                {
                      OdaController.OdaDurumGuncelle((int)cmbOdaNo.SelectedValue);
                }
                else
                {
                      throw new Exception("Seçtiğiniz Oda Doludur.Lütfen Başka Oda Seçiniz.!");
                }
                   
                }
            catch (Exception ex)
            {
                    AdList.Clear();
                    SoyadList.Clear();
                    TcList.Clear();
                    MusterilerList.Clear();
                MessageBox.Show(ex.Message);
                    break;
            }
                foreach (var item in MusterilerList)
                {
                    MusteriController.MusteriEkle(item);
                }
               
                RezervasyonController.RezervasyonEkle(rezervasyon);

                MessageBox.Show("Rezervasyonunuz Kaydedilmiştir.");
                btnRezervasyonYap.Enabled = false;
                break;

            } while (true);

           
        } 

        List<string> AdList = new List<string>();
        List<string> SoyadList = new List<string>();
        List<string> TcList = new List<string>();
        List<Musteri> MusterilerList = new List<Musteri>();

        private decimal FiyatHesapla()
        {
            //DateTime girisTarihi = new DateTime(rezervasyon.GirisTarihi.Year, rezervasyon.GirisTarihi.Month, rezervasyon.GirisTarihi.Day);
            DateTime girisTarihi = dtpGirisTarihi.Value.Date;
            DateTime cikisTarihi = dtpCikisTarihi.Value.Date;
            //DateTime cikisTarihi = new DateTime(rezervasyon.CikisTarihi.Year, rezervasyon.CikisTarihi.Month, rezervasyon.CikisTarihi.Day);

            
            kisiSayisiUcFiyat = ((sabitFiyat * kisiSayisiUcFiyatOran) / 100);
            tekKisilikOdaFiyat = ((sabitFiyat * tekKisilikOdaFiyatOran) / 100);
            fullArtıFullOdaFiyat = ((sabitFiyat * fullArtıFullOdaOran) / 100);
            fullOdaFiyat = ((sabitFiyat * fullOdaOran) / 100);
            haftaSonuFiyat = ((sabitFiyat * haftaSonuFiyatOran) / 100) + sabitFiyat;
            
            do
            {
                #region Hesaplama
                if (nudKisiSayisi.Value == 2 && (int)cmbRezervasyonTipi.SelectedValue == standart && nudOdaSayisi.Value == 1 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = haftaSonuFiyat;
                }

                else if (nudKisiSayisi.Value == 2 && (int)cmbRezervasyonTipi.SelectedValue == full && nudOdaSayisi.Value == 1 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = haftaSonuFiyat + fullOdaFiyat;
                }
                else if (nudKisiSayisi.Value == 2 && (int)cmbRezervasyonTipi.SelectedValue == fullartifull && nudOdaSayisi.Value == 1 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = haftaSonuFiyat + fullArtıFullOdaFiyat;
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == standart && nudOdaSayisi.Value == 1 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = kisiSayisiUcFiyat + haftaSonuFiyat;
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == full && nudOdaSayisi.Value == 1 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = kisiSayisiUcFiyat + fullOdaFiyat + haftaSonuFiyat;
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == fullartifull && nudOdaSayisi.Value == 1 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = kisiSayisiUcFiyat + fullArtıFullOdaFiyat + haftaSonuFiyat;
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == standart && nudOdaSayisi.Value == 2 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = haftaSonuFiyat + (haftaSonuFiyat  - tekKisilikOdaFiyat);
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == full && nudOdaSayisi.Value == 2 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = fullOdaFiyat + haftaSonuFiyat + ( (haftaSonuFiyat + fullOdaFiyat) - tekKisilikOdaFiyat);
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == fullartifull && nudOdaSayisi.Value == 2 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = fullArtıFullOdaFiyat + haftaSonuFiyat + (( haftaSonuFiyat + fullArtıFullOdaFiyat)-tekKisilikOdaFiyat);
                }
                else if (nudKisiSayisi.Value == 1 && (int)cmbRezervasyonTipi.SelectedValue == standart && nudOdaSayisi.Value == 1 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = haftaSonuFiyat - tekKisilikOdaFiyat;
                }
                else if (nudKisiSayisi.Value == 1 && (int)cmbRezervasyonTipi.SelectedValue == full && nudOdaSayisi.Value == 1 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat =  (fullOdaFiyat + haftaSonuFiyat) - tekKisilikOdaFiyat;
                }
                else if (nudKisiSayisi.Value == 1 && (int)cmbRezervasyonTipi.SelectedValue == fullartifull && nudOdaSayisi.Value == 1 && (girisTarihi.DayOfWeek == DayOfWeek.Friday || girisTarihi.DayOfWeek == DayOfWeek.Saturday))
                {

                    fiyat = (fullArtıFullOdaFiyat + haftaSonuFiyat) - tekKisilikOdaFiyat  ;
                }
                else if (nudKisiSayisi.Value == 2 && (int)cmbRezervasyonTipi.SelectedValue == standart && nudOdaSayisi.Value == 1)
                {

                    fiyat = sabitFiyat;
                }

                else if (nudKisiSayisi.Value == 2 && (int)cmbRezervasyonTipi.SelectedValue == full && nudOdaSayisi.Value == 1)
                {

                    fiyat = sabitFiyat + fullOdaFiyat;
                }
                else if (nudKisiSayisi.Value == 2 && (int)cmbRezervasyonTipi.SelectedValue == fullartifull && nudOdaSayisi.Value == 1)
                {

                    fiyat = sabitFiyat + fullArtıFullOdaFiyat;
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == standart && nudOdaSayisi.Value == 1)
                {

                    fiyat = kisiSayisiUcFiyat + sabitFiyat;
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == full && nudOdaSayisi.Value == 1)
                {

                    fiyat = kisiSayisiUcFiyat + fullOdaFiyat + sabitFiyat;
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == fullartifull && nudOdaSayisi.Value == 1)
                {

                    fiyat = kisiSayisiUcFiyat + fullArtıFullOdaFiyat + sabitFiyat;
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == standart && nudOdaSayisi.Value == 2)
                {

                    fiyat = (sabitFiyat + (sabitFiyat-tekKisilikOdaFiyat));
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == full && nudOdaSayisi.Value == 2)
                {

                    fiyat = fullOdaFiyat + sabitFiyat + ( (sabitFiyat + fullOdaFiyat)- tekKisilikOdaFiyat);
                }
                else if (nudKisiSayisi.Value == 3 && (int)cmbRezervasyonTipi.SelectedValue == fullartifull && nudOdaSayisi.Value == 2)
                {

                    fiyat = fullArtıFullOdaFiyat + sabitFiyat + ((sabitFiyat + fullArtıFullOdaFiyat)- tekKisilikOdaFiyat);
                }
                else if (nudKisiSayisi.Value == 1 && (int)cmbRezervasyonTipi.SelectedValue == standart && nudOdaSayisi.Value == 1)
                {

                    fiyat = sabitFiyat- tekKisilikOdaFiyat;
                }
                else if (nudKisiSayisi.Value == 1 && (int)cmbRezervasyonTipi.SelectedValue == full && nudOdaSayisi.Value == 1)
                {

                    fiyat =  (fullOdaFiyat + sabitFiyat)-tekKisilikOdaFiyat;
                }
                else if (nudKisiSayisi.Value == 1 && (int)cmbRezervasyonTipi.SelectedValue == fullartifull && nudOdaSayisi.Value == 1)
                {

                    fiyat =  (fullArtıFullOdaFiyat + sabitFiyat)- tekKisilikOdaFiyat;
                }
                #endregion
                else
                {
                        toplamTutar = 0;
                        fiyat = 0;
                        throw new Exception("Lütfen Girdiğiniz Değerleri Kontrol Ediniz.!");
                }
               
                toplamTutar += fiyat;
                girisTarihi = girisTarihi.AddDays(1);
            } while (girisTarihi <= cikisTarihi);

           

            lblFiyat.Text = toplamTutar.ToString();

            return toplamTutar;
        }

        private void nudKisiSayisi_ValueChanged(object sender, EventArgs e)
        {
            lblYatakSayisi.Text = nudKisiSayisi.Value.ToString();

            int y = 20;
            if (nudKisiSayisi.Value >= c)
            {
                c++;
                TextBox textBox1 = new TextBox();
                textBox1.Location = new Point(52,(y*c)*2);
                textBox1.Size = new Size(100, 25);
                textBox1.Name = "textbox1_" + c.ToString();

                TextBox textBox2 = new TextBox();
                textBox2.Location = new Point(214, (y * c) * 2);
                textBox2.Size = new Size(100, 25);
                textBox2.Name = "textbox2_" + c.ToString() ;

                TextBox textBox3 = new TextBox();
                textBox3.Location = new Point(362, (y * c) * 2);
                textBox3.Size = new Size(100, 25);
                textBox3.Name = "textbox3_" + c.ToString();
                textBox3.MaxLength = 11;

                gBoxMusteri.Controls.Add(textBox1);
                gBoxMusteri.Controls.Add(textBox2);
                gBoxMusteri.Controls.Add(textBox3);
            }
            else
            {
                gBoxMusteri.Controls.RemoveByKey("textbox1_" + c.ToString());
                gBoxMusteri.Controls.RemoveByKey("textbox2_" + c.ToString());
                gBoxMusteri.Controls.RemoveByKey("textbox3_" + c.ToString());
                c--;
            }

            if (nudKisiSayisi.Value > 3 )
            {
                nudOdaSayisi.Minimum = 2;
                nudOdaSayisi.Value = 2;
                nudOdaSayisi.Maximum = 6;

            }
            if (nudKisiSayisi.Value <= 3)
            {
                nudOdaSayisi.Minimum = 1;
                nudOdaSayisi.Value = 1;
            }
        }

        private void nudOdaSayisi_ValueChanged(object sender, EventArgs e)
        {
            if (nudOdaSayisi.Value > 0 && nudOdaSayisi.Value <= 1)
            {
                nudKisiSayisi.Minimum = 0;
                nudKisiSayisi.Maximum = 3;
            }
            else if (nudOdaSayisi.Value > 1 && nudOdaSayisi.Value <= 2)
            {
                nudKisiSayisi.Minimum = 0;
                nudKisiSayisi.Maximum = 6;
            }
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            MusteriEkran.Visible = true;
            MusteriEkran.Show();
            MusteriEkran.BringToFront();
            this.Close();
        }
    }
    enum RezervasyonTipi
    {
        Standart = 1,
        Full = 2,
        FullArtıFull = 3
    }
}
