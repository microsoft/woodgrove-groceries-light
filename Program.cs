using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.Identity.Web;
using Microsoft.Identity.Web.UI;

var builder = WebApplication.CreateBuilder(args);

// Add Microsoft Entra ID authentication
builder.Services.AddAuthentication(OpenIdConnectDefaults.AuthenticationScheme)
    .AddMicrosoftIdentityWebApp(builder.Configuration.GetSection("MicrosoftEntraId"))
    .EnableTokenAcquisitionToCallDownstreamApi()
    .AddDownstreamApi("WoodgroveGroceriesApi", builder.Configuration.GetSection("MicrosoftEntraId"))
    .AddInMemoryTokenCaches();

// Configure OpenID Connect options
// This is important to ensure that the roles and name claims are correctly mapped
builder.Services.Configure<OpenIdConnectOptions>(OpenIdConnectDefaults.AuthenticationScheme,
        options =>
        {
            options.TokenValidationParameters.RoleClaimType = "roles";
            // Configure which claim to use as the user's name in the User.Identity.Name object.
            options.TokenValidationParameters.NameClaimType = "name";
        });

// Add authorization services
builder.Services.AddAuthorization();

// Important: Add both RazorPages and MVC with Views
builder.Services.AddRazorPages()
    .AddMicrosoftIdentityUI();

builder.Services.AddControllersWithViews()
    .AddMicrosoftIdentityUI();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

// Important: Map both endpoints
app.MapRazorPages();
app.MapControllers();

app.Run();
