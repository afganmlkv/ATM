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
mexaric();

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

void mexaric()
{
    int mexaric200 = mebleg / 200;
    int qaliq200 = mebleg % 200;
    
    int mexaric100 = qaliq200 / 100;
    int qaliq100 = qaliq200 % 100;
    
    int mexaric50 = qaliq100 / 50;
    int qaliq50 = qaliq100 % 50;

    int mexaric20 = qaliq50 / 20;
    int qaliq20 = qaliq50 % 20;

    int mexaric10 = qaliq20 / 10;
    int qaliq10 = qaliq20 % 10;

    int mexaric5 = qaliq10 / 5;
    
    int mexaric1 = qaliq10 % 5;

    Console.WriteLine($"Verilen eskinaslar:" +
        $"\n{mexaric200} eded 200AZN " +
        $"\n{mexaric100} eded 100AZN " +
        $"\n{mexaric50} eded 50AZN " +
        $"\n{mexaric20} eded 20 AZN " +
        $"\n{mexaric10} eded 10 AZN " +
        $"\n{mexaric5} eded 5 AZN " +
        $"\n{mexaric1} eded 1 AZN");
}