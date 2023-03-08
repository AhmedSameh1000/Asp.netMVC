public class Program
{
    public static int Main()
    {
        var builder = WebApplication.CreateBuilder();
        builder.Services.AddControllersWithViews();
        // builder.Services.AddMvc();
        var app = builder.Build();
        app.MapControllerRoute("default", "{controller}/{action}");

        app.UseStaticFiles();
        app.Run();

        return 0;
    }
}