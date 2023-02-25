namespace CustomMiddewarePipeline.Middlewares;

public class Middleware2
{
    private readonly RequestDelegate next;

    public Middleware2(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("=========Second Middleware start========");
        Console.WriteLine("Do what you want");
        await next(context);
        Console.WriteLine("this is Middleware2 Response");
    }
}