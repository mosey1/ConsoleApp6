using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
    { //3.2  сложный уровень 10 вариант
        try
        {
            Console.WriteLine("Введите n:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int s = 0;
                string res = "";
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        s += j;
                        res += j + "+";
                    }
                }
                if (i == s) Console.WriteLine(res + "=" + i);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}
