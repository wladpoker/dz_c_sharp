// СОЗДАНИЕ МАССИВОВ
// Ручной ввод массива
int[] ruc(int a)
{
    int[] mass = new int[a];
    for(int i = 0; i<a;i++)
    {
        Console.Write("Введите значения {0} элеменат массива: ",i);
        mass[i] = Convert.ToInt32(Console.ReadLine());
        
    }
    return mass;
}
//Полуавтоматический ввод массива(можно вводить разброс)
Random rnd = new Random();
int[] avt(int a, int b, int c)
{
    int[] mass = new int[a];
    for(int i = 0; i<a;i++)
    {
        mass[i] = Convert.ToInt32(rnd.Next(b, c));   
    }
    return mass;
}

// ФУНКЦИИ РЕШЕНИЙ
int dz1(int[] mass, int a)
{
    int koll =0;
    for (int i=0;i<a;i++)
    {
        if (mass[i] % 2 == 0)
        {
            koll++;
        }
    }    
    return koll;
}
int dz2(int[] mass,int a)
{
    int sum =0;
    for (int i=0;i<a;i++)
    {
        if (i % 2 != 0)
        {
            sum += mass[i];
        }
    }    
    return sum;
}

int dz3(int[] mass,int a)
{
    int raz =0;
    int min = mass[0];
    int max = 0;
    for (int i=0;i<a;i++)
    {
        if (min > mass[i])
        {
            min = mass[i];
        }
        if (max < mass[i])
        {
            max = mass[i];
        }
    }
    raz = max-min;    
    return raz;
}

Console.WriteLine("   █████████     ███████       ███████     █████████  ██████████    ███████████   █████  █████████  \n  ███░░░░░███  ███░░░░░███   ███░░░░░███  ███░░░░░███░░███░░░░░█   ░░███░░██████ ░░███  ███░░░░░███ \n ███     ░░░  ███     ░░███ ███     ░░███░███    ░░░  ░███  █ ░     ░███ ░███░███ ░███ ███     ░░░  \n░███         ░███      ░███░███      ░███░░█████████  ░██████       ░███ ░███░░███░███░███          \n░███    █████░███      ░███░███      ░███ ░░░░░░░░███ ░███░░█       ░███ ░███ ░░██████░███          \n░░███  ░░███ ░░███     ███ ░░███     ███  ███    ░███ ░███ ░   █    ░███ ░███  ░░█████░░███     ███ \n ░░█████████  ░░░███████░   ░░░███████░  ░░█████████  ██████████    ██████████  ░░█████░░███████████");

Console.Write("Введите номер задания: ");
int zd = Convert.ToInt32(Console.ReadLine());
if (zd == 1)
{
    int rez = 0;
    int dz1_a = 0;
    Console.WriteLine("В каком режиме ввод массива: ");
    Console.WriteLine("1-ручной режим(все элемменты руками) ");
    Console.WriteLine("2-полуавтоматический ввод(надо только ввести начальный и конечный диапозон элементов) ");
    int vvod = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество элементов массива: ");
    dz1_a = Convert.ToInt32(Console.ReadLine());
    if (vvod == 1)
    {
    int[] mass_dz1 = ruc(dz1_a);
    Console.WriteLine("Массив: [ {0}{1}",String.Join(", ",mass_dz1)," ]");
    rez = dz1(mass_dz1,dz1_a);
    }
    if (vvod == 2)
    {
    Console.Write("Введите начало диапозон: ");
    int dz1_b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конец диапозон: ");
    int dz1_с = Convert.ToInt32(Console.ReadLine());
    int[] mass_dz1 = avt(dz1_a,dz1_b,dz1_с);
    Console.WriteLine("Массив: [ {0}{1}",String.Join(", ",mass_dz1)," ]");
    rez = dz1(mass_dz1,dz1_a);
    }
    Console.WriteLine("Колличество четных элеммента массива: ");
    Console.Write(rez);

}
if (zd == 2)
{
    int rez = 0;
    int dz1_a = 0;
    Console.WriteLine("В каком режиме ввод массива: ");
    Console.WriteLine("1-ручной режим(все элемменты руками) ");
    Console.WriteLine("2-полуавтоматический ввод(надо только ввести начальный и конечный диапозон элементов) ");
    int vvod = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество элементов массива: ");
    dz1_a = Convert.ToInt32(Console.ReadLine());
    if (vvod == 1)
    {
    int[] mass_dz1 = ruc(dz1_a);
    Console.WriteLine("Массив: [ {0}{1}",String.Join(", ",mass_dz1)," ]");
    rez = dz2(mass_dz1,dz1_a);
    }
    if (vvod == 2)
    {
    Console.Write("Введите начало диапозон: ");
    int dz1_b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конец диапозон: ");
    int dz1_с = Convert.ToInt32(Console.ReadLine());
    int[] mass_dz1 = avt(dz1_a,dz1_b,dz1_с);
    Console.WriteLine("Массив: [ {0}{1}",String.Join(", ",mass_dz1)," ]");
    rez = dz2(mass_dz1,dz1_a);
    }
    Console.Write("Сумма элементов на нечетных позициях: ");
    Console.Write(rez);

}
if (zd == 3)
{
    int rez = 0;
    int dz1_a = 0;
    Console.WriteLine("В каком режиме ввод массива: ");
    Console.WriteLine("1-ручной режим(все элемменты руками) ");
    Console.WriteLine("2-полуавтоматический ввод(надо только ввести начальный и конечный диапозон элементов) ");
    int vvod = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество элементов массива: ");
    dz1_a = Convert.ToInt32(Console.ReadLine());
    if (vvod == 1)
    {
    int[] mass_dz1 = ruc(dz1_a);
    Console.WriteLine("Массив: [ {0}{1}",String.Join(", ",mass_dz1)," ]");
    rez = dz3(mass_dz1,dz1_a);
    }
    if (vvod == 2)
    {
    Console.Write("Введите начало диапозон: ");
    int dz1_b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конец диапозон: ");
    int dz1_с = Convert.ToInt32(Console.ReadLine());
    int[] mass_dz1 = avt(dz1_a,dz1_b,dz1_с);
    Console.WriteLine("Массив: [ {0}{1}",String.Join(", ",mass_dz1)," ]");
    rez = dz3(mass_dz1,dz1_a);
    }
    Console.Write("Разность максимального и минимального элемента массива: ");
    Console.Write(rez);

}