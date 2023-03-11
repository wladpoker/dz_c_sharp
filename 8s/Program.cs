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

int[,,] avt_dz4(int a, int b, int c, int minimum = 10, int maximum = 99)
{
    int[,,] mass = new int[a, b, c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for (int f = 0; f < c; f++)
            {
                mass[i, j, f] = rnd.Next(minimum, maximum);
                Console.Write("{3,2}( {0},{1},{2} )  " ,i, j, f, mass[i, j, f]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    return mass;
}






// ФУНКЦИИ РЕШЕНИЙ

// Функция конвертации массивов двумерного на одномерный(берет только 1 строчку двумерного) 
double[] konvert(double[,] mass, int a, int b)
{
    double[] m1 = new double[b];
    int z = 0;
    for (int j = 0; j < b; j++)
    {
        m1[j] = mass[a, j];
        z++;
    }
    return m1;
}

double[,] dz1(double[,] mass, int a, int b)
{   
    double[,] rez = new double[a,b];
    for (int i=0;i<a;i++)
    {
        double[] mass_konv = konvert(mass,i,b);
        Array.Sort(mass_konv);
        Array.Reverse(mass_konv);
        for (int j=0;j<b;j++)
        {
            rez[i,j]= mass_konv[j];
            Console.Write("{0,7}", mass_konv[j]);

        }
    Console.WriteLine();
    }

    return rez;
}

double[] dz2(double[,] mass, int a,int b)
{
    double[] mass_rez = new double[a];
    for (int i=0;i<a;i++)
    {
        double sum = 0;
        for (int j=0;j<b;j++)
        {
            sum += mass[i,j];
        }
        mass_rez[i] += sum; 
    }
    Console.WriteLine("Массив: [ {0,7}{1}",String.Join(", ",mass_rez)," ]");
    double min = 0;
    double minlern = mass_rez[0];
    for (int i=0;i<a;i++)
    {
        if (minlern > mass_rez[i])
        {
            min = i;
            minlern = mass_rez[i];
        }
    }
    Console.WriteLine("Наименьшая сумма элементов в строке двумерного массива: {0} ",String.Join(" ",min+1));
    return mass_rez;
}

double[,] dz3(double[,] mass_a, double[,] mass_b, int a, int b)
{
    double[,] rez = new double[a,b];
    rez[0,0] = Math.Round((mass_a[0,0]*mass_b[0,0]+mass_a[0,1]*mass_b[1,0]),1);
    rez[0,1] = Math.Round((mass_a[0,0]*mass_b[0,1]+mass_a[0,1]*mass_b[1,1]),1);
    rez[1,0] = Math.Round((mass_a[1,0]*mass_b[0,0]+mass_a[1,0]*mass_b[1,0]),1);
    rez[1,1] = Math.Round((mass_a[1,0]*mass_b[0,1]+mass_a[1,1]*mass_b[1,1]),1);
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Console.Write("{0,21}", rez[i, j]);
        }
        Console.WriteLine();
    }
    return rez;
}

int[,] dz5(int n, int m)
{
    int[,] A = new int[n, m];
    int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = m;

    for (int i = 0; i < A.Length; i++)
    {
        A[col, row] = i + 1;
        if (--gran == 0)
        {
            gran = m*(dirChanges%2) + n*((dirChanges + 1)%2) - (dirChanges/2 - 1) - 2;
            int temp = dx;
            dx = -dy;
            dy = temp;
            dirChanges++;
        }
        col += dx;
        row += dy;
    }
    return A;
}

int[,] dz5_rez(int n, int m)
{
    var arr = dz5(n, m);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n/2; j++)
        {
            var tmp = arr[i, j];
            arr[i, j] = arr[i, m - j - 1];
            arr[i, m - j - 1] = tmp;
        }
    }
    return arr;
}

Console.WriteLine("   █████████     ███████       ███████     █████████  ██████████    ███████████   █████  █████████  \n  ███░░░░░███  ███░░░░░███   ███░░░░░███  ███░░░░░███░░███░░░░░█   ░░███░░██████ ░░███  ███░░░░░███ \n ███     ░░░  ███     ░░███ ███     ░░███░███    ░░░  ░███  █ ░     ░███ ░███░███ ░███ ███     ░░░  \n░███         ░███      ░███░███      ░███░░█████████  ░██████       ░███ ░███░░███░███░███          \n░███    █████░███      ░███░███      ░███ ░░░░░░░░███ ░███░░█       ░███ ░███ ░░██████░███          \n░░███  ░░███ ░░███     ███ ░░███     ███  ███    ░███ ░███ ░   █    ░███ ░███  ░░█████░░███     ███ \n ░░█████████  ░░░███████░   ░░░███████░  ░░█████████  ██████████    ██████████  ░░█████░░███████████");

Console.Write("Введите номер задания: ");
int zd = Convert.ToInt32(Console.ReadLine());
if (zd == 1)
{
    int dz1_a = 3;
    int dz1_b =4;
    double[,] mass_dz1 = avt(dz1_a,dz1_b);
    Console.WriteLine();
    double[,] rez = dz1(mass_dz1,dz1_a,dz1_b);
}
if (zd == 2)
{

    int dz2_a = 3;
    int dz2_b =4;
    double[,] mass_dz2 = avt(dz2_a,dz2_b);
    double[] rez = dz2(mass_dz2,dz2_a,dz2_b);

}

if (zd == 3)
{

    int dz3_a = 2;
    int dz3_b = 2;
    double[,] mass_dz3_a = avt(dz3_a,dz3_b);
    Console.WriteLine("  -------------");
    double[,] mass_dz3_b = avt(dz3_a,dz3_b);
    Console.WriteLine("Результат произведения матриц:");
    double[,] rez = dz3(mass_dz3_a,mass_dz3_b,dz3_a,dz3_b);
}

if (zd == 4)
{
    int dz4_a = 2;
    int dz4_b = 2;
    int dz4_c = 2;
    int[,,] rez = avt_dz4(dz4_a,dz4_b,dz4_c);
}

if (zd == 5)
{
    int N = 4, M = 4;
    var a = dz5_rez(N, M);

    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < M; j++)
        {
            Console.Write(a[i, j] + "   ");
        }
        Console.WriteLine();
    }



}