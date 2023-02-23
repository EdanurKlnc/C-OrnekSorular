//ödev2
//programa dışarıdan 1-6 arası bir sayı girilecek ve program her seferinde 2 zar atacak.
//Atılan zar çiftleri eğer girdiğimiz sayıya eşit olursa program bitecek ve kaç denemede bulduğunu ekrana yazacak.
//(önceki denemeleri de ekrana yazdırabilirsiniz)

 while (true)
{
    Console.WriteLine("Bir sayı giriniz");
    int sayi = Convert.ToInt32(Console.ReadLine());

    if (sayi > 0 && sayi < 7)
    {
        Console.WriteLine(sayi);
        int zar1, zar2;
        Random rnd = new Random();
        zar1 = rnd.Next(1, 7);
        zar2 = rnd.Next(1, 7);
        Console.WriteLine(zar1 + " " + zar2);

        if (sayi == zar1 && sayi == zar2)
        {
            Console.WriteLine("Tebrikler, oyunu kazandınız");
            break;
        }
        else
        {
            Console.WriteLine("Tekrar deneyiniz");
        }
    }
    else
    {
        Console.WriteLine("Lütfen 1 ile 6 arası bir sayi giriniz!!");
    }
    break;
}