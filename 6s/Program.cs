// СОЗДАНИЕ МАССИВОВ
// Ручной ввод массива
int[] ruc(int a)
{
    int[] mass = new int[a];
    for(int i = 0; i<a;i++)
    {
        Console.Write("Введите значения {0} число: ",i+1);
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
        if (mass[i] >= 0)
        {
            koll++;
        }
    }    
    return koll;
}
double[] dz2(double[] mass,double[] mass2)
{
// y = k1 * x + b1, y = k2 * x + b2;

//метод матриц(Закомиченный)
// -k1*x+y=b1, -k2*x+y=b2
//x= (b1*1-b2*1)/(-k1*1-(-k2)*1)
//y=(-k1*b2-(-k2)*b1)/(-k1*1-(-k2)*1)

//метод подстановки(рабочий)
//y = k1 * x + b1 k2*x-y=-b2 
//k2*x-(k1*x+b1)=-b2
//k2*x-k1*x-b1=-b2
//(k2-k1)x=-b2+b1
//x=(-b2+b1)/(k2-k1)
//y=k2*((-b2+b1)/(k2-k1))+b2
    double[] rez =new double[2];
    // rez[0] = (mass[0]-mass2[0])/((-mass[1]*1)-((-mass2[1])*1));
    // rez[1] = ((-mass[1]*mass2[0])-(-mass2[1]*mass[0]))/((-mass[1])-((-mass2[1])));
    double x = ((-mass2[0]+mass[0])/(mass2[1]-mass[1]));
    rez[0]= x;
    rez[1]= ((mass2[1]*x)+mass2[0]);
    return rez;
}

Console.WriteLine("   █████████     ███████       ███████     █████████  ██████████    ███████████   █████  █████████  \n  ███░░░░░███  ███░░░░░███   ███░░░░░███  ███░░░░░███░░███░░░░░█   ░░███░░██████ ░░███  ███░░░░░███ \n ███     ░░░  ███     ░░███ ███     ░░███░███    ░░░  ░███  █ ░     ░███ ░███░███ ░███ ███     ░░░  \n░███         ░███      ░███░███      ░███░░█████████  ░██████       ░███ ░███░░███░███░███          \n░███    █████░███      ░███░███      ░███ ░░░░░░░░███ ░███░░█       ░███ ░███ ░░██████░███          \n░░███  ░░███ ░░███     ███ ░░███     ███  ███    ░███ ░███ ░   █    ░███ ░███  ░░█████░░███     ███ \n ░░█████████  ░░░███████░   ░░░███████░  ░░█████████  ██████████    ██████████  ░░█████░░███████████");

Console.Write("Введите номер задания: ");
int zd = Convert.ToInt32(Console.ReadLine());
if (zd == 1)
{
    int rez = 0;
    int dz1_a = 0;
    Console.WriteLine("В каком режиме ввод чисел: ");
    Console.WriteLine("1-ручной режим(все элемменты руками) ");
    Console.WriteLine("2-полуавтоматический ввод(надо только ввести начальный и конечный диапозон элементов) ");
    int vvod = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество вводимых чисел: ");
    dz1_a = Convert.ToInt32(Console.ReadLine());
    if (vvod == 1)
    {
    int[] mass_dz1 = ruc(dz1_a);
    Console.WriteLine("Введеные числа: {0}{1}",String.Join(", ",mass_dz1)," ");
    rez = dz1(mass_dz1,dz1_a);
    }
    if (vvod == 2)
    {
    Console.Write("Введите начало диапозон: ");
    int dz1_b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите конец диапозон: ");
    int dz1_с = Convert.ToInt32(Console.ReadLine());
    int[] mass_dz1 = avt(dz1_a,dz1_b,dz1_с);
    Console.WriteLine("Введеные числа: {0}{1}",String.Join(", ",mass_dz1),"");
    rez = dz1(mass_dz1,dz1_a);
    }
    Console.WriteLine("Колличество чисел больше 0: ");
    Console.Write(rez);

}
if (zd == 2)
{
    double[] dz1m = new double[2];
    double[] dz2m = new double[2];
    
    Console.WriteLine("Введите b1: ");
    dz1m[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите k1: ");
    dz1m[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите b2: ");
    dz2m[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите k2: ");
    dz2m[1] = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Уравнение: y={0}*x+{1}",String.Join(", ",dz1m[1]),String.Join(", ",dz1m[0]));
    Console.WriteLine("Уравнение: y={0}*x+{1}",String.Join(", ",dz2m[1]),String.Join(", ",dz2m[0]));
    double[] rez = dz2(dz1m,dz2m);
    Console.WriteLine("Точка в координате x равна: {0}",String.Join(", ",rez[0]));
    Console.WriteLine("Точка пересечений прямых: ( {0}{1}",String.Join(", ",rez)," )");
}