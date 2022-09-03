// Найти сумму элементов от M до N, N и M заданы

Console.WriteLine("Введите число M:");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число M:");
int numberN = Convert.ToInt32(Console.ReadLine());

void Numbers (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    Numbers(numberM, numberN, sum);
}

Numbers(numberM, numberN, 0);
