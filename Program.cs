using BookStore.Application_Layer;
using BookStore.Data;
using BookStore.Mapping;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

ServicesBase.AddControllersWithViews();

ServicesBase.AddScoped<IBookRepository, BookRepository>();
ServicesBase.AddScoped<IBookService, BookService>();

ServicesBase.AddAutoMapper(typeof(MappingProfile));

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
