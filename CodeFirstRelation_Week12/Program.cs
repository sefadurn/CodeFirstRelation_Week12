using CodeFirstRelation_Week12.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//3.
// appsettings.json dosyasýndaki ConnectionString bilgisini alýyoruz
var cs = builder.Configuration.GetConnectionString("DefaultConnection");

// DbContext'i dependency injection içerisine ekliyoruz
builder.Services.AddDbContext<PatikaSecondDbContext>(options => options.UseSqlServer(cs));



var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
