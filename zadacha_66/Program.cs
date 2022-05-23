int SumOfNumbers(int m, int n)
{
    if (m != n) m = m + SumOfNumbers(m + 1, n);
    return m;
}

System.Console.WriteLine("Введите число m");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите число n");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine(SumOfNumbers(m, n));