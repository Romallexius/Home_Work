/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(a > b ? "Первое число больше второго" : "Второе число больше первого");


/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. (Сравнить с каждым)

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

*/

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) 
    max = a;
if (b > a) 
    max = b;
if (c > b)
    max = c;    
Console.Write("max = ");
Console.WriteLine(max);

/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/


int a;
Console.WriteLine("введите число: ");
a = Convert.ToInt32(Console.ReadLine());  
if (a % 2 == 0)
{
Console.WriteLine("четное число");           
}
else
{
Console.WriteLine("нечетное");}





/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + " ");
        evenNumber = evenNumber + 2;
    }
}