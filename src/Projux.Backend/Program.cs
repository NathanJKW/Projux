using Projux.Backend.Brokers.Database;
using Projux.Backend.Database;

var builder = WebApplication.CreateBuilder(args);
var liteDbOptions = new DatabaseOptions { DatabaseLocation = @"Projux.db" };

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton(liteDbOptions);
builder.Services.AddSingleton<IDatabaseContext, DatabaseContext>();
builder.Services.AddSingleton<IDatabaseBroker, DatabaseBroker>();
//builder.Services.AddTransient<ICustomerContactService, CustomerContactService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
