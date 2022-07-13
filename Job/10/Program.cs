/*
Задача 10: 
Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает 
вторую цифру этого числа.
*/

while(true)
{
    Console.WriteLine("Введите трёх значное число... ");
    int num = int.Parse(Console.ReadLine());

    if (num < 100)
    {
        Console.WriteLine("Вы ввели неправильное число, \nпопробуйте снова!!! \n");
    }
    else if (num > 999)
    {
        Console.WriteLine("Вы ввели неправильное число, \nпопробуйте снова!!! \n");
    }
    else
    {
        int num3 = num / 10;
        int num2 = num3 % 10;
        Console.WriteLine("Вторая цыфра трёхзначного числа равна... ");
        Console.WriteLine(num2);
        break;
    }
}

