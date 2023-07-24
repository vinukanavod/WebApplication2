using WebApplication2.Services.Authors;
using WebApplication2.Services.Classes;
using WebApplication2.Services.Todos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());//mapper eka inject karaa dependancy ekak widiyata
builder.Services.AddScoped<ITodooRepo, TodooServerSQLservice >();//dependancy innjection
builder.Services.AddScoped<AuthorRepo, AuthorSQLserverService >();//mekath dependancyyak
builder.Services.AddScoped<ClassRepo, ClassSQLService>();
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