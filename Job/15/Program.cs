/*
Задача 15: 
Напишите программу, 
которая принимает на вход цифру, 
обозначающую день недели, и проверяет, 
является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/


while(true)
{
    Console.WriteLine("Введите номер дня недели, от 1 до 7..");
    int DayWeek = int.Parse(Console.ReadLine());
    if (DayWeek > 0 && DayWeek < 8)
    {
        if (DayWeek == 1)
        {
            Console.WriteLine("понедельник");
            Console.WriteLine("Рабочий день :(");
        }
        if (DayWeek == 2)
        {
            Console.WriteLine("Вторник");
            Console.WriteLine("Рабочий день :(");
        }
        if (DayWeek == 3)
        {
            Console.WriteLine("Спеда");
            Console.WriteLine("Рабочий день :(");
        }
        if (DayWeek == 4)
        {
            Console.WriteLine("Четверг");
            Console.WriteLine("Рабочий день :(");
        }
        if (DayWeek == 5)
        {
            Console.WriteLine("Пятница");
            Console.WriteLine("Рабочий день :(");
        }
        if (DayWeek == 6)
        {
            Console.WriteLine("Суббота");
            Console.WriteLine("Выходной день!!!");
        }
        if (DayWeek == 7)
        {
            Console.WriteLine("Воскресенье");
            Console.WriteLine("Выходной день!!!");
        }
        break;
    }
    else
    {
        Console.WriteLine("такого номера дня недели не существует\nпопробуйте снова");
    }
}


