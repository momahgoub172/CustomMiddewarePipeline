namespace CustomMiddewarePipeline.Middlewares;

public class Middleware1
{
    //is pointer to next middelware
    private readonly RequestDelegate next;

    public Middleware1(RequestDelegate next)
    {
        this.next = next;
    }

    //Invoke method contains logic of midleware
    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("=========First Middleware start========");
        Console.WriteLine("Do what you want");
        await next(context);
        Console.WriteLine("this is Middleware1 Response");
    }
}