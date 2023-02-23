
namespace AdamAsmacaCizimliOyun.Helpers;

public class Grafik
{
    public Grafik()
    {
        for (int i = 0; i < dotMatris.GetLength(0); i++)
        {
            for (int j = 0; j < dotMatris.GetLength(1); j++)
            {
                dotMatris[i, j] = ' ';
            }
        }
    }
    private char[,] dotMatris = new char[35, 45];

    public void KafaCiz(int x = 10, int y = 10)
    {
        int sayac1 = 0;
        for (int i = 10; i >= -10; i -= 2)
        {
            int sayac2 = 20;
            for (int j = -10; j <= 10; j++)
            {
                int hesap = (int)Math.Sqrt(Math.Pow(i, 2) + Math.Pow(j, 2));
                if (hesap == 10)
                {
                    dotMatris[sayac1, sayac2] = '.';
                }

                sayac2++;
            }
            sayac1++;
        }
    }

    //Gövde çizimi
    public void GovdeCizimi()
    {
        for (int i = 0; i < 15; i++)
        {
            dotMatris[10 + i, 30] = '.';
        }
    }

    public void Uzuvlar(Uzuvlar uzuv)
    {
        //sağ kol
        if (uzuv == Helpers.Uzuvlar.SagKol)   //Uzuvlar classından cekiyoruz
            for (int i = 0; i < 10; i++)
            {
                dotMatris[10 + i, 30 + i] = '.';
            }
        //sol kol
        else if (uzuv == Helpers.Uzuvlar.SolKol)
            for (int i = 0; i < 10; i++)
            {
                dotMatris[10 + i, 30 - i] = '.';
            }
        //sağ bacak
        else if (uzuv == Helpers.Uzuvlar.SagBacak)

            for (int i = 0; i < 10; i++)
            {
                dotMatris[25 + i, 30 + i] = '.';
            }
        //sol bacak
        else if (uzuv == Helpers.Uzuvlar.SolBacak)

            for (int i = 0; i < 10; i++)
            {
                dotMatris[25 + i, 30 - i] = '.';
            }
    }

    //Ekrana Yaz
    public void EkranaYaz(bool isClear = true)
    {
        if (isClear) Console.Clear();
        for (int i = 0; i < dotMatris.GetLength(0); i++)
        {
            for (int j = 0; j < dotMatris.GetLength(1); j++)
            {
                Console.Write(dotMatris[i, j]);
            }
            Console.WriteLine();
        }
    }
}

