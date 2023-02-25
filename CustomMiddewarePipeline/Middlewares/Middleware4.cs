namespace CustomMiddewarePipeline.Middlewares;

public class Middleware4
{
    private readonly RequestDelegate next;

    public Middleware4(RequestDelegate next)
    {
        this.next = next;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        Console.WriteLine("=========Fourth Middleware start========");
        Console.WriteLine(context.Request.Headers.Host);
        Console.WriteLine("-------------------------------------------------------");
        await next(context);
        Console.WriteLine("this is Middleware4 Response");
        await context.Response.WriteAsync("This text from middlware4 response");
    }
}