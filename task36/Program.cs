// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int GetSumm (int[] array)
{
    int summa = 0;
    for (int i=0; i < array.Length-1; i++)
    {
        summa += array[i];
    return summa;
    }   
}

int len = GetNumber("Длина массива: ");
int[] massiv = GenerateArray(len);
PrintArray(massiv);
Console.WriteLine($" -> {GetSumm(massiv)}");