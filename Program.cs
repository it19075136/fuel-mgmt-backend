using fuel_mgmt_backend.models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<UserStoreDbSettings>(
    builder.Configuration.GetSection(nameof(UserStoreDbSettings)));

builder.Services.AddSingleton<IUserStoreDbSettings>(sp => sp.GetRequiredService<IOptions<UserStoreDbSettings>>().Value);

builder.Services.AddSingleton<IMongoClient>(s => new MongoClient(builder.Configuration.GetValue<string>("UserStoreDbSettings:ConnectionString")));

builder.Services.AddScoped<IUserService,UserService>();

builder.Services.AddScoped<IScheduleService, ScheduleService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
