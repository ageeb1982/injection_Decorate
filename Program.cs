using TamkenSoft.Modules.Common.ageebTools.test;

var builder = WebApplication.CreateBuilder(args);

 builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<ITest, Test1>();
builder.Services.Decorate<ITest, Test1>();
builder.Services.AddScoped<ITest, Test2>();
 
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
