using AccesoDatos.EFCore.Modelos;
using Microsoft.EntityFrameworkCore;
using Negocios;

var builder = WebApplication.CreateBuilder(args);
var provider=builder.Services.BuildServiceProvider();
var configuration=provider.GetRequiredService<IConfiguration>();
//builder.Services.AddDbContext<BDEmpresaContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("ConnectionSqlServer")));
builder.Services.AddTransient<IUnitOfWork>(option => new UnitOfWork(new BDEmpresaContext(new DbContextOptionsBuilder<BDEmpresaContext>().UseSqlServer(configuration.GetConnectionString("ConnectionSqlServer")).Options), configuration.GetConnectionString("ConnectionSqlServer")));
// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Productos}/{action=Index}/{id?}");

app.Run();
