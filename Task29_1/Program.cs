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

int[] array = FillArray();


Console.Write("[");
for (int i = 0; i < array.Length-1; i++)
{
    Console.Write($"{array[i]}, ");
}
Console.WriteLine($"{array[array.Length-1]}]");
