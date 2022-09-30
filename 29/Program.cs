int getNumberFromUser()
{
    int result = 0;
    while (!int.TryParse(Console.ReadLine(), out result) || (result < 1 ))
    {
        Console.WriteLine($"Введите натуральное число.");
    }
    return result;
}

void printArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length-1; i++)
    {
        Console.Write($"{array[i]},");
    }
    Console.Write($"{array[array.Length-1]}");
    Console.Write("]");
}

Console.WriteLine($"Введите длину массива");
int arrayLength = getNumberFromUser();
int[] array = new int[arrayLength];
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 100);
}
printArray(array);