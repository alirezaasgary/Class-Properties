// See https://aka.ms/new-console-template for more information
using Class_Properties;


CarModel car1 = new CarModel("pride", "1900", "green");
CarModel car2 = new CarModel("vbjanet", "2000", "blue");

Console.WriteLine($"{car1.Name} - {car1.Color}");
Console.WriteLine($"{car2.Name} - {car2.Color}");


Console.ReadKey();
