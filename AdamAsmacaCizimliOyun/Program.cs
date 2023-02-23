using AdamAsmacaCizimliOyun.Helpers;
ConsoleKey key;
do
{
    GameHelper game = new GameHelper();
    Random rnd = new Random();
    Console.Clear();
    do
    {
        Console.WriteLine(game.EkraniYaz());
        var sonuc = game.TahminYap(Console.ReadLine()); //Hata olduğunda kullanıcıya ses cıkarır.
        if (!sonuc) Console.Beep(5100, 300);
    } while (game.OyunAktifMi());
    if (game.HakKontrol() > 0)
    {
        Console.WriteLine(game.SeciliSoru);
        Console.WriteLine("Tebrikler bildiniz");
        Console.WriteLine($"Puanınız : { game.PuanKontrol()}");
    }
    Console.WriteLine("Tekrar oynamak için E tuşuna basınız: ");

    key = Console.ReadKey().Key;
} while (key == ConsoleKey.E);