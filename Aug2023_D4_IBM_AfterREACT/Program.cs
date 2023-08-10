namespace Aug2023_D4_IBM_AfterREACT
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddDistributedMemoryCache();

            builder.Services.AddSession(o => {


                o.IdleTimeout = TimeSpan.FromMinutes(30);

            });
            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();



            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=StateManagementEg}/{action=HiddenVariablesTechnique}/{id?}");

            app.Run();
        }
    }
}