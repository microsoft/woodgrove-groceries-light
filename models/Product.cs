public class Product
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public required string ImageUrl { get; set; }
    public required string Category { get; set; }
}

public static class ProductData
{
    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product
            {
                Category = "Vegetables",
                Name = "Organic baby spinach leaves",
                Price = 3.5m,
                ImageUrl = "/images/products/spinach.png"
            },
            new Product
            {
                Category = "Pasta & Grains",
                Name = "Italian whole wheat spaghetti 500 g",
                Price = 3.0m,
                ImageUrl = "/images/products/pasta.png"
            },
            new Product
            {
                Category = "Dairy",
                Name = "Aged sharp cheddar cheese 200 g",
                Price = 5.5m,
                ImageUrl = "/images/products/cheese.png"
            },
            new Product
            {
                Category = "Pantry",
                Name = "Greek Olive Oil",
                Price = 12.0m,
                ImageUrl = "/images/products/olive-oil.png"
            },
            new Product
            {
                Category = "Bakery",
                Name = "Freshly baked blueberry muffins",
                Price = 3.0m,
                ImageUrl = "/images/products/blueberry-muffins.png"
            },
            new Product
            {
                Category = "Pantry",
                Name = "Homemade mixed nut granola 500 g",
                Price = 4.0m,
                ImageUrl = "/images/products/granola.png"
            },
            new Product
            {
                Category = "Beverages",
                Name = "Pure natural coconut water",
                Price = 2.8m,
                ImageUrl = "/images/products/coconut-water.png"
            },
            new Product
            {
                Category = "Frozen",
                Name = "Margherita wood-fired pizza",
                Price = 3.75m,
                ImageUrl = "/images/products/pizza.png"
            },
            new Product
            {
                Category = "Snacks",
                Name = "70% cocoa dark chocolate bar",
                Price = 4.5m,
                ImageUrl = "/images/products/chocolate.png"
            },
            new Product
            {
                Category = "Fruits",
                Name = "Organic bananas 1 kg",
                Price = 3.6m,
                ImageUrl = "/images/products/bananas.png"
            },
            new Product
            {
                Category = "Pantry",
                Name = "Pure maple syrup",
                Price = 1.5m,
                ImageUrl = "/images/products/maple-syrup.png"
            },
            new Product
            {
                Category = "Frozen",
                Name = "Strawberry ice cream",
                Price = 2.0m,
                ImageUrl = "/images/products/ice-cream.png"
            },
            new Product
            {
                Category = "Beveragess",
                Name = "Six Bottles Of Water pack",
                Price = 3.0m,
                ImageUrl = "/images/products/water.png"
            },
            new Product
            {
                Category = "Pantry",
                Name = "Raw unfiltered local honey 500 g",
                Price = 12.0m,
                ImageUrl = "/images/products/honey.png"
            },
            new Product
            {
                Category = "Dairy",
                Name = "Unsweetened vanilla almond milk 1 L",
                Price = 4.3m,
                ImageUrl = "/images/products/almond-milk.png"
            },
            new Product
            {
                Category = "Frozen",
                Name = "Frozen organic berry blend",
                Price = 5.5m,
                ImageUrl = "/images/products/berries.png"
            },
            new Product
            {
                Category = "Fruits",
                Name = "Dark purple grapes 1.5 kg",
                Price = 11.25m,
                ImageUrl = "/images/products/grapes.jpg"
            },
            new Product
            {
                Category = "Vegetables",
                Name = "Organic sweet tomato 1 kg",
                Price = 2.75m,
                ImageUrl = "/images/products/tomatoes.jpg"
            },
            new Product
            {
                Category = "Bakery",
                Name = "French bread 400 g",
                Price = 13.0m,
                ImageUrl = "/images/products/bread.jpg"
            },
            new Product
            {
                Category = "Dairy",
                Name = "Organic eggs 12 count",
                Price = 12.99m,
                ImageUrl = "/images/products/eggs.jpg"
            },
            new Product
            {
                Category = "Fruits",
                Name = "Sweet corn 1 unit",
                Price = 5.25m,
                ImageUrl = "/images/products/corn.jpg"
            },
            new Product
            {
                Category = "Fruits",
                Name = "Watermelon 1 unit",
                Price = 12.5m,
                ImageUrl = "/images/products/watermelon.jpg"
            },
            new Product
            {
                Category = "Dairy",
                Name = "Organic sugar 2 packages",
                Price = 7.0m,
                ImageUrl = "/images/products/sugar.png"
            },
            new Product
            {
                Category = "Fruits",
                Name = "Oranges 1 kg",
                Price = 4.0m,
                ImageUrl = "/images/products/oranges.png"
            }
        };
    }
}