// Напишите программу, которая выводить 3 с конца цифру заданного числа
// или cообщает, что 3 цифры нет.

int num = 56;

int thirdNum  = num / 100;
if (num /100 != 0)
{
    System.Console.WriteLine(thirdNum % 10);
}
else
{
System.Console.WriteLine("Третьей цифры нет");
}