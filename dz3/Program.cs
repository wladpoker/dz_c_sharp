string dz1(string a)
{
    char[] text = a.ToCharArray();
    Array.Reverse(text);
    string ftext = new string(text);
    return ftext;
}

double dz2(string a, string b)
{
string[] suba = a.Split(' ');
string[] subb = b.Split(' ');
double rez = Math.Sqrt(Math.Pow((Convert.ToDouble(subb[0])-Convert.ToDouble(suba[0])),2)+Math.Pow(((Convert.ToDouble(subb[1])-Convert.ToDouble(suba[1]))),2)+Math.Pow(Convert.ToDouble(subb[2])-Convert.ToDouble(suba[2]),2));
return rez;
}

Console.WriteLine("Добро пожаловать в домашнее задание 1 семинара");
Console.Write("Введите номер задания в их порядке: ");
int dz = Convert.ToInt32(Console.ReadLine());
if (dz == 1)
{
    Console.Write("Введите любое слово или число для проверки на палиндром: ");
    string zd1_a = Console.ReadLine()!;
    string rez1 = dz1(zd1_a);
    if(zd1_a==rez1)
        {
        Console.Write("Данная запись является палиндромом");
        }
        if (zd1_a!=rez1)
        {
        Console.Write("Данная запись не является палиндромом");
        }
}
if (dz == 2)
{
    Console.Write("Введите координта точки A через пробел: ");
    string zd2_a = Console.ReadLine()!;
    Console.Write("Введите координта точки B через пробел: ");
    string zd2_b = Console.ReadLine()!;
    double rez2 = dz2(zd2_a,zd2_b);
    Console.Write("Растояние от точки A до точки B: ");
    Console.Write(rez2);
}
if (dz == 3)
{
    Console.Write("Введите колличество выводимых чисел: ");
    int zd3_a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Вывод данных: ");
    for (double i = 1; i <= zd3_a; i++)
    {
        double rez = Math.Pow(i,3);
        Console.Write(rez);
        Console.Write(" ");
    }
}
