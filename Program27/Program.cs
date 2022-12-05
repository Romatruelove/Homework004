internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число:");
        static int digSum(int n)
        {
            int sum = 0;
            while (n != 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            return sum;
        }
        static void Main()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Сумма всех цифр числа {n} = {digSum(n)}");
        }
        Main();
    }
}