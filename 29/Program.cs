int getNumberFromUser()
{
    int result = 0;
    while (!int.TryParse(Console.ReadLine(), out result) || (result < 1 ))
    {
        Console.WriteLine($"Введите натуральное число.");
    }
    return result;
}

int[] getArray(int arrayLength)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
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

Console.WriteLine("Введите длину массива");
int arrayLength = getNumberFromUser();
//разницу кроме того что выделил в функцию не понял, буквально тот же код -_-
// int[] newArray = new int[arrayLength];
// for(int i = 0; i < newArray.Length; i++)
// {
//     newArray[i] = new Random().Next(1, 100);
// }
int[] newArray = getArray(arrayLength);
printArray(newArray);
