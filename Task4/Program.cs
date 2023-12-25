Console.Write("Введите натуральное число N: ");
int number = int.Parse(Console.ReadLine());
int lastdigit;

if (number < 10)
{
    Console.Write(number);
}
else
{
    lastdigit = number % 10;
    while (number > 0)
    {
        lastdigit = number % 10;
        Console.Write(lastdigit + ", ");
        number /= 10;
    }
}

    







