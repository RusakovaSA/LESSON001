﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


int numberA = 7;

if (numberA % 2 == 0)
{
    Console.WriteLine("Ваше число является четным.");
}
else 
{
    Console.Write("Ваше число является нечечетным.");
}

