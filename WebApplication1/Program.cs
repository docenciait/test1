namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");
            app.MapGet("/secure", () => "Ciao World!");
            app.MapGet("/secure2", () => "Ciao World!");


            app.Run();
        }
    }
}
