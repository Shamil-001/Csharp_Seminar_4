// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNum(int A)
{
    int sum = 0;
    for (int i = 0; i < A; i++)
    {
        sum += A % 10;
        A /= 10;
    }
    return sum;
}

void PrintSum(int A, int sum)
{
    System.Console.Write($"Сумма цифр в числе {A} равна {sum}");
}
int num = ReadInt("Введите число: ");
int sum = SumNum(num);
PrintSum (num, sum);