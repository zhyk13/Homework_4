// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.



int InputInt(string name)
{
    Console.Write($"Введите число {name}: ");
    if (int.TryParse(Console.ReadLine(), out int number))
    {
        Console.WriteLine($"А = {number}");
    }
    else
    {
        Console.WriteLine("Ошибка! Введите число");
    }
    return number;
}

int Exponent(int num, int exp)
{
    int res = 1;
   for (int i = 1; i <= exp; i++)
   {
    res *= num;
   } 
   return res;
}

int A = InputInt("A");
int B = InputInt("B");
int result = Exponent(A, B);
Console.WriteLine($"А в степени В = {result}");








