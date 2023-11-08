using Task3;

ElephantBee elephantBee = new ElephantBee(20, 50);
Console.WriteLine(elephantBee.fly());
Console.WriteLine(elephantBee.ElephantPart);
Console.WriteLine(elephantBee.BeePart);
Console.WriteLine(elephantBee.Trumpet());
Console.WriteLine(elephantBee.ElephantPart);
Console.WriteLine(elephantBee.BeePart);
elephantBee.Eat("daad", 20);
Console.WriteLine(elephantBee.ElephantPart);
Console.WriteLine(elephantBee.BeePart);
elephantBee.Eat("nectar", 20);
Console.WriteLine(elephantBee.ElephantPart);
Console.WriteLine(elephantBee.BeePart);
elephantBee.Eat("grass", 60);
Console.WriteLine(elephantBee.Trumpet());
Console.WriteLine(elephantBee.ElephantPart);
Console.WriteLine(elephantBee.BeePart);
