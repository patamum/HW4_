namespace Task4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N, S = 0;
            Console.WriteLine("Введите N");
            N = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= N; i++)
            {
                S += 2 * i - 1;
                Console.WriteLine(S);
            }
        }
    }
}