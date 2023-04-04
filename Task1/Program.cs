int Num(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{Num(n, m + 1)}, ");
    return m;
}
Console.Clear();
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int m = 1;
Console.WriteLine(Num(n, m));