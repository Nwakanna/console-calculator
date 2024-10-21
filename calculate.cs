// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World from calculator project!");
Console.WriteLine("Input the first number:");
var firstAsText = Console.ReadLine();
var num1 = int.Parse(firstAsText);

Console.WriteLine("Input the first number:");
var secAsText = Console.ReadLine();
var num2 = int.Parse(secAsText);

Console.WriteLine("What operation do you want to perform?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

var choice = Console.ReadLine();

if (choice == "A" || choice == "a")
{
    var sum = num1 + num2;
    Console.WriteLine(num1 + " + " + num2 + " = " + sum);
} else if (choice == "S" || choice == "s")
{
    var minus = num1 - num2;
    Console.WriteLine(num1 + " - " + num2 + " = " + minus);
}else if (choice == "M" || choice == "m")
{
    var multiply = num1 * num2;
    Console.WriteLine(num1 + " * " + num2 + " = " + multiply);
}else
{
    Console.WriteLine("Invalid input!");
}

Console.WriteLine("Press any key to close");
Console.ReadKey();

