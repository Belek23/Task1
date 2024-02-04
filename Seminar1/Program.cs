// Выводим да если число в квадрате =

internal class Program
{
    private static void Main(string[] args)
    {
        int a = 25;
        int b = 5;

        if (a == b * b)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }



        // Выводим -4 до 4

        int N = 4;
        if (N < 0)
        {
            N = -N;
        }
        int i = -N;
        while (i <= N)
        {
            System.Console.Write(i);
            System.Console.Write(' ');
            i += 1;
        }

        // Прога которая принимает на ввод трёхзначное целое число 
        // и на выходе показывает сумму первой и последней цифры этого числа

        int a = 456;

        int a1 = a / 100;
        int a2 = a % 10;

        int sum = a1 + a2;
        System.Console.WriteLine(sum);
    }
}