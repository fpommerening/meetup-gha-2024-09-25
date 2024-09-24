var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hallo .NET Usergroup Rhein/Ruhr");

app.Run();