// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите число");
string input =Console.ReadLine();
char [] number = new char[input.Length];
for (int i=0; i< input.Length; i++)
   { 
    number[i]=input[i];
   }
char [] numberReverse = new char[input.Length];
for (int i=0; i< input.Length; i++)
    {
        numberReverse[i]=input[i];
    }
Array.Reverse(numberReverse);
bool equal = Enumerable.SequenceEqual(number, numberReverse);
if  (equal == true)
    Console.WriteLine("да");
else
    Console.WriteLine("нет");
