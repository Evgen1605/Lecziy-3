//28 Напишите программу, которая принимает на вход число N 
//и выдаёт произведение чисел от 1 до N.

//4-> 24
//5-> 120 == 1 * 2 * 3 * 4 * 5

Console.Clear();
Console.Write("Ввдите число: ");
int s = int.Parse(Console.ReadLine()!);

int Factorial(int count){
  int n = 1;
  for (int i = 2; i <= count; i++)
  {
    n *= i;
  }
  return n;
}
Console.WriteLine($"Произведение {s} -> {Factorial(s)}");