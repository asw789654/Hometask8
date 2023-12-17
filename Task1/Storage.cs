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
            if (productId >= products.Count())
            {
                Console.WriteLine($"Продукт с Id {productId} не найден");

            }
            else
            {
                Console.WriteLine(products[productId].GetInfo());
            }
        }

        public void GetProductInfoByName(string productName)
        {
            try
            {
                foreach (Product product in products)
                {
                    if (product.Name.ToLower() == productName.ToLower())
                    {
                        Console.WriteLine(product.GetInfo());
                    }
                }
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
