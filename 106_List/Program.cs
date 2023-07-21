// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
List<string> instructors = new List<string>();
instructors.Add("Nikita");
instructors.Add("Dan");
instructors.Add("Dan");
instructors.Add("Dan");
// How to remove all Dans?

//that doesn't work
//instructors.RemoveAll("Dan");


foreach( var name in instructors)
{
    Console.WriteLine(name);
}

Car car1 = new Car();
car1.Name = "1234";
Car car2 = new Car();
car2.Name = "12354";
Car car3 = new Car();
car3.Name = "1236";
Car car4 = new Car();
car4.Name = "1237";

List<Car> cars = new List<Car>();
cars.Add(car1);
cars.Add(car2);
cars.Add(car3);
cars.Add(car4);



foreach(Car c in cars)
{
    Console.WriteLine($"car name: {c.Name}");
}


List<string> names = new List<string> { "Amy", "Nevin", "JJ" };
Console.WriteLine($"The first name in the list {names[0]}");
Console.WriteLine($"The second name in the list {names[1]}");

//Arrays

int[] numbers = { 1, 2, 3, 4, 5 };

class Car
{
    public string Name { get; set; } = "";
}

