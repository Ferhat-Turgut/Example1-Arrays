int[] numbers = new int[10];
int enterNumber = 0;
int lengthFlag = 0;

while (lengthFlag < 10)
{
    Console.Write($"0 ile 100 arası {lengthFlag + 1}. sayıyı giriniz=");
    enterNumber = int.Parse(Console.ReadLine());

    if (enterNumber > 0 && enterNumber < 100)
    {
        numbers[lengthFlag] = enterNumber;
        lengthFlag++;
    }
    else
    {
        Console.WriteLine("Hatalı veri girdiniz.Lütfen kontrol ediniz!");
    }
}

Console.WriteLine($"En küçük değer={numbers.Min()}");
Console.WriteLine($"En büyük değer={numbers.Max()}");
Console.WriteLine($"Değerlerin Toplamı={numbers.Sum()}");
Console.WriteLine($"Değerlerin Ortalaması={numbers.Average()}");