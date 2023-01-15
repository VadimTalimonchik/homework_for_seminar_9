// Задача 66.
// Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int m = InputInt("Введите значение M: ");
int n = InputInt("Введите значение N: ");
Console.WriteLine($"Сумма натуральных элементов от {m} до {n} равна {NaturalNumbersSum(m, n)}.");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine()!);
}

int NaturalNumbersSum(int m, int n)
{
    if (m == n)
        return n;
    return n + NaturalNumbersSum(m, n - 1);
}
