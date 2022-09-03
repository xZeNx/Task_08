//Показать натуральные числа от M до N, N и M заданы 

string NaturalNum(int m, int n)
{
if (n == m)
{
    return Convert.ToString(m);
}
    return NaturalNum(m, n - 1) + " " + n;
}

Console.WriteLine(NaturalNum(5, 20));