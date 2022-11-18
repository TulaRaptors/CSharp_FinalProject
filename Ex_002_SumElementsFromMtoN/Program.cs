// Найти сумму элементов от M до N, N и M заданы


int SumElements(int m, int n)
{
    return m == n ? m : SumElements(m + 1, n) + m;
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Сумма элементов от {m} до {n}: {SumElements(m, n)}");