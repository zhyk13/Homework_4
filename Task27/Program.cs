﻿// Программа принимает на вход число
// и выдаёт сумму цифр в числе.
int InputInt(string name) // Функция вводит целое число
                        // с проверкой на корректность ввода.
{
    Console.Write($"Введите число {name}: ");
    if (int.TryParse(Console.ReadLine(), out int numberII))
    {
        Console.WriteLine($"А = {numberII}");
    }
    else
    {
        Console.WriteLine("Ошибка! Введите число");
    }
    return numberII;
}

int SumNum(int numberSN) // Функция считает сумму цифр в числе.
{
    int resultSN = 0;
   while ( numberSN >= 9)
   {
    resultSN += numberSN %10;
    numberSN /= 10;
   } 
   resultSN += numberSN;
   return resultSN;
}

int number = InputInt(" ");
int result = SumNum(number);
Console.WriteLine($"Сумма цифр в числе = {result}");
