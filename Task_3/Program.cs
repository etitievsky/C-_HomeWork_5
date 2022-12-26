//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] CreateArray(int arrayLength, int minNumber, int maxNumber)
{
    int[] array = new int [arrayLength];
    for(int i=0; i<arrayLength; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber+1); 
    }
return array;
}

int MaxMinDiff(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    int result = 0;
    int arrLength = arr.Length;
    for(int i = 0; i<arrLength; i++)
    {
        if (arr[i] > max) max = arr[i];
        if (arr[i] < min) min = arr[i];
    }
result = max - min;
return result;   
}

int[] array = CreateArray(5,0,100);
int result = MaxMinDiff(array);
Console.WriteLine($"[{string.Join(",",array)}]->{result}");
