// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GenArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(leftRange, rightRange + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}
int CountElements(int[] array)
{
    int count = array[0];
    for (int i = 1; i < array.Length; i=i+2)
    {
    
        count = count + array[i];
        
    }
    return count;
}

var myArray = GenArray(4, -100, 100);
PrintArray(myArray);
Console.WriteLine(CountElements(myArray));

