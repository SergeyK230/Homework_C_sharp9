int SumOfNumbers(int num)
{
    int sum = 0;
    if (num != 0) sum = num % 10 + SumOfNumbers(num / 10);
    return sum;
}

System.Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
System.Console.WriteLine(SumOfNumbers(number));