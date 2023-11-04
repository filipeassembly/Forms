using Assembly.Forms.Contracts;
using Assembly.Forms.DiContainer;
using Assembly.Forms.Repositories;
using Assembly.Forms.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// new IServiceCollection();

builder.Services.AddRazorPages();

builder.Services.AddRepos();
builder.Services.AddServices();

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

app.Run();
