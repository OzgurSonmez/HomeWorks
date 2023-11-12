// See https://aka.ms/new-console-template for more information

// if conditions
var number = 10;
if (number == 10)
{
    Console.WriteLine("Number is 10");
}
else if (number == 20)
{
    Console.WriteLine("Number is 20");
}
else
{
    Console.WriteLine("Number is not 10 or 20");
}

Console.WriteLine(number == 10 ? "Number is 10" : number == 20 ? "Number is 20" : "Number is not 10 or 20");

// Switch Block

switch (number)
{
    case 10:
        Console.WriteLine("Number is 10");
        break;
    case 20:
        Console.WriteLine("Number is 20");
        break;
    default:
        Console.WriteLine("Number is not 10 or 20");
        break;
}

// Demo

var number2 = 200;

if (number2 >= 0 && number2 <= 100)
{
    Console.WriteLine("Number is between 0 - 100");
}
else if (number2 > 100 && number2 <= 200)
{
    Console.WriteLine("Number is between 101 - 200");
}
else if (number2 > 200 || number2 < 0)
{
    Console.WriteLine("Number is less than 0 or greater thar 200");
}

// Nested If

number2 = 55;
if (number2 < 100)
{
    if (number2 >= 90)
    {
        Console.WriteLine("Number is between 90 - 99");
    }
    else if (number2 >= 50 && number2 <90) 
    {
        Console.WriteLine("Number is between 50 - 89");
    }
    else 
    {
        Console.WriteLine("Number is less than 50");
    }
}

Console.ReadLine();