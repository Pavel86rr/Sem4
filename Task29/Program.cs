//Задача 29. Напишите программу, которая залает массив 
//-из 8 элементов и выводит их на экран

int[] array = new int[8];
Random rand = new Random();

for( int i = 0; i < array.Length; i ++)
{
    array[i] = rand.Next(0,11);
}

Console.WriteLine(string.Join(" ", array));

string[] array1 = new string[]{"ahh","b","c","d12","e","i","g","m"};



Console.WriteLine(string.Join(" ", array1));