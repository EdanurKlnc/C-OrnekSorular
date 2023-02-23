// ödev1
// Program her uğraşında 0-100 arasında rastgele bir sayı bulacak
// ve bizden o sayıyı tahmin etmesini isteyecek.
// Her tahminden sonra yukarı/aşağı diye bizi yönlendirecek.
// Tahminimiz doğru olduğunda kaç tahminde bulunduğumuz ekranı yazdıracak.
// Tüm girişler yanlış olsa dahi tahmin olarak değerlendirilecek.

using System.ComponentModel;

Random rnd = new Random();
int rndSayi = rnd.Next(0, 101);
Console.WriteLine(rndSayi);


while (true)
{
    int sayac = 0;
    Console.Write("Bir sayi giriniz: ");
    int kullaniciTahmini = Convert.ToInt32(Console.ReadLine());
    //Console.WriteLine("Girilen sayi : " + kullaniciTahmini);

    if (kullaniciTahmini == rndSayi)
    {
        Console.WriteLine("Tebrikler Bildiniz, tahmin sayınız:" + sayac);

        break;

    }
    else
    {
        if (kullaniciTahmini > rndSayi)
        {
            Console.WriteLine("Yanlış Bildiniz,Daha küçük bir sayı giriniz");
            sayac++;

        }
        else
        {
            Console.WriteLine("Yanlış Bildiniz,Daha büyük bir sayı giriniz");
            sayac++;

        }

    }


}
Console.WriteLine("Oyun bitti");


