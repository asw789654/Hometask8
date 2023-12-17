namespace Task1
{
    internal class Product
    {
        private string name, shopName;
        private int cost;

        public Product(string name, string shopName, int cost)
        {
            this.name = name;
            this.shopName = shopName;
            this.cost = cost;
        }

        public string GetInfo()
        {
            return $"Товар: {name}{Environment.NewLine}Магазин: {shopName}{Environment.NewLine}Стоимость: {cost}{Environment.NewLine}";
        }

        public string Name
        {
            get
            {
                if (name != null)
                {
                    return name;
                }
                else
                {
                    return ShopName;
                }
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    name = ShopName;
                }
            }
        }

        public string ShopName
        {
            get
            {
                if (shopName != null)
                {
                    return ShopName;
                }
                else
                {
                    return "Название не указано";
                }
            }
            set
            {
                if (value != null)
                {
                    name = value;
                }
                else
                {
                    name = "Название не указано";
                }
            }
        }

        public int Cost
        {
            get
            {
                if (cost == 0)
                {
                    Console.WriteLine("Цена не указана");
                    return 30;
                }
                else
                {
                    return cost;
                }
            }
            set
            {
                if (cost == 0)
                {
                    Console.WriteLine("Цена не указана");
                    cost = 30;
                }
                else
                {
                    cost = value;
                }
            }
        }
    }
}
