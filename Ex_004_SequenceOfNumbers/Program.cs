// Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
// Первые два элемента последовательности задаются пользователем

void SequenceOfNumbers(int m, int n, int count)
{
    if (count != 0)
    {
        Console.Write($"{m + n} ");
        SequenceOfNumbers(n, m + n, count - 1);
    }
}

Console.Clear();
Console.Write("Введите первое число: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Последовательность чисел: ");
Console.Write($"{m} {n} ");
SequenceOfNumbers(m, n, 10);