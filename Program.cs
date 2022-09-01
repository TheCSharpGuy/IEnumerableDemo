
var prd = new ManageProducts();
var catalogue = prd.GetProducts();
var totProducts = catalogue.Count();

Console.WriteLine($"Total products - {totProducts}");

foreach (var product in catalogue)
{
    Console.WriteLine($"SKU: {product.SKU},\n Name: {product.Name}");
}