// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[] array, int leftRange, int rightRange)
{
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }
}
void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(" | ", array) + "]");
}

int length = ReadInt("Введите размер массива: ");
int min = ReadInt("Введите наименьшее число в массиве: ");
int max = ReadInt("Введите наибольшее число в массиве: ");
int[] array = new int[8];
FillArray(array, min, max);
PrintArray(array);