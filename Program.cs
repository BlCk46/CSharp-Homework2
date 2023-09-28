// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

//Решение:

// void SecondDigit(int num)
// {
//     if (num < 100 || num > 999)
//     {
//         System.Console.WriteLine("You did not enter a three-digit number!");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num} -> {num / 10 % 10}");
//     }
// }

// System.Console.Write("Input three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// SecondDigit(num);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//Решение:

// void NumCondition(int num)
// {
//     if (num > 99)
//     {
//         System.Console.WriteLine($"{num} -> {ThirdDigit(num)}");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num} -> третьей цифры нет");
//     }
// }

// int ThirdDigit(int num)
// {
//     while (num > 999)
//     {
//         num /= 10;
//     }
//     return num % 10;
// }

// System.Console.Write("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// NumCondition(num);


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

//Решение:

// // bool Weekend(int num)                      //можно использовать метод bool, но тогда не будет выполняться условие задачи - "да"/"нет"
// // {
// //     if(num == 6 || num == 7)
// //     {
// //         return true;
// //     }
// //     else
// //     {
// //         return false;
// //     }
// // }

// void Check(int num)
// {
//     if(num < 1 || num > 7)
//     {
//         System.Console.WriteLine("Error! The number is not a day of the week!");
//     }
//     else
//     {
//         Weekend(num);
//     }
// }

// void Weekend(int num)
// {
//     if(num == 6 || num == 7)
//     {
//        System.Console.WriteLine($"{num} -> да"); 
//        // System.Console.WriteLine($"{num} -> {Weekend(num)}");      //относится к методу bool
//     }
//     else
//     {
//         System.Console.WriteLine($"{num} -> нет");
//         // System.Console.WriteLine($"{num} -> {Weekend(num)}");      //относится к методу bool
//     }
// }


// System.Console.Write("Input number the day of the week: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Check(num);