using WeatherAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IWForecastRepository, WForecastRepository>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=WeatherForecast}/{action=SearchByCity}/{id?}");

app.Run();