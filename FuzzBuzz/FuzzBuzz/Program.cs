using FuzzBuzz.Interfaces;
using System.Reflection;

Console.WriteLine("Welcome to Fuzz Buzz Number encoder");
var engine = Assembly.GetExecutingAssembly().CreateInstance("FuzzBuzz.BL.FuzzBuzzGame") as IFuzzBuzzGame;
if (engine == null)
{
    throw new Exception("Unable to find FuzzBuzz game engine");
}

var done = false;
while (!done)
{
    Console.WriteLine();
    Console.WriteLine("Enter number list delimited by a space, or press return to exit");
    var numberString = Console.ReadLine();
    if (string.IsNullOrEmpty(numberString))
    {
        done = true;
    }
    else
    {
        var numbers = numberString.Split(' ')
            .Select(ns =>
            {
                var n = 0;
                int.TryParse(ns, out n);
                return n;
            })
             .ToList();
        Console.WriteLine(engine.GetTextForNumberEnumerable(numbers));
    }
}


