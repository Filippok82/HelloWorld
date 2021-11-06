// Метод 1
void Method1()
{
    Console.WriteLine("Автор ");
}
/* Method1(); */


// Метод 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
/*   Method2("Какой-то текст");  */

// Метод 2+1

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
/* Method21("Какой-то текст", 5);   */
/* Method21(count: 5, msg: "Текст вид метода 2");  
  */
 // Метод 3
 
int Method3()
{
   return DateTime.Now.Year;
} 
int year = Method3();
/* Console.WriteLine(year); */


// Метод 4
 
string Method4(int count, string text)
{
   int i = 0;
   string result = String.Empty;

   while(i<count)
   {
       result = result + text;
       i++;
   }  
   return result;
} 
string res = Method4(10, "z");
Console.WriteLine(res);

