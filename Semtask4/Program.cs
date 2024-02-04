// Большее из двух чисел

internal class Program
{
    private static void Main(string[] args)
    {
        int firstNumber = 5;
        int secondNumber = 6;

        if (firstNumber > secondNumber)
        {
            System.Console.WriteLine("первое число больше");
        }
        else if (firstNumber < secondNumber)
        {
            System.Console.WriteLine("Второе число больше");
        }
        else
        {
            System.Console.WriteLine("числа равны");
        }
    }
}