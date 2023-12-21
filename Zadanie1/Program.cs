//Напишите программу, которая выводит случайное число из отрезка [10, 99]
//и показывает наибольшую цифру числа

int number = GetNumber();
Console.WriteLine(number);

int num1 = number / 10; //получаем 1 число
int num2 = number % 10; // получаем 2 число

if (num1 > num2)
{
    System.Console.WriteLine(num1);
}
else
{
    System.Console.WriteLine(num2);
}

int GetNumber()
{
    Random rand = new Random();
    int num = rand.Next(10, 100);

    return num;
}