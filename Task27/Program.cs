// Задача 27. Напишите программу, которая принимает
//на вход число и выдает сумму цифр в числе
 
namespace Example 
{
class Program 
 {
    static void Main() 
  {
   Console.WriteLine("Введите число: ");
   string? number = Console.ReadLine();
   int sum = 0;
   bool point = true;
   char symbol;
   for (int i = 0; i < number.Length; ++i) 
     {
       symbol = number[i];
       if (i == 0 && symbol == '-' || symbol == '+') continue;
       if (point && symbol == '.') 
        {
          point = false;
          continue;
        }
       if (Char.IsDigit(symbol)) sum += Convert.ToUInt16(symbol.ToString());
     else break;
     }  

Console.WriteLine("Сумма цифр = " + sum);
Console.ReadKey();
   }
 }
}