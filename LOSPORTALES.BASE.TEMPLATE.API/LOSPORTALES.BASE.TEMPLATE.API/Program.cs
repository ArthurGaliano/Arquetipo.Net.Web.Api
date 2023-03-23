using System.Reflection;


var builder = WebApplication.CreateBuilder(args);

//Configuracion de los servicios
builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddApplicationInsightsTelemetry();

//Configuracion de los servicios de la aplicación
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.RoutePrefix = String.Empty;
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Template v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


