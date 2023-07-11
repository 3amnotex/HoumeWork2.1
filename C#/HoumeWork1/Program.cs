// Task 1. Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.


int CutNumber(int number)
{
    int dozens = number / 10;
    int unit = dozens %10;
    int result = unit;
    return result; 
}
int randNumber = new Random().Next(100, 1000);
int newNumber = CutNumber(randNumber);
Console.WriteLine($"Введенное число  {randNumber} и вторая цифра {newNumber}");


// Task 2. Напишите программу, которая выводит третью цифру заданного числа

int cutThirdDigit(int number)
{
    while (number >= 1000)
    {
        number = number / 10;
    }
        int result = number % 10;
        return result;
}

int randNumber= new Random().Next(0,1000000);
// Console.WriteLine("Введите число не меньше трех знаков: ");
// int randNumber = Convert.ToInt32(Console.ReadLine());
 while (randNumber <100)   
    {
    Console.WriteLine("Введено некорректное число");
    Console.WriteLine("Введите корректное число: ");
    randNumber = Convert.ToInt32(Console.ReadLine());
    }
    int newNumber = cutThirdDigit(randNumber);
        
Console.WriteLine($"Введенное число {randNumber} и третья цифра {newNumber}");

// Task 3. Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int daysWeek(int i)
{
    {
        if (i<=5) Console.WriteLine("Рабочий день - ");
        else Console.WriteLine("Выходной день - ");
    }
    if (i==1) Console.WriteLine("Понедельник");
    if (i==2) Console.WriteLine("Вторник");
    if (i==3) Console.WriteLine("Среда");
    if (i==4) Console.WriteLine("Четверг");
    if (i==5) Console.WriteLine("Пятница");
    if (i==6) Console.WriteLine("Суббота");
    if (i==7) Console.WriteLine("Воскресенье");
    return i;
}

int randNumber = new Random().Next(1, 8);
// Console.WriteLine("Введите число: ");
// int randNumber = Convert.ToInt32(Console.ReadLine());
int newNumber = daysWeek(randNumber);

 Console.WriteLine("Введенное число " + newNumber);
