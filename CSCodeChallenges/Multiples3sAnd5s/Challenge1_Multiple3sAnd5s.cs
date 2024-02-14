namespace Multiples3sAnd5s
{
    internal class Challenge1_Multiple3sAnd5s
    {
        static void Main(string[] args)
        {
            int below10 = 3 + 5 + 6 + 9;
            Console.WriteLine(below10);

            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
