Console.Write("Введите натуральное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Простые делители числа {n}:");
GetPrimeFactors(n);    
    static void GetPrimeFactors(int n)
{
    for (int i = 2; i <= n; i++)
    {
        while (n % i == 0)
        {
            Console.Write(i + " ");
            n /= i;
        }
    }
    Console.WriteLine();
}