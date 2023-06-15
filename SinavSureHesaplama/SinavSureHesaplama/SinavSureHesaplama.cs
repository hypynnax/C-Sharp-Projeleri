using System;
using System.Drawing;
using System.Windows.Forms;

namespace SinavSureHesaplama {
    public partial class sinavSuresiHesaplama : Form {
        private PictureBox[] saatBirlikler, saatOnluklar, dakkaBirlikler, dakkaOnluklar, saniyeBirlikler, saniyeOnluklar;
        private int sinavBitisSaati, kalanSure, kalanSoruSayisi;
        private bool sinavSonu, mode;

        public sinavSuresiHesaplama() {
            InitializeComponent();
            saatBirlikler = new[] { saatBirlikA, saatBirlikB, saatBirlikC, saatBirlikD, saatBirlikE, saatBirlikF, saatBirlikG };
            saatOnluklar = new[] { saatOnlukA, saatOnlukB, saatOnlukC, saatOnlukD, saatOnlukE, saatOnlukF, saatOnlukG };
            dakkaBirlikler = new[] { dakkaBirlikA, dakkaBirlikB, dakkaBirlikC, dakkaBirlikD, dakkaBirlikE, dakkaBirlikF, dakkaBirlikG };
            dakkaOnluklar = new[] { dakkaOnlukA, dakkaOnlukB, dakkaOnlukC, dakkaOnlukD, dakkaOnlukE, dakkaOnlukF, dakkaOnlukG };
            saniyeBirlikler = new[] { saniyeBirlikA, saniyeBirlikB, saniyeBirlikC, saniyeBirlikD, saniyeBirlikE, saniyeBirlikF, saniyeBirlikG };
            saniyeOnluklar = new[] { saniyeOnlukA, saniyeOnlukB, saniyeOnlukC, saniyeOnlukD, saniyeOnlukE, saniyeOnlukF, saniyeOnlukG };
            mode = true;
        }

        private void soruSayisi_TextChanged(object sender, EventArgs e) {
            if (soruSayisi.Text != "") {
                if (!char.IsDigit(soruSayisi.Text[soruSayisi.Text.Length - 1]) || soruSayisi.Text.Length >= 4) {
                    soruSayisi.Text = soruSayisi.Text.Substring(0, soruSayisi.Text.Length - 1);
                    soruSayisi.Select(soruSayisi.Text.Length, 0);
                }
            }
        }

        private void sinavSuresi_TextChanged(object sender, EventArgs e) {
            if (sinavSuresi.Text != "") {
                if (!char.IsDigit(sinavSuresi.Text[sinavSuresi.Text.Length - 1]) || sinavSuresi.Text.Length >= 4) {
                    sinavSuresi.Text = sinavSuresi.Text.Substring(0, sinavSuresi.Text.Length - 1);
                    sinavSuresi.Select(sinavSuresi.Text.Length, 0);
                }
            }
        }

        private void baslatButonu_Click(object sender, EventArgs e) {
            if (soruSayisi.Text != "" && sinavSuresi.Text != "") {
                sinavBitisSaati = DateTime.Now.Second + Convert.ToInt32(sinavSuresi.Text) * 60;
                kalanSure = Convert.ToInt32(sinavSuresi.Text) * 60;
                kalanSoruSayisi = Convert.ToInt16(soruSayisi.Text);
                cevir(kalanSure, kalanSoruSayisi);
                cozulenSoruSayisi.Enabled = true;
                baslatButonu.Enabled = false;
                sinavSonu = false;
            }
        }

        private void bitirButonu_Click(object sender, EventArgs e) {
            if (baslatButonu.Enabled == false) {
                soruSayisi.Text = "";
                sinavSuresi.Text = "";
                sinavSonu = true;
                baslatButonu.Enabled = true;
                cozulenSoruSayisi.Value = 0;
                cozulenSoruSayisi.Enabled = false;
                ekranaYazdir("00", "00", "00");
            }
        }

        private void gunduzGeceModu_Click(object sender, EventArgs e) {
            if (mode) {
                mode = false;
                gunduzGeceModu.Image = Properties.Resources.dark_mode;
                ActiveForm.BackColor = Color.Black;
                soruSayisiLabel.BackColor = Color.Black;
                soruSayisiLabel.ForeColor = Color.White;
                soruSayisi.BackColor = Color.Black;
                soruSayisi.ForeColor = Color.White;
                sinavSuresiLabel.BackColor = Color.Black;
                sinavSuresiLabel.ForeColor = Color.White;
                sinavSuresi.BackColor = Color.Black;
                sinavSuresi.ForeColor = Color.White;
                dkLabel.BackColor = Color.Black;
                dkLabel.ForeColor = Color.White;
                baslatButonu.BackColor = Color.Black;
                baslatButonu.ForeColor = Color.White;
                baslatButonu.FlatAppearance.BorderColor = Color.White;
                baslatButonu.FlatAppearance.MouseDownBackColor = Color.Black;
                baslatButonu.FlatAppearance.MouseOverBackColor = Color.Gold;
                bitirButonu.BackColor = Color.Black;
                bitirButonu.ForeColor = Color.White;
                bitirButonu.FlatAppearance.BorderColor = Color.White;
                bitirButonu.FlatAppearance.MouseDownBackColor = Color.Black;
                bitirButonu.FlatAppearance.MouseOverBackColor = Color.Gold;
                label.BackColor = Color.Black;
                label.ForeColor = Color.White;
                label1.BackColor = Color.Black;
                label1.ForeColor = Color.White;
                cozulenSoruSayisi.BackColor = Color.Black;
                cozulenSoruSayisi.ForeColor = Color.White;
                saatBirlikA.BackColor = Color.White;
                saatBirlikB.BackColor = Color.White;
                saatBirlikC.BackColor = Color.White;
                saatBirlikD.BackColor = Color.White;
                saatBirlikE.BackColor = Color.White;
                saatBirlikF.BackColor = Color.White;
                saatBirlikG.BackColor = Color.White;
                saatOnlukA.BackColor = Color.White;
                saatOnlukB.BackColor = Color.White;
                saatOnlukC.BackColor = Color.White;
                saatOnlukD.BackColor = Color.White;
                saatOnlukE.BackColor = Color.White;
                saatOnlukF.BackColor = Color.White;
                saatOnlukG.BackColor = Color.White;
                ayrac1.BackColor = Color.White;
                ayrac2.BackColor = Color.White;
                dakkaBirlikA.BackColor = Color.White;
                dakkaBirlikB.BackColor = Color.White;
                dakkaBirlikC.BackColor = Color.White;
                dakkaBirlikD.BackColor = Color.White;
                dakkaBirlikE.BackColor = Color.White;
                dakkaBirlikF.BackColor = Color.White;
                dakkaBirlikG.BackColor = Color.White;
                dakkaOnlukA.BackColor = Color.White;
                dakkaOnlukB.BackColor = Color.White;
                dakkaOnlukC.BackColor = Color.White;
                dakkaOnlukD.BackColor = Color.White;
                dakkaOnlukE.BackColor = Color.White;
                dakkaOnlukF.BackColor = Color.White;
                dakkaOnlukG.BackColor = Color.White;
                ayrac3.BackColor = Color.White;
                ayrac4.BackColor = Color.White;
                saniyeBirlikA.BackColor = Color.White;
                saniyeBirlikB.BackColor = Color.White;
                saniyeBirlikC.BackColor = Color.White;
                saniyeBirlikD.BackColor = Color.White;
                saniyeBirlikE.BackColor = Color.White;
                saniyeBirlikF.BackColor = Color.White;
                saniyeBirlikG.BackColor = Color.White;
                saniyeOnlukA.BackColor = Color.White;
                saniyeOnlukB.BackColor = Color.White;
                saniyeOnlukC.BackColor = Color.White;
                saniyeOnlukD.BackColor = Color.White;
                saniyeOnlukE.BackColor = Color.White;
                saniyeOnlukF.BackColor = Color.White;
                saniyeOnlukG.BackColor = Color.White;
            }
            else {
                mode = true;
                gunduzGeceModu.Image = Properties.Resources.day_mode;
                ActiveForm.BackColor = Color.White;
                soruSayisiLabel.BackColor = Color.White;
                soruSayisiLabel.ForeColor = Color.Black;
                soruSayisi.BackColor = Color.White;
                soruSayisi.ForeColor = Color.Black;
                sinavSuresiLabel.BackColor = Color.White;
                sinavSuresiLabel.ForeColor = Color.Black;
                sinavSuresi.BackColor = Color.White;
                sinavSuresi.ForeColor = Color.Black;
                dkLabel.BackColor = Color.White;
                dkLabel.ForeColor = Color.Black;
                baslatButonu.BackColor = Color.White;
                baslatButonu.ForeColor = Color.Black;
                baslatButonu.FlatAppearance.BorderColor = Color.Black;
                baslatButonu.FlatAppearance.MouseDownBackColor = Color.White;
                baslatButonu.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                bitirButonu.BackColor = Color.White;
                bitirButonu.ForeColor = Color.Black;
                bitirButonu.FlatAppearance.BorderColor = Color.Black;
                bitirButonu.FlatAppearance.MouseDownBackColor = Color.White;
                bitirButonu.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
                label.BackColor = Color.White;
                label.ForeColor = Color.Black;
                label1.BackColor = Color.White;
                label1.ForeColor = Color.Black;
                cozulenSoruSayisi.BackColor = Color.White;
                cozulenSoruSayisi.ForeColor = Color.Black;
                saatBirlikA.BackColor = Color.Black;
                saatBirlikB.BackColor = Color.Black;
                saatBirlikC.BackColor = Color.Black;
                saatBirlikD.BackColor = Color.Black;
                saatBirlikE.BackColor = Color.Black;
                saatBirlikF.BackColor = Color.Black;
                saatBirlikG.BackColor = Color.Black;
                saatOnlukA.BackColor = Color.Black;
                saatOnlukB.BackColor = Color.Black;
                saatOnlukC.BackColor = Color.Black;
                saatOnlukD.BackColor = Color.Black;
                saatOnlukE.BackColor = Color.Black;
                saatOnlukF.BackColor = Color.Black;
                saatOnlukG.BackColor = Color.Black;
                ayrac1.BackColor = Color.Black;
                ayrac2.BackColor = Color.Black;
                dakkaBirlikA.BackColor = Color.Black;
                dakkaBirlikB.BackColor = Color.Black;
                dakkaBirlikC.BackColor = Color.Black;
                dakkaBirlikD.BackColor = Color.Black;
                dakkaBirlikE.BackColor = Color.Black;
                dakkaBirlikF.BackColor = Color.Black;
                dakkaBirlikG.BackColor = Color.Black;
                dakkaOnlukA.BackColor = Color.Black;
                dakkaOnlukB.BackColor = Color.Black;
                dakkaOnlukC.BackColor = Color.Black;
                dakkaOnlukD.BackColor = Color.Black;
                dakkaOnlukE.BackColor = Color.Black;
                dakkaOnlukF.BackColor = Color.Black;
                dakkaOnlukG.BackColor = Color.Black;
                ayrac3.BackColor = Color.Black;
                ayrac4.BackColor = Color.Black;
                saniyeBirlikA.BackColor = Color.Black;
                saniyeBirlikB.BackColor = Color.Black;
                saniyeBirlikC.BackColor = Color.Black;
                saniyeBirlikD.BackColor = Color.Black;
                saniyeBirlikE.BackColor = Color.Black;
                saniyeBirlikF.BackColor = Color.Black;
                saniyeBirlikG.BackColor = Color.Black;
                saniyeOnlukA.BackColor = Color.Black;
                saniyeOnlukB.BackColor = Color.Black;
                saniyeOnlukC.BackColor = Color.Black;
                saniyeOnlukD.BackColor = Color.Black;
                saniyeOnlukE.BackColor = Color.Black;
                saniyeOnlukF.BackColor = Color.Black;
                saniyeOnlukG.BackColor = Color.Black;
            }
        }

        private void cozulenSoruSayisi_ValueChanged(object sender, EventArgs e) {
            kalanSoruSayisi--;
            if (kalanSoruSayisi > 0) {
                kalanSure = sinavBitisSaati - DateTime.Now.Second;
                cevir(kalanSure, kalanSoruSayisi);
            }else {
                if (sinavSonu) MessageBox.Show("Sınavınız Bitmiştir. Tebrik Ederim", "Sınav Sonu");
                bitirButonu_Click(new object(),new EventArgs());
            }
        }

        private void cevir(int sure, int soruSayisi) {
            int sonuc = sure / soruSayisi;
            int saat = sonuc / 3600;
            sonuc %= 3600;
            int dakka = sonuc / 60;
            sonuc %= 60;
            int saniye = sonuc;
            ekranaYazdir(saat.ToString(), dakka.ToString(), saniye.ToString());
        }

        private void ekranaYazdir(string saat, string dakka, string saniye) {
            while (saat.Length < 2) {
                saat = "0" + saat;
            }

            while (dakka.Length < 2) {
                dakka = "0" + dakka;
            }

            while (saniye.Length < 2) {
                saniye = "0" + saniye;
            }

            sayiyiOlustur(Convert.ToInt32(saat.Substring(0, 1)), saatOnluklar);
            sayiyiOlustur(Convert.ToInt32(saat.Substring(1, 1)), saatBirlikler);
            sayiyiOlustur(Convert.ToInt32(dakka.Substring(0, 1)), dakkaOnluklar);
            sayiyiOlustur(Convert.ToInt32(dakka.Substring(1, 1)), dakkaBirlikler);
            sayiyiOlustur(Convert.ToInt32(saniye.Substring(0, 1)), saniyeOnluklar);
            sayiyiOlustur(Convert.ToInt32(saniye.Substring(1, 1)), saniyeBirlikler);
        }

        private void sayiyiOlustur(int sayi, PictureBox[] parcalar) {
            foreach (PictureBox parca in parcalar) {
                parca.Visible = true;
            }

            switch (sayi) {
                case 0:
                    parcalar[5].Visible = false;
                    break;
                case 1:
                    parcalar[0].Visible = false;
                    parcalar[2].Visible = false;
                    parcalar[4].Visible = false;
                    parcalar[5].Visible = false;
                    parcalar[6].Visible = false;
                    break;
                case 2:
                    parcalar[0].Visible = false;
                    parcalar[3].Visible = false;
                    break;
                case 3:
                    parcalar[0].Visible = false;
                    parcalar[2].Visible = false;
                    break;
                case 4:
                    parcalar[2].Visible = false;
                    parcalar[4].Visible = false;
                    parcalar[6].Visible = false;
                    break;
                case 5:
                    parcalar[1].Visible = false;
                    parcalar[2].Visible = false;
                    break;
                case 6:
                    parcalar[1].Visible = false;
                    break;
                case 7:
                    parcalar[0].Visible = false;
                    parcalar[2].Visible = false;
                    parcalar[5].Visible = false;
                    parcalar[6].Visible = false;
                    break;
                case 9:
                    parcalar[2].Visible = false;
                    break;
                default:
                    parcalar[0].Visible = true;
                    break;
            }
        }
    }
}
