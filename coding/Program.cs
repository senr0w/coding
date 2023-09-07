БУсов

using System;

class program
{
    static void Main(string[] args)
    {
        double amount = 1;
        double exchangeRate = 101.6;
        string dollar = "USD";
        string rubl = "RUB";
        double convertamount = ConvertCurrency(amount, dollar, rubl, exchangeRate);
        Console.WriteLine($"{amount} {dollar} равно {convertamount} {rubl}.");
    }
    static double ConvertCurrency(double amount, string dollar, string rubl, double exchangeRate)
    {
        if (dollar == rubl)
        {
            return amount;
        }
        double convertamount = amount * exchangeRate;
        return convertamount;
    }
}

Демакова

using System;
class program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        bool isPrime = CheckPrime(number);
        if (isPrime)
            Console.WriteLine(number + "-простое число");
        else
            Console.WriteLine(number + "-не простое число");
    }
    static bool CheckPrime(int number)
    {
        if (number <= 1)
            return false;
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }
//}
