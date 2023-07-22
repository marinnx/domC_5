// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int GetNumber (string message)
{
    System.Console.Write(message);
    int inputNum = Convert.ToInt32(Console.ReadLine());
    return inputNum;
}

int[] GenerateArray (int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 1000);
    }
    return array;
}

void PrintArray (int[] array)
{
    System.Console.Write("[]");
    for (int i=0; i < array.Length-1; i++)
    {
        System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write($"{array[array.Length-1]}");
    System.Console.Write("]");
}

int GetCount (int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length-1; i++)
    {
        if (array[i] % 2 == 0)
        {
            count += 1;
        }
    return count;
    }   
}

int len = GetNumber("Длина массива: ");
int[] massiv = GenerateArray(len);
PrintArray(massiv);
Console.WriteLine($" -> {GetCount(massiv)}");

