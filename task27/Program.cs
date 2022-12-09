// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Console.Write("Input number : ");
// int number = Convert.ToInt32(Console.ReadLine());

int number = new Random().Next();
Console.WriteLine(number);
 
int Sum (int number)
{
    int sum = 0;
    while (number > 0)
    {
        int a = number % 10;
        number = number / 10;
        sum = sum + a;
    }
    return sum;
}

Console.WriteLine("Сумма цифр в числе = "+Sum(number));