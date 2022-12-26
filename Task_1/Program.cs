// Задайте массив, заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArray(int arrayLength, int minNumber, int maxNumber)
{
    int[] array = new int [arrayLength];
    for(int i=0; i<arrayLength; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber+1); 
    }
return array;
}

int CountEvenNumbers(int[] arr)
{
    int count = 0;
    int arrLength = arr.Length;
    for(int i = 0; i<arrLength; i++)
    {
        if (arr[i]%2 == 0) count++;
    }
return count;   
}

int[] array = CreateArray(4,100,999);
int result = CountEvenNumbers(array);
Console.WriteLine($"[{string.Join(",",array)}]->{result}");