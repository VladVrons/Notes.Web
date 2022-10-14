using Notes.DAL;
using Notes.DAL.Interfaces;
using Notes.DAL.Model;
using Notes.Web;
using Notes.Web.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddSingleton<IService, TextServise>();
//builder.Services.AddScoped<IRepository<Note>, Repository<Note>>();

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
