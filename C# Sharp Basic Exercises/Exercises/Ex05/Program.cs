Console.WriteLine("Input the first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input the second number:");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("--------Before Swapping--------");
Console.WriteLine($"First Number: {number1}");
Console.WriteLine($"Second Number: {number2}");
(number1, number2) = (number2, number1);
Console.WriteLine("--------After Swapping--------");
Console.WriteLine($"First Number: {number1}");
Console.WriteLine($"Second Number: {number2}");