Console.WriteLine($"Введите основание степени");
int userNumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите показатель степени");
int userNumberB = Convert.ToInt32(Console.ReadLine());

double getThePower(int baseNumber, int powerNumber)
{
    double result = 1;
    if(powerNumber < 0)
    {
        for(int i=1; i<=-powerNumber; i++)
        {
            result = result / baseNumber;
        }
    }
    if(powerNumber > 0)
    {
        for(int i=1; i<=powerNumber; i++)
        {
            result = result * baseNumber;
        }
    }
    return result;
}
//дробные показатели степени чёт сложновато -_-

double exponent = getThePower(userNumberA, userNumberB);
Console.WriteLine($"Результат: {exponent}");