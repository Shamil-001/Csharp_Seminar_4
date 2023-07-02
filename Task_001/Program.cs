// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int PowInt(int A, int B)
{
    int pow = 1;

    for (int i = 1; i <= B; i++)
    {
        pow *= A;
    }
    return pow;
}
void PrintResult(int A, int B, int pow)
{
    System.Console.WriteLine($"{A} в степени {B} -> {pow}");
}

int fp = ReadInt("Введите число: ");
int sp = ReadInt("Введите множитель: ");

int pow = PowInt(fp, sp);

PrintResult(fp, sp, pow);