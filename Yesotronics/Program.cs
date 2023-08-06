using Microsoft.EntityFrameworkCore;
using Yesotronics.Service;
using Yesotronics.Service.AutoMapper;
using Yesotronics.Service.IServices;
using Yesotronics.Service.Services;
using Yosotronics.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<YosotronicsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseConnection"));
});
//builder.Services.AddSingleton<IUserService,UserService>();
builder.Services.AddPersistenceServices();
builder.Services.AddDomainServices();
builder.Services.AddControllers();
builder.Services.AddAutoMapper(typeof(MappingProfile));
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
