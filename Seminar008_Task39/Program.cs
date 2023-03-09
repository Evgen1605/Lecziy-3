// Задача 39: Напишите программу, которая перевернёт одномерный 
// массив (последний элемент будет на первом месте, а первый - на 
// последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


Console.Clear();

int[] array = GetArray(10, 0, 10);
Console.WriteLine($"[{String.Join(", ", array)}]"); //Выводим случайный массив
Console.WriteLine($"[{String.Join(", ", ArrayRevers1(array))}]");

ArrayRevers2(array);
Console.WriteLine($"[{String.Join(", ", array)}]");


int[] GetArray(int size, int minValue, int maxValue)// функция для заполнения массива случайными числами
{
  int[] res = new int[size];// объявляем массив

  for (int i = 0; i < size; i++)
  {
    res[i] = new Random().Next(minValue, maxValue + 1);// заполняем массив рандомными числами
  }
  return res;
}

// переворачиваем массив 1 способом
int[] ArrayRevers1(int[] inArray)// функция на вход принимает массив 
{

  int[] result = new int[inArray.Length];// создаём массив на длину массива
  for (int i = 0; i < inArray.Length; i++)// циклом перебираем все элементы массива
  {
    result[i] = inArray[inArray.Length - 1 - i];// result[i]- записываем массив элементов, которые находятся с конца массива
  }
  return result;// возвращаем маассив после прохождения всего цикла
}

// переворачиваем массив 2 способом он ничего не возвращает, но меняет массив
void ArrayRevers2(int[] inArray){

  for (int i = 0; i < inArray.Length / 2; i++) //Перебераем массвив до середины потому что если бы дошли до середины, он опять бы переворачивал его обратно [1,2,3,4]
  {
    int k = inArray[i];// в переменную сначала записываем 1 элемент индекс[0] k=1
    inArray[i] = inArray[inArray.Length - 1 - i];// записываем последний элемент индекс[3] меняем первый и последний элементы 
    inArray[inArray.Length - 1 - i] = k;// записываем в переменную последний элемент k=4 

//  (inArray[inArray.Length - 1 - i], inArray[i]) = (inArray[i], inArray[inArray.Length - 1 - i]);//короткая запись
  }
}
