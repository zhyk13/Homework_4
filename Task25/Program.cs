// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// ПОКА НАПИСАНА ФУНКЦИЯ ВВОДА ВЕЩЕСТВЕННОГО ЧИСЛА С ПРОВЕРКОЙ НА
// НА КОРРЕКТНОСТЬ ВВОДА


double InputDouble(string name)
{
    Console.Write($"Введите число {name}: ");
    if (double.TryParse(Console.ReadLine(), out double number))
    {
        Console.WriteLine($"А = {number}");
    }
    else
    {
        Console.WriteLine("Ошибка! Введите число");
    }
    return number;
}



double A = InputDouble("A");
double B = InputDouble("B");



//double A = Convert.ToDouble(Console.Read());




