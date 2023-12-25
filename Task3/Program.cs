// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.


Console.Write("Enter a number: ");
int a = int.Parse(Console.ReadLine());
int firstDigit;
int secondDigit;

if (10 <= a && a <= 99)
{
   firstDigit = a / 10;
   secondDigit = a % 10;
   if (firstDigit == secondDigit)
   {
    Console.WriteLine("Число " +firstDigit+ " равно числу "+ secondDigit);
   }
   else
   if (firstDigit > secondDigit)
   Console.WriteLine("Число " +firstDigit+ " больше чем число " +secondDigit);
   else
   {
    Console.WriteLine("Число " +secondDigit+ " больше чем число " +firstDigit);
   }
}
else 
{
Console.WriteLine("Условие не выполняется");
}
