using CustomMiddewarePipeline.Middlewares;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
//This is custom middelwares 
app.UseMiddleware<Middleware1>();
app.UseMiddleware<Middleware2>();
//Another Way to Weite Middleware
app.Use(async (context, next) =>
{
    Console.WriteLine("=========Third Middleware start========");
    Console.WriteLine("Do what you want");
    await next(context);
    Console.WriteLine("this is Middleware3 Response");
});
app.UseMiddleware<Middleware4>();
app.MapGet("/", () => "Hello World!\n");
app.Run();