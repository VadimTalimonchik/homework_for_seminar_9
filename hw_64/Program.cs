// Задача 64.
// Задайте значение N. Напишите программу, которая выведет все натуральные
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int a = InputInt("Введите положительное число: ");
int b = 1;

Console.WriteLine(NaturalNumber(a, b));

int NaturalNumber(int a, int b)
{
    if (a == b)
        return a;
    else
        Console.Write($"{NaturalNumber(a, b + 1)}, ");
    return b;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}
