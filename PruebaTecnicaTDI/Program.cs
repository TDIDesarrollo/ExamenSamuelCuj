using Core.Interfaces.Users;
using Core.Services.Users;
using Infraestructura.Interfaces.Users;
using Infraestructura.Services.Users;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace PruebaTecnicaTDI
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.RootComponents.Add<HeadOutlet>("head::after");
            var apiBaseUrl = builder.Configuration.GetValue<string>("ApiBaseUrl");


            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(apiBaseUrl!) });

            builder.Services.AddScoped<IUsersRepository, UsersRepository>();
            builder.Services.AddScoped<IUsersServices, UsersServices>();

            await builder.Build().RunAsync();
        }
    }
}
