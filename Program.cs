/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3

Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8 
*/

// Задача 2
/*
Console.Clear();
System.Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(System.Console.ReadLine());
if (numberA > numberB){
    System.Console.WriteLine($"max = {numberA}");
} else{
        System.Console.WriteLine($"max = {numberB}");
}

*/
// Задача 4
Console.Clear();
System.Console.Write("Введите число А: ");
int numberA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите число С: ");
int numberС = Convert.ToInt32(System.Console.ReadLine());
int max = 0;
if (numberA > max){
    max = numberA;
}
if (numberB > max){
    max = numberB;
}
if (numberС > max){
    max = numberС;
}
System.Console.WriteLine($"max = {max}");

// Задача 6



// Задача 8
