// Напишите цикл, который принимает на вход два 
// числа (А и В) и возводит А в натуральную степень В

Console.WriteLine("Введите два целых числа: ");
int [] number = Array.ConvertAll(Console.ReadLine()!.Split(),int.Parse);
/
int A = number [0];
int b = number [1];

int pow(int A, int b)
{
int t = A;
for (int i = 1; i < b; i++)
    {
      A=A*t;
    }
   return A;
}
Console.WriteLine(pow(A,b));    
