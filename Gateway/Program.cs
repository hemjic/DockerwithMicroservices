using Ocelot.DependencyInjection;
using Ocelot.Middleware;
var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
#region Cors
// CORS configuration
builder.Services.AddCors(options =>
{
	options.AddPolicy("AllRequests", builder =>
	{
		builder.AllowAnyHeader()
		.AllowAnyMethod()
		.AllowAnyOrigin();
	});
});

#endregion
var app = builder.Build();
app.UseOcelot().Wait();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseCors("AllRequests");
app.MapControllers();

app.Run();
