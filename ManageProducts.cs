public class ManageProducts
{
    public IEnumerable<Product> GetProducts()
    {
        int count = 10;
        for (int i = 0; i < count; i++)
        {
            yield return new Product()
            {
                ID = i,
                SKU = $"SKU_{i}",
                Name = $"Name {i}",
                MfgName = $"Mfg by {i}",
                Cost = i * 23.00,
                IsPerishable = i % 2 != 0
            };
        }
    }
}

