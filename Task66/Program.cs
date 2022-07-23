// 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SummMtoN(int start, int finish)
{
    if (start < finish)
    {
        if (start == finish)
            return finish;
        return SummMtoN(start + 1, finish) + start;
    }
    else
    {
        if (finish == start)
            return start;
        return SummMtoN(finish + 1, start) + finish;
    }
}

Console.Write("Insert natural number M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert natural number N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int sum = number1;
Console.WriteLine($"Sum of numbers from {number1} to {number2} is {SummMtoN(number1, number2)}");
