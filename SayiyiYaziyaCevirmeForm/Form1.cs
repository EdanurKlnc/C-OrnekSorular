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
                string[] birler = { "", "Bir", "�ki", "��", "D�rt", "Be�", "Alt�", "Yedi", "Sekiz", "Dokuz" };
                string[] onlar = { "", "On", "Yirmi", "Otuz", "K�rk", "Elli", "Altm��", "Yetmi�", "Seksen", "Doksan" };
                string[] yuzler = { "", "Y�z", "�kiY�z", "��Y�z", "D�rtY�z", "Be�Y�z", "Alt�Y�z", "YediY�z", "SekizY�z", "DokuzY�z" };
                string[] binler = { "", "Bin", "�kiBin", "��Bin", "D�rtBin", "Be�Bin", "Alt�Bin", "YediBin", "SekizBin", "DokuzBin" };
                string[] milyonlar = { "", "BirMilyon", "�kiMilyon", "��Milyon", "D�rtMilyon", "Be�Milyon", "Alt�Milyon", "YediMilyon", "SekizMilyon", "DokuzMilyon" };
                int girilenSayi = SayiGirdirici(0, 9999999, "0-9999999 aras� bir say� giriniz");

                int basamak1 = girilenSayi % 10;
                int basamak10 = girilenSayi / 10 % 10;
                int basamak100 = girilenSayi / 100 % 10;
                int basamak1000 = girilenSayi / 1000 % 10;
                int basamak10000 = girilenSayi / 10000 % 10;
                int basamak100000 = girilenSayi / 100000 % 10;
                int basamak1000000 = girilenSayi / 1000000 % 10;
                string okunus = $"{milyonlar[basamak1000000]}{yuzler[basamak100000]}{onlar[basamak10000]}{binler[basamak1000]}{yuzler[basamak100]}{onlar[basamak10]}{birler[basamak1]}";

                int SayiGirdirici(int baslangic, int bitis, string mesaj, string hataMesaji = "Yanl�� bir giri� yapt�n�z")
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
                            //MessageBox.Show($"Bir Hata Olu�tu! {ex.Message}");
                        }
                    } while (true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir Hata Olu�tu! {ex.Message}");
            }

        }
    }
}