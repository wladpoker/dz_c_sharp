  
int dz1(int a,int b)
{
    if (a>b)
      return a;
    else 
      return b;
}

int dz2(int a,int b,int c)
{
    int[] array = {a,b,c}; 
    return array.Max();
}

string dz3(int a)
{
    if (a%2 == 0)
      return "True";
    else
      return "False";
    
}

// int dz4(int a)
// {
//     for (int i = 1; i < a; i++)
//     {
//     Console.Write(i);
//     }
// }

Console.WriteLine("Добро пожаловать в домашнее задание 1 семинара");
Console.Write("Введите номер задания в их порядке: ");
int dz = Convert.ToInt32(Console.ReadLine());
if (dz == 1)
{
    Console.Write("Введите 1 целое число: ");
    int zd1_a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2 целое число: ");
    int zd1_b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное число: ");
    int rez1 = dz1(zd1_a,zd1_b);
    Console.Write(rez1);
}
if (dz == 2)
{
    Console.Write("Введите 1 целое число: ");
    int zd2_a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2 целое число: ");
    int zd2_b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 3 целое число: ");
    int zd2_c = Convert.ToInt32(Console.ReadLine());
    Console.Write("Максимальное число: ");
    int rez2 = dz2(zd2_a,zd2_b,zd2_c);
    Console.Write(rez2);
}
if (dz == 3)
{
    Console.Write("Введите целое число: ");
    int zd3_a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Является ди число четным: ");
    string rez3 = dz3(zd3_a);
    Console.Write(rez3);
}
if (dz == 4)
{
    Console.Write("Введите целое число: ");
    int zd4_a = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= zd4_a; i++)
    {
    if (i%2 == 0)
    {
        Console.Write(i);
        Console.Write(" ");
    }
    }
}
