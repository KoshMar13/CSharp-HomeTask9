// 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

// int Ackermann(int number, int argument)
// {
//     if (number == 0)
//         return argument + 1;
//     int result = argument;
//     for (int i = 0; i < argument + 2; i++)
//     {
//         result = Ackermann(number - 1, result);
//     }
//     return result;
// }

long Ackermann(long number, long argument)
{
    if (number == 0)
        return argument + 1;
    if (number != 0 && argument == 0)
        return Ackermann(number - 1, 1);
    return Ackermann(number - 1, Ackermann(number, argument - 1));
}

Console.Write("Insert natural number M: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert natural number N: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Ackermann(number1, number2));
