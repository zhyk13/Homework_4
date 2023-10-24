// Программа, которая задаёт массив из 8 элементов
// и выводит их на экран.

int[] FillArray()
{
    Console.Write("Введите кол-во элементов массива: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] arr = new int[num];
    Console.Write("Введите максимальный элемент массива: ");
    int MaxNum = Convert.ToInt32(Console.ReadLine());
    // for (int i = 0; i <= num; i++)
    // {
    //    arr[i] = new Random().Next(0,MaxNum + 1);
    // }
    return arr;
    return num;
}

// void PrintArray(int[] PrArr, int Length)
// {  Console.Write("[");
//    for (int i = 0; i < length-1; i++)
//     {
//         Console.Write($"{PrArr[i]}, ");
//     }
//     Console.WriteLine($"{PrArr[length-1]}]");
// }

int[] array = FillArray();
// PrintArray(array, num);




