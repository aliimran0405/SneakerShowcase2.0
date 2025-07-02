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

// Allow the use of static files which will be sent to client
app.UseStaticFiles();

app.MapSneakersEndpoints();

app.Run();
