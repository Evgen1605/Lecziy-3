//Напишите программу, которая принимает 
//на вход число N и выдаёт количество цифр в числе.

Console.Clear();
Console.Write("Ввдите число: ");
int s = int.Parse(Console.ReadLine()!);
Console.Write($"Количество цифр = {CountNumber(s)}");// выводим в консоль

int CountNumber(int n){// создаём функцию, которая считает цифры в числе, принимает целое число и возвраает тоже целое число
  int count = 0;// счётчик начинается с 0
  if (n < 0)// делаем проверуку на отрицательное число
  {
    n *= (-1); // Умножил на -1 если число отрицательное если например -5 * -1 = 5 (получится уже положительное число)
  }
  while (n > 0)// цикл перебирает все цифры в числе  пока их больше 0 
  {
    n /= 10;// n = n / 10 убирает последнию цифру числа в каждый проход цикла
    count++;// счётчик увиличивает на 1 каждый проход 
  }
  return count;// возвращаем посчитанное числ 
}
