// 1.Найти позицию минимального элемента
// в неотсортированной части массива
// 2. Произвести обмен этого значения со
// значением первой неотсортированной позиции
// 3. Повторять пока есть не отсортированные
// элементы

int[] arr = {5,6,8,6,7,5,2,1,4,1,3,9};

void PrintArray(int[] array){

  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{arr[i]} ");
  }
  Console.WriteLine();
}
void SelectionSort(int[] array){

  for (int i = 0; i < array.Length - 1; i++)
  {
    int minPosition = i;

    for (int j = i + 1; j < array.Length; j++)
    {
      if (array[j] < array[minPosition])  // если знак < заменить > то будет скать от большего к меньшему 
      {
        minPosition = j;
      }
    }

    int temporary = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temporary;
  }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);