//Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования.

Console.Clear();
int[] array = GetArray(10, 0, 10);
Console.WriteLine($"[{String.Join(", ", array)}]"); //Выводим случайный массив

Console.WriteLine($"Скопированный массив [{String.Join(", ", CopyArray(array))}]");


int[] GetArray(int size, int minValue, int maxValue)// функция для заполнения массива случайными числами
{
  int[] res = new int[size];// объявляем массив

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);// заполняем массив рандомными числами
  }
  return res;
}


int[] CopyArray(int[] inArray)
{
  int[] result = new int[inArray.Length];// создали массив целых чисел на тоже кол-во элементов что и массив который заполница случайными числами
  for (int i = 0; i < inArray.Length; i++)// циклом проходим по массиву
  {
    result[i] = inArray[i];// на каждой итерации поочерёдно записывем в наш массив для результата
  }
  return result;// возвращаем скопированный массив
}