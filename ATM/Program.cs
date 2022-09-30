Console.WriteLine($"EfqanBank ASC-ye xosh gelmisiniz \nXahish edirik bankomatla emtmek istediyiniz emliyyati sechin");

int[] eskinaslar = new int[7] { 1, 5, 10, 20, 50, 100, 200 };
int[] eskinassayi = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
int[] eskinasMedaxil = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
int[] eskinasMexaric = new int[7] { 0, 0, 0, 0, 0, 0, 0 };
int mebleg = 0;
int eskinasDeyeri = 0;
int eskinasSayiUmumi = 0;


emeliyyatSechim();


void emeliyyatSechim()
{
    Console.WriteLine("Medaxil etmek uchun 'd' --- mexaric etmek uchun 'x' --- ATM-deki eskinaslar barede melumat almaq ucun 'm'");
    char sechim = char.Parse(Console.ReadLine());
    switch (sechim)
    {
        case 'd':
            medaxil();
            break;
        case 'x':
            mexaricSorgu();
            mexaric();
            break;
        case 'm':
            carieskinaslar();
            break;
            default:
            Console.WriteLine("Duzgun sechim edin");
            emeliyyatSechim();
            break;
    }
}



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
    for(int i = 0; i < eskinassayi.Length; i++)
    {
        Console.Write($"{eskinaslar[i]} AZN eskinaslari daxil edin: ");
        eskinassayi[i] += int.Parse(Console.ReadLine());
    }
    update();
    davam();
}




void carieskinaslar()
{
    Console.WriteLine("ATM de olan eskinaslar");
    for(int i= 0; i < eskinassayi.Length; i++)
    {
        Console.WriteLine($"{eskinaslar[i]} AZN eskinas {eskinassayi[i]} eded.");
    }
    
    Console.WriteLine($"ATM-de olan eskinas sayi: {eskinasSayiUmumi}");
    Console.WriteLine($"ATM-de olan eskinas deyeri: {eskinasDeyeri}");
    davam();
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
    while (mebleg > eskinasDeyeri)
    {
        Console.Write($"Istediyiniz mebleg hal-hazirda bankomatda yoxdur. \nXahish edirik bashqa mebleg sechin: ");
        mebleg = int.Parse(Console.ReadLine());
    }
}

void mexaric()
{
    int qaliqMebleg = mebleg;
    for(int i=6; i >= 0; i--)
    {
        int say = qaliqMebleg / eskinaslar[i];
        int qaliq = qaliqMebleg % eskinaslar[i];
        if (say > 0 && say <= eskinassayi[i])
        {
            Console.WriteLine($"{say} eded {eskinaslar[i]} AZN");
            eskinassayi[i] -= say;
            qaliqMebleg = qaliq;
        }
        else if (say>0 && eskinassayi[i]>0 && say > eskinassayi[i])
        {
            Console.WriteLine($"{eskinassayi[i]} eded {eskinaslar[i]} AZN");
            eskinassayi[i] = 0;
            qaliqMebleg = qaliq + (say - eskinassayi[i]) * eskinaslar[i];
        }
        else
        {
            Console.WriteLine("Istediyiniz meblegi vere bilecek eskinaslar bankomatda yoxdur. Bashqa mebleg secin");
        }
            continue;
    }

    update();
    davam();
}

void mprint ()
{
    Console.WriteLine("Verilen eskinaslar:");
    if (eskinasMexaric[6] > 0)
    {
        Console.WriteLine($"{eskinasMexaric[6]} eded 200 AZN");
    }
}

void davam()
{
        emeliyyatSechim();
}