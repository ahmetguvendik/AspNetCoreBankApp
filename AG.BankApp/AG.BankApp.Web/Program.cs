using AG.BankApp.Web.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<BankContext>(opt =>
    opt.UseSqlServer("server = DESKTOP-A523NCQ\\MSSQLSERVER01; database = AG.BankApp; integrated security = true")
);

var app = builder.Build();
app.UseStaticFiles();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine
    (Directory.GetCurrentDirectory(),"node_modules"))
    , RequestPath = "/node_modules"
});

app.MapDefaultControllerRoute();
app.Run();
