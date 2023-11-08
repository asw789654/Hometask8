using Task2;

string devider = "----------------------------------------"; //проверки
Bus bus = new Bus(4, 40);
bus.EnterBas("Стив");
Console.WriteLine(devider);
List<string> newPassengers = new List<string>() { "Боб", "Женя" };
bus.EnterBas(newPassengers);
Console.WriteLine(devider);
List<string> morePassengers = new List<string>() { "Слава", "Лера" };
bus.EnterBas(morePassengers);
Console.WriteLine(devider);
foreach (var seat in bus.Seats)
{
    Console.WriteLine($"Кресло {seat.Key + 1}: {seat.Value}");
}
Console.WriteLine(devider);
bus.OutBas(newPassengers[0]);
Console.WriteLine(devider);
foreach (var seat in bus.Seats)
{
    Console.WriteLine($"Кресло {seat.Key + 1}: {seat.Value}");
}
Console.WriteLine(devider);
bus.OutBas(newPassengers);
Console.WriteLine(devider);
foreach (var seat in bus.Seats)
{
    Console.WriteLine($"Кресло {seat.Key + 1}: {seat.Value}");
}
Console.WriteLine(devider);
bus.ChangeSpeed(30);
bus.ChangeSpeed(-10);
bus.ChangeSpeed(40);
bus.ChangeSpeed(-100);