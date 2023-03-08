namespace FirstApp.Middlewares
{
    public class MiddleWare
    {
        private readonly RequestDelegate _next;

        public MiddleWare(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if (httpContext.Request.Path == "/home/index")
                await httpContext.Response.WriteAsync("<h1>Home index Page</h1>");

            if (httpContext.Request.Path == "/home/AboutUs")
                await httpContext.Response.WriteAsync("<h1>Home AboutUs Page</h1>");

            if (httpContext.Request.Path == "/home/Contact")
                await httpContext.Response.WriteAsync("<h1>Home Contact Page</h1>");
        }
    }

    public static class MiddleWareExtensions
    {
        public static IApplicationBuilder UseData(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MiddleWare>();
        }
    }
}