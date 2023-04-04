int Num(int n, int m)
{
   if (m == n)
        return m;
    return m + Num(n, m - 1);
}
Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine(Num(m, n));