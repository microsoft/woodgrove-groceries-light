﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace woodgrove_groceries.Pages;

public class ProfileModel : PageModel
{
    private readonly ILogger<ProfileModel> _logger;

    public ProfileModel(ILogger<ProfileModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

