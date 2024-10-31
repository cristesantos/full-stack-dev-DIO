using cSharpFundamentals.Models;

//Create classes
Person person1 = new Person();

person1.Name = "Cris";
person1.Age = 37;
person1.Presentation();

//Use DateTime structure

DateTime currentTime = DateTime.Now;
Console.WriteLine("Current time: " + currentTime);

DateTime oneWeek = DateTime.Now.AddDays(7);
Console.WriteLine("Date time in one week: " + oneWeek);

//Math operations
Calculator calc = new Calculator();

int a = 10, b = 2;
calc.Sum(a, b);
calc.Sub(a, b);
calc.Mul(a, b);
calc.Div(a, b);
calc.Power(a, b);

Console.WriteLine("Type a letter");
string letter = Console.ReadLine();

//Switch case

switch (letter)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("Vowel");
        break;
    default:
        Console.WriteLine("Not a vowel");
        break;
}

//Loop FOR
int index = 5;
for(int count = 0; count <= 10; count++)
{
    Console.WriteLine($"{index} x {count} = {index * count}");
}



