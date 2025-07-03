using SneakerShowcaseServer.Api.Data;
using SneakerShowcaseServer.Api.Endpoints;
using SneakerShowcaseServer.Api.Entities;
using SneakerShowcaseServer.Api.UtilsDir;
using System;


var builder = WebApplication.CreateBuilder(args);


var connString = builder.Configuration.GetConnectionString("SneakerShowcase");
builder.Services.AddSqlite<SneakerShowcaseContext>(connString);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});


var app = builder.Build();

using var scope = app.Services.CreateScope();
var db = scope.ServiceProvider.GetRequiredService<SneakerShowcaseContext>();

// Seed initial data (sneakers I have decided to include) here at runtime...
if (!db.Sneakers.Any())
{
    var sneakers = Utils.ReadJSON();
    db.Sneakers.AddRange(sneakers);
    db.SaveChanges();
}

app.UseCors();

// Allow the use of static files which will be sent to client
app.UseStaticFiles();

app.MapSneakersEndpoints();

app.Run();
