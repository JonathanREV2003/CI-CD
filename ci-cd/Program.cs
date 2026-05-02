var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("<h1>Hola Mundo desde Azure ¿Funciona?</h1>", "text/html"));

app.Run();
