var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => Results.Content("<h1>Hola Mundo desde Azure Actualizacón continua aprobada</h1>", "text/html"));

app.Run();
