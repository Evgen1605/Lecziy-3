//Напишите программу, которая принимает 
//на вход число N и выдаёт количество цифр в числе.

Console.Clear();
Console.Write("Ввдите число: ");
int s = int.Parse(Console.ReadLine()!);
Console.Write($"Количество цифр = {CountNumber(s)}");

int CountNumber(int n){
  int count = 0;
  if (n < 0)
  {
    n *= (-1); // Умножил на -1 если число отрицательное
  }
  while (n > 0)
  {
    n /= 10;
    count++;
  }
  return count;
}
