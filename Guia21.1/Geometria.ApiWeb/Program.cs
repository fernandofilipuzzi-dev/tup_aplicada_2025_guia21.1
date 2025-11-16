using Geometria.DAOs;
using Geometria.DAOs.Lists;
using Geometria.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSingleton<IFigurasDAO, FigurasListDAO>();
builder.Services.AddSingleton<IFigurasService, FigurasService>();

builder.Services.AddOpenApi();
builder.Services.AddSwaggerUI();            // SwaggerUI.OpenApi - paquete de terceros

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.MapSwaggerUI();                     // habilita UI, ruta por defecto /swagger o / (depende del paquete)
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
