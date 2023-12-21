// Напишите программу, которая принемает на вход 2 числа и выводить, является ли второе чило кратное 1ому. Если число 2 не кратно 1. то программа вводит остаток от деления.

Console.WriteLine("Введите первое число:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = num1%num2;

if(num3 ==0)
{
Console.WriteLine("Кратное");
}
else
{
    Console.WriteLine($"Не кратно, остаток: {num3}");
}