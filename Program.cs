// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// int InputNumber(string message)
// {
// string inputStatus = "Incorrect";
// int number = 0;
// while (inputStatus == "Incorrect")
// {
//     Console.Write(message);
//     number = Convert.ToInt32(Console.ReadLine());
//     if (number / 100 > 0 && number / 1000 == 0) inputStatus = "Correct";
// }
// return number;
// }

// int SecondFigureOfThree(int number)
// {
//     int last = number % 10;
//     int twoFirst = (number - last) / 10;
//     int second = twoFirst % 10;
//     return second;
// }

// Console.WriteLine(SecondFigureOfThree(InputNumber("Enter 3 digit number, please: ")));

// ******************************************************************************************

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


// int InputNumber(string message)
// // Ввод числа.
// {
//     Console.Write(message);
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int QuantityOfDigits(int number)
// // Подсчет количества символов в числе.
// {
//     int digits = 1;
//     int multy = 1;

//     while ((number / (10 * multy)) != 0)
//     {
//         multy = multy * 10;
//         digits++;
//     }
//     return digits;
// }

// int ThreeDigits(int number, int digits)
// // Возвращает первые три цифры числа.
// {
//     int index = 1;
//     int multy = 1;
//     while (index < digits - 2)
//     {
//         multy = multy * 10;
//         index++;
//     }
//     int threeDigits = number / multy;
//     return threeDigits;
// }

// int ThirdDigit(int number)
// // Возвращает последнюю цифру трехзначного числа.
// {
//     int thirdDigit = number % 10;
//     return thirdDigit;
// }

// int number = InputNumber("Enter number, please: ");
// int quantity = QuantityOfDigits(number);
// if (quantity < 3)
// {
//     Console.WriteLine("There's no third digit");
// }
// else
// {
//     int threeDigits = ThreeDigits(number, quantity);
//     int result = ThirdDigit(threeDigits);
//     Console.WriteLine($"Third digit is: {result}");
// }

// ******************************************************************************************

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


int InputNumber(string message)
// Ввод числа.
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
string WeekDay (int number)
{
    // string weekday = "The number entered is not the weekday number";

    if (number < 1 || number > 7) return "The number entered is not the weekday number";
    else
    {
        if (number == 6 || number == 7) return "Yes, that's a holiday";
        else return "No, that's not a holiday";
    } 
}

Console.WriteLine(WeekDay(InputNumber("Enter number of weekday, please: ")));
