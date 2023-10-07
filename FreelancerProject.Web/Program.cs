using FreelancerProject.Services.DbContexts;
using FreelancerProject.Web.Configuarations;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//builder.Services.AddMvc(config =>
//{
//    var policy = new AuthorizationPolicyBuilder()
//                     .RequireAuthenticatedUser()
//                     .Build();

//    config.Filters.Add(new AuthorizeFilter(policy));
//});

//builder.Services.AddAuthentication(
//            CookieAuthenticationDefaults.AuthenticationScheme)
//            .AddCookie(option =>
//            {
//                option.LoginPath = "/Auth/Login";
//                option.ExpireTimeSpan = TimeSpan.FromMinutes(30);
//            });

builder.Services.AddDbContext<ProductDbContext>(options =>
    //options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.RegisterServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();
