﻿// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Напишите пятизначное число");
string str = Console.ReadLine();

if (str.Length == 5)
{
    if (str[0] == str[4])
    {
        if(str[1] == str[3])
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }
    }
    else
    {
        Console.WriteLine("Нет, число не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Неправильное число, попробуйте еще раз!");
}

