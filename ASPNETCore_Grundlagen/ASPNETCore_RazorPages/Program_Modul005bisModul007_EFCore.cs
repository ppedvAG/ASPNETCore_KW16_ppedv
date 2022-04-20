////WebApplicationBuilder k�mmert sich um das Initaliseren der WebApp 
//using ASPNETCore_RazorPages.Data;
//using ASPNETCore_RazorPages.Services;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;

//WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //Factory Methode und gibt WebApplicationBuilder zur�ck

//builder.Services.AddRazorPages(); //Wir f�rgen das RazorPage UI-Framework hinzu

//builder.Services.AddDbContext<SecondMovieDbContext>(options =>

//    options.UseSqlServer(builder.Configuration.GetConnectionString("SecondMovieDbContext") ?? throw new InvalidOperationException("Connection string 'SecondMovieDbContext' not found.")));

//builder.Services.AddDbContext<MovieDbContext>(options =>
//{
//    //F�r Evaluierungen kann mein die MemoryDatabase verwenden (bei jedem WebAPP)
//    options.UseInMemoryDatabase("MovieDb");
//});

//var app = builder.Build();

////Testdaten werden bef�llt

//IServiceScope scope = app.Services.CreateScope();
//MovieDbContext movieDbContext = scope.ServiceProvider.GetRequiredService<MovieDbContext>();

//DataSeeder.SeedMovieStoreDb(movieDbContext);




////in .NET 5  public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapRazorPages();

//app.Run();
