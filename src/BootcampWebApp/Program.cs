var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();   // ✔ correct way in .NET 8

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();    // ✔ no WithStaticAssets()

app.Run();