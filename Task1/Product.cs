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
            get { return name; }
            set { name = value; }
        }

        public string ShopName
        {
            get { return ShopName; }
            set { ShopName = value; }
        }

        public int Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
