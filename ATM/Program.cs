Console.WriteLine($"EfqanBank ASC-ye xosh gelmisiniz \nXahish edirik bankomatla emtmek istediyiniz emliyyati sechin");
sechim();


void sechim()
{
    Console.WriteLine("Medaxil etmek uchun 'd' --- mexaric etmek uchun 'x' --- ATM-deki eskinaslar barede melumat almaq ucun 'm'");
}


int[] eskinaslar = new int[7] { 1, 5, 10, 20, 50, 100, 200 };
int[] eskinassayi = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
int[] eskinasMedaxil = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
int[] eskinasMexaric = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
int mebleg = 0;
int eskinasDeyeri = 0;
int eskinasSayiUmumi = 0;

//eskinasDeyeriHesablama();
medaxil();
medaxil();





int eskinasDeyeriHesablama()
{
    int deyer=0;
    for (int i=0; i<eskinassayi.Length; i++)
    {
        int araDeyer = 0;
        araDeyer = eskinassayi[i] * eskinaslar[i];
        deyer += araDeyer;
    }
    return deyer;
}

void update()
{
    eskinasDeyeri = eskinasDeyeriHesablama();
    eskinasSayiUmumi = eskinassayi.Sum();
}

//mexaricSorgu();
//mexaric();

void medaxil()
{
    Console.Write($"{eskinaslar[6]} AZN eskinaslari daxil edin: ");
    eskinassayi[6] += int.Parse(Console.ReadLine());
    Console.Write($"{eskinaslar[5]} AZN eskinaslari daxil edin: ");
    eskinassayi[5] += int.Parse(Console.ReadLine());
    Console.Write($"{eskinaslar[4]} AZN eskinaslari daxil edin: ");
    eskinassayi[4] += int.Parse(Console.ReadLine());
    Console.Write($"{eskinaslar[3]} AZN eskinaslari daxil edin: ");
    eskinassayi[3] += int.Parse(Console.ReadLine());
    Console.Write($"{eskinaslar[2]} AZN eskinaslari daxil edin: ");
    eskinassayi[2] += int.Parse(Console.ReadLine());
    Console.Write($"{eskinaslar[1]} AZN eskinaslari daxil edin: ");
    eskinassayi[1] += int.Parse(Console.ReadLine());
    Console.Write($"{eskinaslar[0]} AZN eskinaslari daxil edin: ");
    eskinassayi[0] += int.Parse(Console.ReadLine());
    update();
}

print();

void print()
{
    for(int i=0; i< eskinassayi.Length; i++)
    {
        Console.WriteLine(eskinassayi[i]);
        
    }
    Console.WriteLine(eskinasDeyeri);
    Console.WriteLine(eskinasSayiUmumi);

}

void carieskinaslar()
{
    Console.WriteLine("ATM de olan eskinaslar");
    Console.WriteLine($"{eskinaslar[6]} AZN eskinas {eskinassayi[6]} eded.");
    Console.WriteLine($"{eskinaslar[5]} AZN eskinas {eskinassayi[5]} eded.");
    Console.WriteLine($"{eskinaslar[4]} AZN eskinas {eskinassayi[4]} eded.");
    Console.WriteLine($"{eskinaslar[3]} AZN eskinas {eskinassayi[3]} eded.");
    Console.WriteLine($"{eskinaslar[2]} AZN eskinas {eskinassayi[2]} eded.");
    Console.WriteLine($"{eskinaslar[1]} AZN eskinas {eskinassayi[1]} eded.");
    Console.WriteLine($"{eskinaslar[0]} AZN eskinas {eskinassayi[0]} eded.");
    Console.WriteLine($"ATM-de olan eskinas sayi: {eskinasSayiUmumi}");
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
    int mexaric200 = mebleg/ 200;
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

void mprint ()
{
    Console.WriteLine("Verilen eskinaslar:");
    if (eskinasMexaric[6] > 0)
    {
        Console.WriteLine($"{eskinasMexaric[6]} eded 200 AZN");
    }
}