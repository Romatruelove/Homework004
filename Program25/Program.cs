internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число А:");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число B:");
        int b = Convert.ToInt32(Console.ReadLine());

        void ToDegree(int a, int b)
        {
            int result = 1;
            for (int i = 1; i <= b; i++)
            {
                result = result * a;
            }
            Console.WriteLine($"{a}^{b}={result}");
        }
        ToDegree(a, b);
    }
}