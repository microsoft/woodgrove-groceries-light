public class Product
{
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public required string ImageUrl { get; set; }
    public required string Category { get; set; }
    public required string Description { get; set; }
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
                ImageUrl = "/images/products/spinach.png",
                Description = "Fresh, tender organic baby spinach leaves perfect for salads, smoothies, and cooking. Rich in iron, vitamins, and antioxidants."
            },
            new Product
            {
                Category = "Pasta & Grains",
                Name = "Italian spaghetti 500g",
                Price = 3.0m,
                ImageUrl = "/images/products/pasta.png",
                Description = "Authentic Italian whole wheat spaghetti made from durum wheat. High in fiber and perfect for healthy, delicious pasta dishes."
            },
            new Product
            {
                Category = "Dairy",
                Name = "Aged cheddar cheese 200g",
                Price = 5.5m,
                ImageUrl = "/images/products/cheese.png",
                Description = "Premium aged sharp cheddar with a rich, tangy flavor. Perfect for sandwiches, cooking, or enjoying with crackers and wine."
            },
            new Product
            {
                Category = "Pantry",
                Name = "Greek Olive Oil",
                Price = 12.0m,
                ImageUrl = "/images/products/olive-oil.png",
                Description = "Cold-pressed extra virgin Greek olive oil with a robust flavor and golden color. Ideal for cooking, dressing salads, and Mediterranean cuisine."
            },
            new Product
            {
                Category = "Bakery",
                Name = "Freshly baked blueberry muffins",
                Price = 3.0m,
                ImageUrl = "/images/products/blueberry-muffins.png",
                Description = "Soft, fluffy muffins bursting with fresh blueberries. Baked daily with premium ingredients for the perfect breakfast or snack."
            },
            new Product
            {
                Category = "Pantry",
                Name = "Mixed nut granola 500g",
                Price = 4.0m,
                ImageUrl = "/images/products/granola.png",
                Description = "Crunchy homemade granola with a blend of nuts, oats, and honey. Perfect for breakfast with yogurt or milk, or as a healthy snack."
            },
            new Product
            {
                Category = "Beverages",
                Name = "Pure natural coconut water",
                Price = 2.8m,
                ImageUrl = "/images/products/coconut-water.png",
                Description = "Refreshing natural coconut water packed with electrolytes. A healthy, hydrating drink perfect for post-workout or any time of day."
            },
            new Product
            {
                Category = "Frozen",
                Name = "Margherita wood-fired pizza",
                Price = 3.75m,
                ImageUrl = "/images/products/pizza.png",
                Description = "Authentic wood-fired Margherita pizza with fresh mozzarella, basil, and tomato sauce on a crispy thin crust. Ready to bake at home."
            },
            new Product
            {
                Category = "Snacks",
                Name = "70% cocoa dark chocolate bar",
                Price = 4.5m,
                ImageUrl = "/images/products/chocolate.png",
                Description = "Rich, premium dark chocolate with 70% cocoa content. A sophisticated treat with intense flavor and antioxidant benefits."
            },
            new Product
            {
                Category = "Fruits",
                Name = "Organic bananas 1 kg",
                Price = 3.6m,
                ImageUrl = "/images/products/bananas.png",
                Description = "Fresh, ripe organic bananas perfect for snacking, smoothies, or baking. High in potassium and naturally sweet."
            },
            new Product
            {
                Category = "Pantry",
                Name = "Pure maple syrup",
                Price = 1.5m,
                ImageUrl = "/images/products/maple-syrup.png",
                Description = "100% pure maple syrup tapped from Canadian maple trees. Natural sweetener perfect for pancakes, waffles, and desserts."
            },
            new Product
            {
                Category = "Frozen",
                Name = "Strawberry ice cream",
                Price = 2.0m,
                ImageUrl = "/images/products/ice-cream.png",
                Description = "Creamy, rich strawberry ice cream made with real strawberries. A classic frozen treat perfect for any occasion."
            },
            new Product
            {
                Category = "Beverages",
                Name = "Six Bottles Of Water pack",
                Price = 3.0m,
                ImageUrl = "/images/products/water.png",
                Description = "Pack of six bottles of pure, refreshing drinking water. Essential for hydration at home, work, or on the go."
            },
            new Product
            {
                Category = "Beverages",
                Name = "Fresh orange juice 1 L",
                Price = 4.0m,
                ImageUrl = "/images/products/orange-juice.png",
                Description = "Freshly squeezed orange juice packed with vitamin C and natural citrus flavor. No added sugar or preservatives."
            },
            new Product
            {
                Category = "Frozen",
                Name = "Frozen green peas 500g",
                Price = 2.5m,
                ImageUrl = "/images/products/green-peas.png",
                Description = "Flash-frozen green peas that retain their nutrients and flavor. Perfect for side dishes, soups, and stir-fries."
            },
            new Product
            {
                Category = "Dairy",
                Name = "Greek yogurt 500g",
                Price = 4.8m,
                ImageUrl = "/images/products/greek-yogurt.png",
                Description = "Thick, creamy Greek yogurt with high protein content and probiotics. Perfect for breakfast, snacks, or as a healthy ingredient in recipes."
            },
            new Product
            {
                Category = "Fruits",
                Name = "Red apples 1 kg",
                Price = 3.9m,
                ImageUrl = "/images/products/red-apples.png",
                Description = "Crisp, sweet red apples perfect for snacking or baking. Rich in fiber and vitamins for a healthy treat."
            },
            new Product
            {
                Category = "Vegetables",
                Name = "Carrots 1 kg",
                Price = 2.0m,
                ImageUrl = "/images/products/carrots.png",
                Description = "Fresh, crunchy carrots packed with beta-carotene and vitamins. Great for cooking, juicing, or eating raw as a healthy snack."
            },
            new Product
            {
                Category = "Pantry",
                Name = "Canned chickpeas 400g",
                Price = 1.2m,
                ImageUrl = "/images/products/chickpeas.png",
                Description = "Premium canned chickpeas, ready to use. High in protein and fiber, perfect for salads, hummus, soups, and Mediterranean dishes."
            },
            new Product
            {
                Category = "Cleaning",
                Name = "Laundry detergent 2L",
                Price = 12.99m,
                ImageUrl = "/images/products/laundry-detergent.png",
                Description = "Concentrated laundry detergent that effectively removes stains and leaves clothes fresh and clean. Suitable for all fabric types."
            },
            new Product
            {
                Category = "Cleaning",
                Name = "Hand soap 250ml",
                Price = 2.99m,
                ImageUrl = "/images/products/hand-soap.png",
                Description = "Gentle moisturizing hand soap with antibacterial properties. Keeps hands clean and soft with a pleasant fragrance."
            },
            new Product
            {
                Category = "Cleaning",
                Name = "Glass cleaner 500ml",
                Price = 3.79m,
                ImageUrl = "/images/products/glass-cleaner.png",
                Description = "Streak-free glass cleaner that leaves windows, mirrors, and glass surfaces crystal clear and sparkling clean."
            },
            new Product
            {
                Category = "Cleaning",
                Name = "Liquid dish soap 500ml",
                Price = 3.99m,
                ImageUrl = "/images/products/dish-soap.png",
                Description = "Powerful liquid dish soap that cuts through grease and grime, leaving dishes spotless and fresh-smelling."
            },
            new Product
            {
                Category = "Snacks",
                Name = "Salted roasted almonds 200g",
                Price = 5.0m,
                ImageUrl = "/images/products/almonds.png",
                Description = "Premium roasted almonds with the perfect amount of salt. A healthy, protein-rich snack packed with nutrients."
            },
            new Product
            {
                Category = "Snacks",
                Name = "Potato chips 150g",
                Price = 2.3m,
                ImageUrl = "/images/products/potato-chips.png",
                Description = "Crispy, golden potato chips made from premium potatoes. The perfect crunchy snack for any occasion."
            },
            new Product
            {
                Category = "Bakery",
                Name = "Chocolate chip cookies",
                Price = 3.5m,
                ImageUrl = "/images/products/cookies.png",
                Description = "Soft, chewy chocolate chip cookies made with premium chocolate chips. A classic treat that's perfect with milk or coffee."
            },
            new Product
            {
                Category = "Dairy",
                Name = "Butter 250g",
                Price = 3.6m,
                ImageUrl = "/images/products/butter.png",
                Description = "Rich, creamy butter made from fresh cream. Essential for baking, cooking, and spreading on bread or toast."
            },
            new Product
            {
                Category = "Frozen",
                Name = "Frozen mango chunks 500g",
                Price = 3.8m,
                ImageUrl = "/images/products/frozen-mango.png",
                Description = "Sweet, tropical frozen mango chunks perfect for smoothies, desserts, or eating straight from the bag as a healthy treat."
            },
            new Product
            {
                Category = "Beverages",
                Name = "Green tea 20 bags",
                Price = 3.0m,
                ImageUrl = "/images/products/green-tea.png",
                Description = "Premium green tea bags with a delicate, refreshing flavor. Rich in antioxidants and perfect for daily wellness."
            },
            new Product
            {
                Category = "Pantry",
                Name = "Raw unfiltered local honey 500g",
                Price = 12.0m,
                ImageUrl = "/images/products/honey.png",
                Description = "Pure, raw unfiltered honey from local beekeepers. Natural sweetener with unique floral notes and health benefits."
            },
            new Product
            {
                Category = "Dairy",
                Name = "Vanilla almond milk 1L",
                Price = 4.3m,
                ImageUrl = "/images/products/almond-milk.png",
                Description = "Creamy, unsweetened vanilla almond milk. A dairy-free alternative perfect for cereals, coffee, smoothies, and baking."
            },
            new Product
            {
                Category = "Frozen",
                Name = "Frozen organic berry blend",
                Price = 5.5m,
                ImageUrl = "/images/products/berries.png",
                Description = "Premium blend of organic frozen berries including strawberries, blueberries, and raspberries. Perfect for smoothies and desserts."
            },
            new Product
            {
                Category = "Fruits",
                Name = "Dark purple grapes 1.5 kg",
                Price = 11.25m,
                ImageUrl = "/images/products/grapes.jpg",
                Description = "Sweet, juicy dark purple grapes bursting with flavor. Perfect for snacking, fruit salads, or making fresh juice."
            },
            new Product
            {
                Category = "Vegetables",
                Name = "Organic sweet tomato 1 kg",
                Price = 2.75m,
                ImageUrl = "/images/products/tomatoes.jpg",
                Description = "Fresh, organic sweet tomatoes with rich flavor. Ideal for salads, sandwiches, sauces, and cooking."
            },
            new Product
            {
                Category = "Bakery",
                Name = "French bread 400g",
                Price = 13.0m,
                ImageUrl = "/images/products/bread.jpg",
                Description = "Authentic French bread with a crispy crust and soft, airy interior. Perfect for sandwiches, toast, or enjoying with meals."
            },
            new Product
            {
                Category = "Dairy",
                Name = "Organic eggs 12 count",
                Price = 12.99m,
                ImageUrl = "/images/products/eggs.jpg",
                Description = "Fresh organic eggs from free-range hens. High in protein and perfect for breakfast, baking, and cooking."
            },
            new Product
            {
                Category = "Fruits",
                Name = "Sweet corn 1 unit",
                Price = 5.25m,
                ImageUrl = "/images/products/corn.jpg",
                Description = "Fresh, sweet corn on the cob with tender kernels. Perfect for grilling, boiling, or roasting as a delicious side dish."
            },
            new Product
            {
                Category = "Fruits",
                Name = "Watermelon 1 unit",
                Price = 12.5m,
                ImageUrl = "/images/products/watermelon.jpg",
                Description = "Large, juicy watermelon with sweet, refreshing flesh. Perfect for summer gatherings, picnics, and hot weather refreshment."
            },
            new Product
            {
                Category = "Dairy",
                Name = "Organic sugar 2 packages",
                Price = 7.0m,
                ImageUrl = "/images/products/sugar.png",
                Description = "Pure organic cane sugar in convenient packages. Perfect for baking, cooking, sweetening beverages, and all culinary needs."
            },
            new Product
            {
                Category = "Fruits",
                Name = "Oranges 1 kg",
                Price = 4.0m,
                ImageUrl = "/images/products/oranges.png",
                Description = "Fresh, juicy oranges packed with vitamin C and natural citrus flavor. Great for snacking, juicing, or adding to recipes."
            }
        };
    }
}