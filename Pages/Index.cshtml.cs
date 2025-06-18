using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace woodgrove_groceries.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    public bool IsCommercialAccount { get; set; } = false;
    public bool HasEggsAllergy { get; set; } = false;
    public List<Product> Products { get; set; } = new List<Product>();
    public List<string> listOfAvatars { get; set; }

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
        listOfAvatars = new List<string>() { "01", "02", "03", "04", "05", "06", "07" };
    }

    public void OnGet()
    {
        // Get the products
        Products = ProductData.GetSampleProducts();

        // Randomize the avatars
        this.listOfAvatars = this.listOfAvatars.OrderBy(i => Guid.NewGuid()).ToList();
    }
}
