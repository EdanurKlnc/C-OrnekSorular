
string[] kelimeler = { "istanbul", "yazılım", "okul", "üniversite", "karnıbahar", "eldiven" };
Random rnd = new Random();
string rndSecilenKelime;
rndSecilenKelime = kelimeler[rnd.Next(0, kelimeler.Length - 1)];
char[] harfYeri = new char[rndSecilenKelime.Length];
int puan = (rndSecilenKelime.Length) * 100;
int hak = 6;
int evOlusturma = 6;



for (int i = 0; i < harfYeri.Length; i++)
{
    harfYeri[i] = '-';
    Console.Write('-');
}
Console.WriteLine();

while (true)
{

    Console.WriteLine("Kalan Hak:{0}", hak);
    Console.WriteLine("Puan :{0}", puan);
    Console.Write("Harf Giriniz : ");
    char harf = Convert.ToChar(Console.ReadLine());


    //  Console.Write("Kelime Tahmininde  Bulunmak ister misiniz?: ");
    //  bool kelimeTahminindeBulunmakİsteme = true;

    bool girilenHarf = false;
    int kalanKelime = 0;
    for (int i = 0; i < rndSecilenKelime.Length; i++)
    {
        if (rndSecilenKelime[i] == harf)
        {
            harfYeri[i] = harf;
            girilenHarf = true;
        }
        if (harfYeri[i] == '-')
        {
            kalanKelime++;
        }
        Console.Write(harfYeri[i]);
        /*  if (kelimeTahminindeBulunmakİsteme == true)
         {

                 Console.Write("Kelime Tahmininde  Bulunuz: ");
                 string kelimeTahmini = Console.ReadLine();

                 if (rndSecilenKelime == kelimeTahmini)
             {
                 Console.WriteLine("Tebrikler kelimeyi doğru tahmin ettiniz :)");
                 break;
             }
             else
             {
                 Console.WriteLine("Üzgünüm kelimeyi bilemediniz");
                 hak--;
                 puan = puan - (puan / 100) * 10;
             }
         }
         
       */
    }

    Console.WriteLine();

    if (kalanKelime == 0)
    {
        Console.WriteLine("Tebrikler, doğru bildiniz");
        break;
    }

    if (girilenHarf == false)
    {
        Console.WriteLine("Yanlış harf girdiniz!!");
        hak--;
        puan = puan - (puan / 100) * 10;

        if (puan == 0)
        {
            Console.WriteLine("Üzgünüz, puanınız bitti.Kaybettiniz!!");
            break;
        }
        if (hak == 0)
        {
            Console.WriteLine("Üzgünüz, hakkınız bitti.Kaybettiniz!!");
            break;
        }

    }

   
} Console.Write("Seçilen kelime : {0}", rndSecilenKelime);
    Console.ReadLine();