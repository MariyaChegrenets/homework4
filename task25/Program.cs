// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Input number 1: ");
// double a = Convert.ToDouble(Console.ReadLine());
// Console.Write("Input number 1: ");
// double b = Convert.ToDouble(Console.ReadLine());
// double result = Math.Pow(a,b);
// Console.WriteLine("Result: "+result);

Console.Write("Input number 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number 1: ");
int b = Convert.ToInt32(Console.ReadLine());
int Pow (int a, int b)
{
    int result = a;
    for(int i = 2; i<=b; i++)
    {
        result *= a;
    }
    return result;
}
Console.WriteLine("Result: "+Pow(a,b));