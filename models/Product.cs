public class Product
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public required string ImageUrl { get; set; }
}

public static class ProductData
{
    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product
            {
                Name = "Dark purple grapes 1.5 kg",
                Price = 11.25m,
                ImageUrl = "/images/products/grapes.jpg"
            },
            new Product
            {
                Name = "Organic sweet tomato 1 kg",
                Price = 2.75m,
                ImageUrl = "/images/products/tomatoes.jpg"
            },
            new Product
            {
                Name = "French bread 400 g",
                Price = 13.0m,
                ImageUrl = "/images/products/bread.jpg"
            },
            new Product
            {
                Name = "Organic eggs 12 count",
                Price = 12.99m,
                ImageUrl = "/images/products/eggs.jpg"
            },
            new Product
            {
                Name = "Sweet corn 1 unit",
                Price = 5.25m,
                ImageUrl = "/images/products/corn.jpg"
            },
            new Product
            {
                Name = "Watermelon 1 unit",
                Price = 12.5m,
                ImageUrl = "/images/products/watermelon.jpg"
            },
            new Product
            {
                Name = "Organic sugar 2 packages",
                Price = 7.0m,
                ImageUrl = "/images/products/sugar.png"
            },
            new Product
            {
                Name = "Oranges 1 kg",
                Price = 4.0m,
                ImageUrl = "/images/products/oranges.png"
            }
        };
    }
}