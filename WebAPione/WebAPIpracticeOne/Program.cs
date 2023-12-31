using Microsoft.EntityFrameworkCore;
using WebAPIpracticeOne.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
#region CORS config
builder.Services.AddCors(options =>
{
    options.AddPolicy("CustomPolicy",x=> x.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});
#endregion

#region
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<AppDbContext>(options => options.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString)));
#endregion
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
app.UseCors("CustomPolicy");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
