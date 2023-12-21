//Напишите программу, которая принемает число на вход и проверятет, является ли число кратным 7 и 23

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

if((num1 % 7 ==0) & (num1 % 23 ==0))
{
    Console.WriteLine("кратно");
}
else
{
    Console.WriteLine("Нет");
}