// СОЗДАНИЕ МАССИВОВ
//Полуавтоматический ввод массива(можно вводить разброс)
Random rnd = new Random();
double[,] avt(int a, int b, double maximum = -10.0, double minimum = 10.0)
{
    double[,] mass = new double[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            mass[i, j] = Math.Round((rnd.NextDouble() * (maximum - minimum) + minimum),1);
            Console.Write("{0,7}", mass[i, j]);
        }
        Console.WriteLine();
    }
    return mass;
}

// ФУНКЦИИ РЕШЕНИЙ
double dz3(double[,] mass, int a, int b)
{
    double sum = 0;
    for (int i = 0; i < b; i++)
    {
        sum += mass[a,i];
    }
    double rez = sum/b;
    return rez;
}

Console.WriteLine("   █████████     ███████       ███████     █████████  ██████████    ███████████   █████  █████████  \n  ███░░░░░███  ███░░░░░███   ███░░░░░███  ███░░░░░███░░███░░░░░█   ░░███░░██████ ░░███  ███░░░░░███ \n ███     ░░░  ███     ░░███ ███     ░░███░███    ░░░  ░███  █ ░     ░███ ░███░███ ░███ ███     ░░░  \n░███         ░███      ░███░███      ░███░░█████████  ░██████       ░███ ░███░░███░███░███          \n░███    █████░███      ░███░███      ░███ ░░░░░░░░███ ░███░░█       ░███ ░███ ░░██████░███          \n░░███  ░░███ ░░███     ███ ░░███     ███  ███    ░███ ░███ ░   █    ░███ ░███  ░░█████░░███     ███ \n ░░█████████  ░░░███████░   ░░░███████░  ░░█████████  ██████████    ██████████  ░░█████░░███████████");

Console.Write("Введите номер задания: ");
int zd = Convert.ToInt32(Console.ReadLine());
if (zd == 1)
{
    int dz1_a = 3;
    int dz1_b =4;
    double[,] mass_dz1 = avt(dz1_a,dz1_b);
}
if (zd == 2)
{
    int dz1_a = 3;
    int dz1_b =4;
    Console.Write("Введите введите строку массива искомого элемента: ");
    int dz2_ps = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите введите позицию искомого элемента: ");
    int dz2_pi = Convert.ToInt32(Console.ReadLine());
    double[,] mass_dz2 = avt(dz1_a,dz1_b);
    if (dz2_ps<=dz1_a)
    {
        if (dz2_pi<=dz1_b)
        Console.Write("{0} -> искомое число",String.Join(", ",mass_dz2[dz2_ps,dz2_pi]));
    }
    else
    {
    Console.Write(" в позициях {0} {1} -> такого числа в массиве нет",String.Join("",dz2_ps),String.Join("",dz2_pi));
    }
}

if (zd == 3)
{
    int dz3_a = 3;
    int dz3_b =4;
    double[] rez = new double[dz3_a];
    double[,] mass_dz3 = avt(dz3_a,dz3_b);
    for (int i = 0; i < dz3_a-1; i++)
    {
        rez[i] = Math.Round(dz3(mass_dz3,i,dz3_b),2);
    }
    Console.WriteLine("среднее африфметическое {0}", String.Join(" ",rez));
}

