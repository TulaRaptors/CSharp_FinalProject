//Показать натуральные числа от M до N, N и M заданы

void ShowNumbers(int m, int n)
{
    if (m <= n)
    {
        Console.Write(m + " ");
        ShowNumbers(m + 1, n);
    }
}

Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine($"Натуральные числа от {m} до {n}: ");
ShowNumbers(m, n);