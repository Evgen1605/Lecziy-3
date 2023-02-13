// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] GetArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);
  }
  return res;
}

int[] array = GetArray(6, -10, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] InversArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
    array[i] *= -1; 
  }
  return array;
}

Console.WriteLine($"[{String.Join(", ", InversArray(array))}]");