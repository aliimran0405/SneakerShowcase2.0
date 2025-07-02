using SneakerShowcaseServer.Api.Data;
using SneakerShowcaseServer.Api.Endpoints;


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

app.UseCors();

app.MapSneakersEndpoints();

app.Run();
