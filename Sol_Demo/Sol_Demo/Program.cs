// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//https://www.stevejgordon.co.uk/using-dateonly-and-timeonly-in-dotnet-6

// DateOnly
var currentDate = DateOnly.FromDateTime(DateTime.Now);
Console.WriteLine(currentDate);

// TimeOnly
var currentTime = TimeOnly.FromDateTime(DateTime.Now);
Console.WriteLine(currentTime);