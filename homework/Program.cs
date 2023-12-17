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
// if(x<99)
//     Console.WriteLine("Третьей цифры в числе нет");
// else
// {
//     int s = 10;
//     int result = 1;
//     int result1 =1;
//     for (int i = 0; i < y-2; i++)
//     {
//         result *= s;
//     }
//     int n = x%result;
//     for (int i = 0; i < y-3; i++)
//     {
//         result1 *= s;
//     }
//     Console.WriteLine(n/result1);
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

int[] array = { 1, 7, 9, 0 };
int length = array.Length;
int max = 0;
for (int i = 0; i < length; i++)
{
    if(array(i)>max)
    {
        max = array(i);
        maxi = i;
    }
}
static void RemoveAt(ref int[] array, int maxi)
{
    int[] newArray = new int[array.Length-1];
    for (int i = 0; i<maxi; i++)
        newArray[i] = array[i];

    for(int i = maxi +1; i < array.Length; i++)
        newArray[i-1] = array[i];
    
    array = newArray;
}

for (int i = 0; i < length-1; i++)
{
    if(newArray(i)>max)
    {
        max = newArray(i);
    }
}
Console.WriteLine(max);

