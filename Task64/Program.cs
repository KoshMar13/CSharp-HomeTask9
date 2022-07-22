// 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5. -> ""5, 4, 3, 2, 1""

void NaturalNtoOne(int number)
{
    if (number == 1)
    {
        Console.Write(number);
        return;
    }
    Console.Write($"{number}, ");
    NaturalNtoOne(number - 1);
}

Console.Write("Insert natural number: ");
int numb = Convert.ToInt32(Console.ReadLine());
NaturalNtoOne(numb);
