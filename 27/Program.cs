int getSumOfDigit(int userNumber)
{
    int result = 0;
    for(int tempNumber = Math.Abs(userNumber); tempNumber > 0; tempNumber = tempNumber/10)
    {
        result = result+tempNumber%10;
    }
    return result;
}

Console.WriteLine($"Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfDigit = getSumOfDigit(userNumber);
Console.WriteLine($"Сумма цифр числа равна {sumOfDigit}");