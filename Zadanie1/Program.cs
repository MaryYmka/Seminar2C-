//Напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшую цифру числа

int number = GetNumber(); // Выдаем ранндомное чило
Console.WriteLine(number);// Выводим рандомное число

int num1 = number / 10; //получаем 1 число например, 78 / 10 =7
int num2 = number % 10; // получаем 2 число, 78 % 10 = 8

if (num1 > num2)
{
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine(num2);
}

int GetNumber() //Рандом
{
    Random rand = new Random();
    int num = rand.Next(10, 100);

    return num;
}