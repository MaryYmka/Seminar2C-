//Напишите программу, которая выдает 3х значное число и удалет 2е.

int number = new Random(). Next(100, 1000); //Получаем трехзначное число
Console.WriteLine(number);
int num1 = number / 100;
int num2 = number % 10;

int result = num1 * 10 + num2;
Console.WriteLine(result);

