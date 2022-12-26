// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int arrayLength, int minNumber, int maxNumber)
{
    int[] array = new int [arrayLength];
    for(int i=0; i<arrayLength; i++)
    {
        array[i] = new Random().Next(minNumber, maxNumber+1); 
    }
return array;
}

int SumNotEvenNumbers(int[] arr)
{
    int sum = 0;
    int arrLength = arr.Length;
    for(int i = 0; i<arrLength; i++)
    {
        if (i%2 > 0) sum = sum + arr[i];
    }
return sum;   
}

int[] array = CreateArray(4,-100,100);
int result = SumNotEvenNumbers(array);
Console.WriteLine($"[{string.Join(",",array)}]->{result}");
