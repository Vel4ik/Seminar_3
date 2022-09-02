using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите пятизначное число ");
        string number = Console.ReadLine();
        if (number[0] == number[4])
        {
            if (number[1] == number[3])
            {
                Console.WriteLine("Является палиндромом");
            }
        else Console.WriteLine("Не является палиндромом");
        }
        else Console.WriteLine("Не является палиндромом");
    }
}

