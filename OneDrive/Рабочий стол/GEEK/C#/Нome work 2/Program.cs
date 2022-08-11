
//      Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Console.WriteLine($" введите 3-х значное число: ");
// string number = Console.ReadLine();
// Console.WriteLine("Вторая цифра числа: " + number [1]);

//  Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


// Console.WriteLine(" Введите число: ");
// string inputString = Console.ReadLine();


// if (inputString.Length == 1)
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// if (inputString.Length == 2)
// {
//     Console.WriteLine("Третьей цифры нет");
// }

// if (inputString.Length >=3)
// {

//     Console.WriteLine("Третья цифра числа: " + inputString[2] );

// }

// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine(" Введите цифру из диапазона 1-7: ");
int Digit = Convert.ToInt32(Console.ReadLine ());
if (Digit==1)
{
    Console.WriteLine("нет");
}
if (Digit==2)
{
    Console.WriteLine("нет");
}
if (Digit==3)
{
    Console.WriteLine("нет");
}
if (Digit==4)
{
    Console.WriteLine("нет");
}
if (Digit==5)
{
    Console.WriteLine("нет");
}
if (Digit==6)
{
    Console.WriteLine("да");
}
if (Digit==7)
{
    Console.WriteLine("да");
}

else
{
    Console.WriteLine("Ошибка ввода-соблюдай диапазон ввода!");
}
