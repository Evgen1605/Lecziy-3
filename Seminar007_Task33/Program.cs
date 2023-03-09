// Задача 33: Задайте массив.Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив[6, 7, 19, 345, 3]->нет
// 3; массив[6, 7, 19, 345, 3]->да

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string elements = Console.ReadLine()!;// считываем строку, введённую пользователем
int[] baseArray = GetArrayFromString(elements);// в массив записываем действие функции GetArrayFromSpring()

Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);// пользователь вводит искомое число

if (FindElement(baseArray, n))// в функцию FindElement- первы аргуметом кладём массив, а вторым искомое число, проверяем если функция FindElement возвращает true
{
  Console.WriteLine($"Число {n} есть в массиве [{String.Join(", ", baseArray)}]");// выводим в косоль
}
else
{
  Console.WriteLine($"Числа {n} нет в массиве [{String.Join(", ", baseArray)}]");//если false
}



int[] GetArrayFromString(string stringArray)// функция переводит из строки в массив чисел функция возвращает массив, а на вход принимает строку которую ввёл пользователь
{
  string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);// метод .Split обратная методу .Join, если Join- объеденяет массив, то Split- разоединяет, создали массив строк, разоединили его по пробелу (" ",) и записали его в переменную nums
  int[] res = new int[nums.Length];// чтобы работать с числами нужно строку конвертировать в числа, здесь создаём массив вкоторый кладём длинну массива int[nums.Length]
  for (int i = 0; i < nums.Length; i++)// запускаем цикл на длину массива 
  {
    res[i] = int.Parse(nums[i]);// переводим в массив в числа используя int.Parse(nums[i])  записываем их на ту же позицию
  }
  return res;// выводим результат
}

bool FindElement(int[] array, int el)// функция ищет наш элемент и возвращает или true или false на вход принимает массив и элемент массива например [1,2,3,4] 5
{
  foreach (var item in array)// перебираем массив, в первой итерации берём 0 элемент массива (1), вторая итерация берём (2), берём (3) и т.д до конца массива
  {
    if (el == item) //сравнеиваем 1==5 нет, сравниваем 2==5 нет, сравниваем 3==5 и т.д
      return true;
  }
  return false;// е найдя искомую 5 в массиве, возвращаем false
}


