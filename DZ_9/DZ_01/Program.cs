// Показать натуральные числа от N до 1, N задано

string NaturalNum(int n)
     {
         if (n == 1)
     {
         return "1";
     }
        return n + " " + NaturalNum(n - 1);
     }

 Console.WriteLine(NaturalNum(10));
