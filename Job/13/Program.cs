﻿/*
Задача 13: 
Напишите программу, 
которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
Console.WriteLine("Введите число...");
int num = int.Parse(Console.ReadLine());


if (num < 100)
{
    Console.WriteLine("третьей цыфры нет...");
}
else
{
    while (num > 999)
    {
        num = num / 10;
    }
    if (num < 999)
    {
        num = num % 10;
        Console.WriteLine("Третья цыфра заданного числа равна..\n" + num);
    }
}
