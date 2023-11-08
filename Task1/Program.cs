using Task1;

Storage storage = new Storage(); //проверки
List<Product> list = new List<Product>()
{
    new Product("Chair","ChairShop",150),
    new Product("Table","TableShop",200),
    new Product("Door","DoorShop",300)
};

for (int i = 0; i < list.Count; i++)
{
    storage.AddProduct(list[i]);
}

storage.GetStorageInfo();
Console.WriteLine("_____________________________________");
storage.RemoveProduct(list[0]);
Console.WriteLine("_____________________________________");
storage.GetStorageInfo();
Console.WriteLine("_____________________________________");
storage.GetProductInfoById(1);
Console.WriteLine("_____________________________________");
storage.GetProductInfoById(3);
Console.WriteLine("_____________________________________");
storage.GetProductInfoByName("do");
Console.WriteLine("_____________________________________");
storage.GetProductInfoByName("Table");
Console.WriteLine("_____________________________________");
