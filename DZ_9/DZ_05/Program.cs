﻿// Написать программу показывающие первые N чисел, для которых каждое 
// следующее равно сумме двух предыдущих. Первые два элемента последовательности
//задаются пользователем

double Fibonacci(int n)
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}
for (int i = 1; i < 20; i++)
{

 Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}