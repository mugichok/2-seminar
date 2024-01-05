// 1 задача Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Clear();
// Console.Write("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// while(x<99 || x>999)
// {
//     Console.Write("Вы ошиблись\nВведите число: ");
//     x = int.Parse(Console.ReadLine()!);
// }
// Console.WriteLine((x%100)/10);

// втоая задача Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Clear();
// Console.Write("Введите число: ");
// string number = Console.ReadLine();
// int y = number.Length;
// int x = int.Parse(number);
// x = Math.Abs(x);
// if(x<99)
//     Console.WriteLine("Третьей цифры в числе нет");
// else
// {
//     while(x>999)
//     {
//         x /= 10;
//     }
//     Console.WriteLine(x%10);
// }

// третья задача Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Clear();
// Console.Write("Введите номер дня недели: ");
// int x = int.Parse(Console.ReadLine()!);
// while(x<1 || x>7)
// {
//     Console.Write("Вы ошиблись!/nВведите номер дня недели: ");
//     x = int.Parse(Console.ReadLine()!);
// }
// if (x == 6 || x == 7)
//     Console.WriteLine("Выходной");
// else
//     Console.WriteLine("Будний день");

// четвёртая задача Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.


// Console.Clear();
// Console.Write("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// int max1 = x;
// int max2 = 0;
// while(x != 0)
// {
//     Console.Write("Введите число: ");
//     x = int.Parse(Console.ReadLine()!);
//     if(x > max1)
//     {
//         max2 = max1;
//         max1 = x;
//     }

//     else if(x > max2)
//     {
//         max2 = x;
//     }
// }
// Console.WriteLine($"Второе по величине число {max2}");
