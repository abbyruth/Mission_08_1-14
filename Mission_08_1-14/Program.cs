using Microsoft.EntityFrameworkCore;
using Mission_08_1_14.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<TaskListContext>(options => { // Connect to our database file
    options.UseSqlite(builder.Configuration["ConnectionStrings:TasksList"]);
});

builder.Services.AddScoped<ITaskListRepository, EFTaskListRepository>(); // Give each request an instance of the repository/context

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
