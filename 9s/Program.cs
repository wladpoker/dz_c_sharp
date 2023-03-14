string dz1(int n)
{
    if (n == 0) return " 1";
    Console.Write(" {0}",n);
    return dz1(n - 1);
}

int dz2( int m, int n)
{
    if (n == m) return m;
    return n + dz2(m,n - 1);
}

int dz3(int n, int m)
{
// https://ru.wikipedia.org/wiki/Функция_Аккермана
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return dz3(n - 1, 1);
    else
      return dz3(n - 1, dz3(n, m - 1));
}


Console.WriteLine("   █████████     ███████       ███████     █████████  ██████████    ███████████   █████  █████████  \n  ███░░░░░███  ███░░░░░███   ███░░░░░███  ███░░░░░███░░███░░░░░█   ░░███░░██████ ░░███  ███░░░░░███ \n ███     ░░░  ███     ░░███ ███     ░░███░███    ░░░  ░███  █ ░     ░███ ░███░███ ░███ ███     ░░░  \n░███         ░███      ░███░███      ░███░░█████████  ░██████       ░███ ░███░░███░███░███          \n░███    █████░███      ░███░███      ░███ ░░░░░░░░███ ░███░░█       ░███ ░███ ░░██████░███          \n░░███  ░░███ ░░███     ███ ░░███     ███  ███    ░███ ░███ ░   █    ░███ ░███  ░░█████░░███     ███ \n ░░█████████  ░░░███████░   ░░░███████░  ░░█████████  ██████████    ██████████  ░░█████░░███████████");

Console.Write("Введите номер задания: ");
int zd = Convert.ToInt32(Console.ReadLine());
if (zd == 1)
{
    Console.Write("Введите N число: ");
    int dz1_a = Convert.ToInt32(Console.ReadLine());

    dz1(dz1_a);

}
if (zd == 2)
{
    Console.Write("Введите M число: ");
    int dz2_a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N число: ");
    int dz2_b = Convert.ToInt32(Console.ReadLine());
    int rez = dz2(dz2_a,dz2_b);

    Console.Write($"Сумма чисел от {dz2_a} до {dz2_b}: {rez}");
    // Console.Write(rez);
}
if (zd == 3)
{
    Console.Write("Введите M число: ");
    int dz3_a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N число: ");
    int dz3_b = Convert.ToInt32(Console.ReadLine());
    int rez = dz3(dz3_a,dz3_b);
    Console.Write($"Решение функции Аккермана ({dz3_a}, {dz3_b}): {rez}");
}