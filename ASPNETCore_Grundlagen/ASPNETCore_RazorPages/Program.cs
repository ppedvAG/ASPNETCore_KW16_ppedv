//WebApplicationBuilder kümmert sich um das Initaliseren der WebApp 
WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //Factory Methode und gibt WebApplicationBuilder zurück


// Add services to the container. ->
// in .NET 5 public void ConfigureServices(IServiceCollection services)
builder.Services.AddRazorPages(); //Wir fürgen das RazorPage UI-Framework hinzu


/*builder.Services.AddControllersWithViews(); *///Wir verwenden MVC 
/*builder.Services.AddMvc();*/ // Kompination von RazorPages und MVC

//WebAPI 
//builder.Services.AddControllers();

//.NET 5 abwärst-Compilier ->IHostBulder wird in .NET verwendet
//builder.Host.

//NET 2.1 WebHost
//builder.WebHost


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

app.UseAuthorization();

app.MapRazorPages();

app.Run();
