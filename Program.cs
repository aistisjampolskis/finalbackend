using ContactsAPI.Data;
using ContactsAPI.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
//builder.Services.AddScoped<>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAddContactRequest, AddContactRequest>();
builder.Services.AddDbContext<ContactsAPIDbContext>
    (options => options.UseSqlServer
    (builder.Configuration.GetConnectionString
    ("ContactsApiConnectionString")));



var allowAll = "_allowAll";



builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowAll,
                      build =>
                      {
                          build.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
                      });
});

//builder.Services.AddDbContext<ContactsAPIDbContext>(options => options.UseInMemoryDatabase("ContactsDb"));
/*builder.Services.AddDbContext<ContactsAPIDbContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContactsApiConnectionString")));
*/
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors(allowAll);

app.MapControllers();

app.Run();
