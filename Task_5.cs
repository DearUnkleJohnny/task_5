// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




int[] CreateRandomArray(int minValue = 100, int maxValue = 999)
{
    int[] myArray = new int[6];
    for (int i = 0; i < 6; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ShowEvenNumbers(int[] array)
{
    int EvenNum = 0;
    int NoEvenNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int x = array[i] % 2;
        if (x == 0) EvenNum++;
        else
        {
            NoEvenNum++;
        }
    }
    Console.WriteLine($"-> {EvenNum}");
}

int[] newArray = CreateRandomArray();
ShowArray(newArray);
ShowEvenNumbers(newArray);




//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//




// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0




int[] CreateRandomArray(int minValue = 10, int maxValue = 99)
{
    int[] myArray = new int[6];
    for (int i = 0; i < 6; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue);
    }
    return myArray;
}

void ShowArray(int[] array)
{
    Console.WriteLine("Полученный массив:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void ShowSum(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum = sum + array[i];
    }
    Console.WriteLine($"-> {sum}");
}

int[] newArray = CreateRandomArray();
ShowArray(newArray);
ShowSum(newArray);




//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//--//




// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76




double[] array = new double[5] { 13.12, 45.34, 3.34, 65.2, 22.12 };

double max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (max < array[i])
    {
        max = array[i];
    }
}

double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (min > array[i])
    {
        min = array[i];
    }
}

double sum;
sum = max - min;

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "|");
}
Console.WriteLine($" -> {sum}");