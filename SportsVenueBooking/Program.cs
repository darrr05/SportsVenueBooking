using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SportsVenueBooking.Components;
using SportsVenueBooking.Data;
using SportsVenueBooking.Components.Account;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.Extensions.Hosting; // For BackgroundService
using System;

var builder = WebApplication.CreateBuilder(args);

// Configure the database context
builder.Services.AddDbContextFactory<SportsVenueBookingContext>(options =>
	options.UseSqlServer(builder.Configuration.GetConnectionString("SportsVenueBookingContext") ?? throw new InvalidOperationException("Connection string 'SportsVenueBookingContext' not found.")));

// Add QuickGrid support
builder.Services.AddQuickGridEntityFrameworkAdapter();

// Add services for Razor Components with interactive server render mode
builder.Services.AddRazorComponents()
	.AddInteractiveServerComponents();

// Add cascading authentication state to the container
builder.Services.AddCascadingAuthenticationState();

// Configure Identity for authentication
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();

// Configure authentication state provider for Blazor Server
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

// Configure Identity authentication
builder.Services.AddAuthentication(options =>
{
	options.DefaultScheme = IdentityConstants.ApplicationScheme;
	options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
	.AddIdentityCookies();

// Configure Identity with the SportsVenueBookingUser model
builder.Services.AddIdentityCore<SportsVenueBookingUser>(options => options.SignIn.RequireConfirmedAccount = true)
	.AddRoles<IdentityRole>()
	.AddEntityFrameworkStores<SportsVenueBookingContext>()
	.AddSignInManager()
	.AddDefaultTokenProviders();

// Add email sender (replace with real email sender in production)
builder.Services.AddSingleton<IEmailSender<SportsVenueBookingUser>, RealEmailSender>();

// Configure the cookie settings for identity
builder.Services.ConfigureApplicationCookie(options =>
{
	options.Cookie.HttpOnly = true;
	options.Cookie.SameSite = SameSiteMode.Lax;
	options.ExpireTimeSpan = TimeSpan.FromDays(30);  // Ensure longer expiration for RememberMe
	options.SlidingExpiration = true;
});

// Add controllers
builder.Services.AddControllers()
	.AddJsonOptions(options =>
	{
		options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.Preserve;
	});

builder.Services.AddAuthentication()
   .AddFacebook(options =>
   {
	   IConfigurationSection FBAuthNSection = builder.Configuration.GetSection("Authentication:FB");
	   options.ClientId = FBAuthNSection["ClientId"];
	   options.ClientSecret = FBAuthNSection["ClientSecret"];
   })
   .AddMicrosoftAccount(microsoftOptions =>
   {
	   microsoftOptions.ClientId = builder.Configuration["Authentication:Microsoft:ClientId"];
	   microsoftOptions.ClientSecret = builder.Configuration["Authentication:Microsoft:ClientSecret"];
   })
	.AddTwitter(twitterOptions =>
	{
		twitterOptions.ConsumerKey = builder.Configuration["Authentication:Twitter:ConsumerAPIKey"];
		twitterOptions.ConsumerSecret = builder.Configuration["Authentication:Twitter:ConsumerSecret"];
		twitterOptions.RetrieveUserDetails = true;
	});

var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Error");
	app.UseHsts();
	app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

// Map Razor components for interactive rendering
app.MapRazorComponents<App>()
	.AddInteractiveServerRenderMode();

// Map identity endpoints
app.MapAdditionalIdentityEndpoints();

app.Run();
