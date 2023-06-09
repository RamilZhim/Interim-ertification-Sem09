// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadInt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int sumOfElements(int M, int N)
{
    if (M == N) return M;
    else return M + sumOfElements(M + 1, N);
}

void printSum(int M, int N)
{
    Console.Write("Сумма натуральных элементов в промежутке от M до N: " + sumOfElements(M, N));
}

printSum(ReadInt("Введите положительное число M: "), ReadInt("Введите положительное число N: "));
