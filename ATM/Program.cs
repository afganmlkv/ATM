int AZN200 = 0;
int AZN100 = 0;
int AZN50 = 0;
int AZN20 = 0;
int AZN10 = 0;
int AZN5 = 0;
int AZN1 = 0;
int mebleg = 0;

//medaxil();
int eskinasSayi = AZN200 + AZN100 + AZN50 + AZN20 + AZN10 + AZN5 + AZN1;
int eskinasDeyeri = AZN200 * 200 + AZN100 * 100 + AZN50 * 50 + AZN20 * 20 + AZN10 * 10 + AZN5 * 5 + AZN1 * 1;
mexaricSorgu();

void medaxil()
{
    Console.Write("200 AZN eskinaslari daxil edin: ");
    AZN200 = int.Parse(Console.ReadLine());
    Console.Write("100 AZN eskinaslari daxil edin: ");
    AZN100 = int.Parse(Console.ReadLine());
    Console.Write("50 AZN eskinaslari daxil edin: ");
    AZN50 = int.Parse(Console.ReadLine());
    Console.Write("20 AZN eskinaslari daxil edin: ");
    AZN20 = int.Parse(Console.ReadLine());
    Console.Write("10 AZN eskinaslari daxil edin: ");
    AZN10 = int.Parse(Console.ReadLine());
    Console.Write("5 AZN eskinaslari daxil edin: ");
    AZN5 = int.Parse(Console.ReadLine());
    Console.Write("1 AZN eskinaslari daxil edin: ");
    AZN1 = int.Parse(Console.ReadLine());
}

void eskinaslar()
{
    Console.WriteLine("ATM de olan eskinaslar");
    Console.WriteLine($"200 AZN eskinas {AZN200} eded.");
    Console.WriteLine($"100 AZN eskinas {AZN100} eded.");
    Console.WriteLine($"50 AZN eskinas {AZN50} eded.");
    Console.WriteLine($"20 AZN eskinas {AZN20} eded.");
    Console.WriteLine($"10 AZN eskinas {AZN10} eded.");
    Console.WriteLine($"5 AZN eskinas {AZN5} eded.");
    Console.WriteLine($"1 AZN eskinas {AZN1} eded.");
    Console.WriteLine($"ATM-de olan eskinas sayi: {eskinasSayi}");
    Console.WriteLine($"ATM-de olan eskinas deyeri: {eskinasDeyeri}");
}

void mexaricSorgu()
{
    Console.Write("Elde etmek istediyiniz meblegi daxil edin: ");
    mebleg = int.Parse(Console.ReadLine());
    while (mebleg > 500)
    {
        Console.Write("Mebleg 500 AZN den cox ola bilmez: ");
        mebleg = int.Parse(Console.ReadLine());
    }
}
