string dz1(int a)
{
    string str = a.ToString();
    int lern = str.Length;
    if (lern>=2)
    {
        string rez = str[1].ToString();
        return rez;
    }
    else 
    {
        return "Некоректный ввод";
    }

}

string dz2(int a)
{
    string str = a.ToString();
    int lern = str.Length;
    if (lern>=3)
    {
        string rez = str[2].ToString();
        return rez;
    }
    else 
    {
        return "Третьего чисда не существует";
    }
}

string dz3(int a)
{
    if (a<= 5)
    {
        return "False";
    }

    else  
    {
      if ((a == 6)^(a == 7))
      {
        return "True";
      }
      else
      {
        return "Некоректный ввод";
      }
    }
}

Console.WriteLine("Добро пожаловать в домашнее задание 1 семинара");
Console.Write("Введите номер задания в их порядке: ");
int dz = Convert.ToInt32(Console.ReadLine());
if (dz == 1)
{
    Console.Write("Введите целое трехзначное число: ");
    int zd1_a = Convert.ToInt32(Console.ReadLine());
    string rez1 = dz1(zd1_a);
    Console.Write("Второе число в заданом числе: ");
    Console.Write(rez1);
}
if (dz == 2)
{
    Console.Write("Введите целое число: ");
    int zd2_a = Convert.ToInt32(Console.ReadLine());
    string rez2 = dz2(zd2_a);
    Console.Write("Третие число в заданом числе: ");
    Console.Write(rez2);
}
if (dz == 3)
{
    Console.Write("Введите номер дня недели: ");
    int zd3_a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Является ли выходным днем: ");
    string rez3 = dz3(zd3_a);
    Console.Write(rez3);
}