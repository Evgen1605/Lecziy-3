// Вид 1 ничего не принимают, ничего не возвращают

void Metod1(){
  Console.WriteLine("Автор: Евгений Костромин");
}
Metod1();

// Вид 2 что-то принимают, ничего не возвращают
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


// Вид 3 ничего не принимают, что-то возвращают

int Metod3(){

  return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);


// Вид 4 что - то принимают, что - то возвращают

string Metod4(int count, string text){

  int i = 0;
  string result = "";
  while(i < count){
    result = result + text;
    i++;
  } 
  return result;
}
string res = Metod4(10, "z");
Console.WriteLine(res);