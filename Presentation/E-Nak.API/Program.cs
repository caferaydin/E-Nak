using E_Nak.Persistence;
using E_Nak.Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Add Service Registration

builder.Services.AddPersistenceService();

#endregion

#region Cors 

builder.Services.AddCors(options => options.AddDefaultPolicy(policy => 
    //policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()
    policy.WithOrigins("https://localhost:4200", "https://localhost:4200").
    AllowAnyHeader().AllowAnyMethod()
    ));

#endregion

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// add 
app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
