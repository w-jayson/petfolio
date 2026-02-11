var builder = WebApplication.CreateBuilder(args);

// Adiciona suporte aos Controllers
builder.Services.AddControllers();

// Configura o NSwag (OpenAPI)
builder.Services.AddOpenApiDocument(configure =>
{
    configure.Title = "Petfolio API";
    configure.Version = "v1";
});

var app = builder.Build();

// Configura o pipeline de requisições HTTP
if (app.Environment.IsDevelopment())
{
    // Ativa o middleware do NSwag
    app.UseOpenApi();      // Gera o swagger.json
    app.UseSwaggerUi();    // Interface gráfica (Swagger UI)
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Mapeia as rotas dos seus Controllers
app.MapControllers();

app.Run();