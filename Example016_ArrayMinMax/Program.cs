﻿// Отсортировка массива от мин к макс.

int[] arr = {1,5,4,9,6,3,7,1,1};
 
void PrintArray(int[]array)
{
    int count = array.Length;
    for(int i =0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} 

/* PrintArray(arr); */

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1 ; i++)
    {
        int minPosition = i;
        
        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);






