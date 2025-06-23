
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

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Configure the HTTP request pipeline-MGG
app.MapCarter();

app.Run();
