// Console.Clear();
// Console.Write("Введите число: ");
// int x = int.Parse(Console.ReadLine()!);
// if(x % 3==0&& x%5==0)
// {
//     Console.WriteLine("yes");
// }
// else
//     Console.WriteLine("no");

// вторая задача

// Console.Clear();
// int x = new Random().Next(10,100);
// Console.WriteLine(x);
// int x1 = x/10;
// int x2 = x%10;
// if(x1>x2)
//     Console.WriteLine($"Наибольшая цифра {x1}");
// else
//     Console.WriteLine($"Наибольшая цифра {x2}");

// Третья задача

Console.Clear();
int x = new Random().Next(99,1000);
Console.WriteLine(x);
Console.WriteLine(x/100*10+x%10);