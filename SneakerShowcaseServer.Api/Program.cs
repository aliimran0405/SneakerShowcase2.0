using SneakerShowcaseServer.Api.Data;
using SneakerShowcaseServer.Api.Endpoints;


var builder = WebApplication.CreateBuilder(args);


var connString = builder.Configuration.GetConnectionString("SneakerShowcase");
builder.Services.AddSqlite<SneakerShowcaseContext>(connString);

var app = builder.Build();

app.MapSneakersEndpoints();

app.Run();
