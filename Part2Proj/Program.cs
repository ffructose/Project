using Part2_s36444;

Console.WriteLine("------------- SUPER CALCULATOR ------------\n|");

// +
var add = new Calculator(1, 2, '+');
Console.WriteLine($"|    1 + 2 =  {add.Calculate()} \n|");

// -
var min = new Calculator(1, 2, '-');
Console.WriteLine($"|    1 - 2 =  {min.Calculate()} \n|");

// *
var mult = new Calculator(1, 2, '*');
Console.WriteLine($"|    1 * 2 =  {mult.Calculate()} \n|");

// /
var sub = new Calculator(1, 2, '/');
Console.WriteLine($"|    1 / 2 =  {sub.Calculate()} \n|");

// /0
var subZero = new Calculator(1, 0, '/');
Console.WriteLine($"|    1 / 0 =  {subZero.Calculate()} \n|");

Console.WriteLine("|___________________________________________\n");
