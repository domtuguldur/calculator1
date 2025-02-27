using calculatorlibrary1;

internal class Program
{
    private static void Main(string[] args)
    {
        int num;
        Memory memory = new Memory();
        Calculator calculator = new Calculator();
        while (true)
        {
            Console.WriteLine($"{calculator.results}");
            Console.WriteLine("uildliig ugnu");
            Console.WriteLine("1. nemeh");
            Console.WriteLine("2. hasah");
            Console.WriteLine("3. memory hadgalah");
            Console.WriteLine("4. memory harah");
            Console.WriteLine("5. memorynoos too awah");
            Console.WriteLine("6. memory tsewerleh");
            int uildel = Convert.ToInt32(Console.ReadLine());
            if (uildel == 1)
            {
                Console.WriteLine("nemeh toog ugnu uu:");
                num = Convert.ToInt32(Console.ReadLine());
                calculator.Sum(num);
                Console.WriteLine($"hariu: {calculator.results}");
            }
            else if (uildel == 2)
            {
                Console.WriteLine("hasah toog ugnu uu:");
                num = Convert.ToInt32(Console.ReadLine());
                calculator.Sub(num);
                Console.WriteLine($"hariu: {calculator.results}");
            }
            else if (uildel == 3)
            {
                memory.hadgalah(calculator.results);
            }
            else if (uildel == 4)
            {
                memory.harah();
            }
            else if (uildel == 5)
            {
                int len = memory.toonuud.Count();
                Console.WriteLine($"1-{len} hurtel toonoos songono uu");
                Console.WriteLine("heddeh toog awah we");
                num = Convert.ToInt32(Console.ReadLine());
                calculator.results = memory.toonuud[num-1];
                Console.WriteLine($"{calculator.results}");
            }
            else if (uildel == 6)
            {
                memory.tsewereh();
            }

        }
    }
}