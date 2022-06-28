//Задача 2. Напишите программу, которая на вход принимает два числа и выдает, 
//какое число большее, а какое меньшее.
/*
int num1, num2;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.Write(num1 + " больше чем " + num2);
}
else
{
Console.Write(num2 + " больше чем " + num1);
}


//Задача 4. Напишите программу, которая принимает на вход три числа и выдает
//максимальное.

int num1, num2, num3, max;

Console.Write("Input a first number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
num3 = Convert.ToInt32(Console.ReadLine());

max = num1;
if(num2 > max)
max = num2;
if(num3 > max)
max = num3;
{
    Console.Write(max);
}


//Задача 6. Напишите программу, которая на вход принимает число и выдает, 
//является ли число чётным?

int num;

Console.Write("Введите любое целое число  ");
num = Convert.ToInt32(Console.ReadLine());
if(num % 2 == 0)
{
    Console.Write("Число является чётным.");
}    
else
{
    Console.Write("Число нечётное.");
}
*/


//Задача 8. Напишите программу, которая на вход принимает число (N),
//а на выходе показывает все чётные числа от 1 до N.

int n, current;

Console.Write("Введите любое целое положительное число  ");
n = Convert.ToInt32(Console.ReadLine());

current = 0 + 2;
    while(current <= n && current > 0)
    {
    Console.Write(current + " ");
    current = current + 2;
    }
