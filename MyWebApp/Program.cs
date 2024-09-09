var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Ayesha, This is your first Azure Devops Project ");

app.Run();
