// Вид 1
void Metod1(){
  Console.WriteLine("Автор: Евгений Костромин");
}
Metod1();

// Вид 2
void Metod2(string msg){
  Console.WriteLine(msg);
}
Metod2("Текст сообщения 1");

void Metod21(string msg, int count)
{
  for (int i = 0; i < count; i++)
  {
    Console.WriteLine(msg);
  }
}
Metod21("Текст сообщения", 4);