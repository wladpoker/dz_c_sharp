int dz1(int a, int b)
{
    int rez=a;
    for (int i = 2; i <= b; i++)
    {
        rez*=a;
    }
    return rez;
}
int dz2(int a)
{
    int rez =0;
    while (a > 0)
    {
        rez = rez + a % 10;
        a = a /10 ;
    }
    return rez;
}

int[] dz3(int a)
{
    int[] mass = new int[a];
    for(int i = 0; i<a;i++)
    {
        Console.WriteLine("Введите значения {0} элеменат массива: ",i);
        mass[i] = Convert.ToInt32(Console.ReadLine());
        
    }    
    return mass;
}
Console.WriteLine("Введите номер задания: ");
int zd = Convert.ToInt32(Console.ReadLine());
if (zd == 1)
{
    Console.WriteLine("Введите число для возведения в степень: ");
    int dz1_a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите степень для этого числа: ");
    int dz1_b = Convert.ToInt32(Console.ReadLine());
    int rez = dz1(dz1_a,dz1_b);
    Console.WriteLine("Результат: ");
    Console.Write(rez);

}
if (zd == 2)
{
    Console.WriteLine("Введите целое число: ");
    int dz2_a = Convert.ToInt32(Console.ReadLine());
    int rez = dz2(dz2_a);
    Console.WriteLine("Сумма чисел числа: ");
    Console.Write(rez);
}
if (zd == 3)
{
    Console.Write("Введите количество элементов массива: ");
    int dz3_a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\nМассив: [ {0}{1}",String.Join(", ",dz3(dz3_a))," ]");
}
