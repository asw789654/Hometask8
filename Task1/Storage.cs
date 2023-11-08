namespace Task1
{
    internal class Storage
    {
        private List<Product> products;

        public Storage()
        {
            products = new List<Product>();
        }


        public void AddProduct(Product product)
        {
            products.Add(product);
            Console.WriteLine($"Продукт {product.Name} добавлен"); ;
        }

        public void RemoveProduct(Product product)
        {
            if (products.Remove(product))
            {
                Console.WriteLine($"Продукт {product.Name} удалён");
            }
            else
            {
                Console.WriteLine($"Продукт {product.Name} не найден");
            }
        }

        public void GetProductInfoById(int productId)
        {
            try
            {
                Console.WriteLine(products[productId].GetInfo());
            }
            catch
            {
                Console.WriteLine($"Продукт с Id {productId} не найден");
            }
        }

        public void GetProductInfoByName(string productName)
        {
            try
            {
                Console.WriteLine(products.Find(p => p.Name.ToLower() == productName.ToLower()).GetInfo());
            }
            catch
            {
                Console.WriteLine($"Продукт с названинием {productName} не найден");
            }
        }

        public void GetStorageInfo()
        {
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].GetInfo());
            }
        }
    }
}
