
int içiboşkareoluşturma = 6;
for (int i = 0; i < içiboşkareoluşturma; i++)
{
    Console.Write("# ");
}
Console.WriteLine();
// sol kenarı oluşturma
for (int j = 0; j < içiboşkareoluşturma - 2; j++)
{
    Console.Write("#");
    // aradaki boşluk satırı ekleme
    for (int k = 0; k < içiboşkareoluşturma - 2; k++)
    {
        Console.Write("  ");
    }
    // sağ kenarı oluşturma
    Console.Write(" #");
    Console.WriteLine();
}
//alt kenarı oluşturma
for (int n = 0; n < içiboşkareoluşturma; n++)
    Console.Write("# ");
Console.Read();