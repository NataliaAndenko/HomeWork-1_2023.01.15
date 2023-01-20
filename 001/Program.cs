/*1: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/
Console.Write("Введите трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine()); //int.Parse(Console.ReadLine());
int b = a%100;
int c = b/10;
Console.Write($"Вторая цифра числа = " + c);
