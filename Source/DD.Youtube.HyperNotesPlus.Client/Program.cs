using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using DD.Youtube.HyperNotesPlus.Domain.Notes;
using DD.Youtube.HyperNotesPlus.Client.Extensions.Services;
using DD.Youtube.HyperNotesPlus.Client.Extensions.Services.Implementations;

namespace DD.Youtube.HyperNotesPlus.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddTransient(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            AddServices(builder.Services);

            await builder.Build().RunAsync();
        }


        private static void AddServices(IServiceCollection services)
        {
            services.AddSingleton<INoteService, NoteService>();
            services.AddSingleton<ILocalStorageService, LocalStorageJsRuntimeService>();
        }
    }
}
