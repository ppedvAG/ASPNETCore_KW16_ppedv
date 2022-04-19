//WebApplicationBuilder kümmert sich um das Initaliseren der WebApp 
using ASPNETCore_RazorPages.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //Factory Methode und gibt WebApplicationBuilder zurück


// Add services to the container. ->
// in .NET 5 public void ConfigureServices(IServiceCollection services)
builder.Services.AddRazorPages(); //Wir fürgen das RazorPage UI-Framework hinzu


//RequestCounter wird einmal erstellt und steht immer bereit
builder.Services.AddSingleton<IRequestCounter, RequestCounter>();


WebApplication app = builder.Build();


#region Zugriff auf IOC Container in .NET6 (Workflow -> für EF Core - Testdaten)
IRequestCounter requestCounter1 = app.Services.GetService<IRequestCounter>();
#endregion

#region Zugriff auf IOC Container nach .NET 2.1 
IServiceScope scope = app.Services.CreateScope();
IRequestCounter requestCounter2 = scope.ServiceProvider.GetService<IRequestCounter>();
#endregion


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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
