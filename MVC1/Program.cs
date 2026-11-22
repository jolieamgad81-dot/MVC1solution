namespace MVC1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddControllersWithViews();

            // builder.Services.AddControllers();
            //builder.Services.AddMvcCore();
            //builder.Services.AddMvc();

            var app = builder.Build();

            //app.UseMiddleware<RequestMadleware>();


            //app.Use(async(context , next)=>
            //    {
            //    Console.WriteLine("hello");
            //      await  next.Invoke(context);
            //        Console.WriteLine("bye");
            //    });

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            //app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();

            app.MapControllerRoute(
                name: "shop",
                pattern: "shop/{id}",
                defaults: new
                {
                    controller="product",
                    action = "GetProductById"
                });




            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{?Id}")
                .WithStaticAssets();






            //app.MapControllerRoute(
            //    name: "default",
            //    pattern: "{controller=Home}/{action=Index}/{id?}")
            //    .WithStaticAssets();

            app.Run();
        }
    }
}
