
var builder = WebApplication.CreateBuilder(args);

// Add services to container-MGG
builder.Services.AddCarter();

builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

builder.Services.AddMarten(opts=>
{
    opts.Connection(builder.Configuration.GetConnectionString("WeatherfordDBConfigration")!);       
}).UseLightweightSessions();

var app = builder.Build();
// Configure the HTTP request pipeline-MGG
app.MapCarter();

app.Run();
