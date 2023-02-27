namespace SayiyiYaziyaCevirmeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCevir_Click(object sender, EventArgs e)
        {
            try
            {
                string[] birler = { "", "Bir", "Ýki", "Üç", "Dört", "Beþ", "Altý", "Yedi", "Sekiz", "Dokuz" };
                string[] onlar = { "", "On", "Yirmi", "Otuz", "Kýrk", "Elli", "Altmýþ", "Yetmiþ", "Seksen", "Doksan" };
                string[] yuzler = { "", "Yüz", "ÝkiYüz", "ÜçYüz", "DörtYüz", "BeþYüz", "AltýYüz", "YediYüz", "SekizYüz", "DokuzYüz" };
                string[] binler = { "", "Bin", "ÝkiBin", "ÜçBin", "DörtBin", "BeþBin", "AltýBin", "YediBin", "SekizBin", "DokuzBin" };
                string[] milyonlar = { "", "BirMilyon", "ÝkiMilyon", "ÜçMilyon", "DörtMilyon", "BeþMilyon", "AltýMilyon", "YediMilyon", "SekizMilyon", "DokuzMilyon" };
                int girilenSayi = SayiGirdirici(0, 9999999, "0-9999999 arasý bir sayý giriniz");

                int basamak1 = girilenSayi % 10;
                int basamak10 = girilenSayi / 10 % 10;
                int basamak100 = girilenSayi / 100 % 10;
                int basamak1000 = girilenSayi / 1000 % 10;
                int basamak10000 = girilenSayi / 10000 % 10;
                int basamak100000 = girilenSayi / 100000 % 10;
                int basamak1000000 = girilenSayi / 1000000 % 10;
                string okunus = $"{milyonlar[basamak1000000]}{yuzler[basamak100000]}{onlar[basamak10000]}{binler[basamak1000]}{yuzler[basamak100]}{onlar[basamak10]}{birler[basamak1]}";

                int SayiGirdirici(int baslangic, int bitis, string mesaj, string hataMesaji = "Yanlýþ bir giriþ yaptýnýz")
                {
                    do
                    {
                        try
                        {
                            Console.WriteLine(mesaj);
                            int girilenSayi = int.Parse(Console.ReadLine());
                            if (girilenSayi < baslangic || girilenSayi > bitis)
                                throw new Exception();
                            return girilenSayi;
                        }
                        catch (Exception ex)
                        {
                            //MessageBox.Show($"Bir Hata Oluþtu! {ex.Message}");
                        }
                    } while (true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Oluþtu! {ex.Message}");
            }

        }
    }
}