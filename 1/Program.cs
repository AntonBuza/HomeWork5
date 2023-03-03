// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] GenArray(int size, int leftRange, int rightRange)
{
     int[] array = new int[size];
     Random random = new Random();
     for (int i = 0; i < size; i++)
     {
         array[i] = random.Next(leftRange, rightRange+1);
     }
     return array;
 }

 void PrintArray(int[] array)
 {
     Console.WriteLine("[" + string.Join(", ", array) + "]");
 }
 int CountElements(int[] array)
 {
     int count = 0;
     for (int i = 0; i < array.Length; i++)
     {
         if (array[i]%2==0)
         {  count++; }
        
     }
     return count;
 }

 var myArray = GenArray(4, 100, 999);
 PrintArray(myArray);
 Console.WriteLine(CountElements(myArray));
