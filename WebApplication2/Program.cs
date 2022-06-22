using Microsoft.EntityFrameworkCore;
using WebApplication2;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<DenemeDataContext>(
       o => o.UseNpgsql(builder.Configuration.GetConnectionString("sinanConnection"))   
    );
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

app.UseAuthorization();

app.MapRazorPages();
//options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
app.MapControllerRoute(
        name:"default",
        pattern: "{controller=Deneme}/{action=denemeList}"
    );
app.Run();
