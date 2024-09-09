var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello Ayesha, Introducing your first Azure Devops CI/CD Project ");

app.Run();
