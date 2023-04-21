using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Prova.NetCore.Data;
using Prova.NetCore.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddControllersWithViews();

// AGGIUNGO IL SERVIZIO ALL'APPLICAZIONE

builder.Services.AddScoped<IBlogService, MemoryBlogService>(); 

// .AddScoped = viene creata una istanza della classe del servizio per ogni utente
// .AddTransient = viene creata una istanza per ogni richiesta
// .AddSingleton = crea una sola istanza condivisa da tutti gli utenti

// QUI VIENE CREATA L'APPLICAZIONE
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); // IMPORTANTE!!!!!

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
