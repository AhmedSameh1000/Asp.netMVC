using FirstApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseData();

app.Run();