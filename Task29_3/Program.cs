/// Программа, которая задаёт массив
// и выводит его на экран.

int[] FillArray()
{
    Console.Write("Введите кол-во элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Кол-во элементов массива = {num}");
    int[] arr = new int[num];
    Console.Write("Введите максимальный элемент массива: ");
    int MaxNum = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Максимальный элемент массива = {MaxNum}");
    for (int i = 0; i < num; i++)
    {
       arr[i] = new Random().Next(0,MaxNum + 1);
    }
    return arr;
}

void PrintArray(int[] PrArr)
{
    Console.Write("[");
    for (int i = 0; i < PrArr.Length-1; i++)
    {
        Console.Write($"{PrArr[i]}, ");
    }
    Console.WriteLine($"{PrArr[PrArr.Length-1]}]");
}


int[] array = FillArray();
PrintArray(array);
