// Написать программу вычисления функции Аккермана

int m = Numbers("Введите m: ");
int n = Numbers("Введите n: ");

int Akkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {Akkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int Numbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
