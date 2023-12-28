/*
Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] resultArray = new int [size];
    for (int i = 0; i < size; i++) // i < size = i < resultArray.Length
    {
        resultArray[i] = new Random ().Next(minValue, maxValue + 1);
    }
    return resultArray;
}

Console.Write("Введите количество элементов массива: "); // Введите число a
int sizeElement = Convert.ToInt32(Console.ReadLine());
int[] array = GetArray (sizeElement, 100, 999);
// интерполяция $
Console.WriteLine($"Массив: [ {String.Join("; ", array)} ]");

int numberOfEven = 0; // количество четных чисел
int numberOfOdd = 0; // количество нечетных чисел
for (int i = 0; i < array.Length; i++) // i < size = i < array.Length
{
    if (array[i] % 2 == 0)
    {
       numberOfEven += 1; 
    }
    else
       numberOfOdd += 1; 
}    
Console.WriteLine($"Количество ЧЕТНЫХ чисел массива равна : {numberOfEven}");
Console.WriteLine($"Количество НЕЧЕТНЫХ чисел массива равна : {numberOfOdd}");
