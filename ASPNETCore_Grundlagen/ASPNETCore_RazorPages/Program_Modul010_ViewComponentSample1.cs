//WebApplicationBuilder kümmert sich um das Initaliseren der WebApp 
using ASPNETCore_RazorPages.Services;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Options;
using System.Globalization;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //Factory Methode und gibt WebApplicationBuilder zurück


// in .NET 5 public void ConfigureServices(IServiceCollection services)
builder.Services.AddRazorPages(); //Wir fürgen das RazorPage UI-Framework hinzu
builder.Services.AddLocalization();

//hinzufügen aller Kulturen
builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new[]
    {
        new CultureInfo("en"),
        new CultureInfo("de"),
        new CultureInfo("fr"),
        new CultureInfo("es"),
        new CultureInfo("ru"),
        new CultureInfo("ja"),
        new CultureInfo("ar"),
        new CultureInfo("zh"),
        new CultureInfo("en-GB")
    };

    options.DefaultRequestCulture = new RequestCulture("en-GB");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

var app = builder.Build();



//in .NET 5  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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

//Initiale Culture wird verwendet und lese RequestLocalizationOptions aus dem IOC Container
RequestLocalizationOptions localizationOptions = app.Services.GetService<IOptions<RequestLocalizationOptions>>().Value;
app.UseRequestLocalization(localizationOptions);

app.UseAuthorization();

app.MapRazorPages();

app.Run();
