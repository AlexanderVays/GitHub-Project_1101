using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Fluent;

namespace Singleton
{
    class Program
    {
        // requires using Microsoft.Extensions.Configuration;
        public static IConfiguration Configuration;

        static void Main(string[] args)
        {
            Log.Info("Creating service collection");
            ServiceCollection serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);
            var prog1 = Singleton.Instance;
            Console.WriteLine($"The number of different words in a text file is:{prog1.GetVocabularyCounter()}");
            var prog2 = Singleton.Instance;
            Console.WriteLine($"The word 'mathematics' meets {prog2.GetWordValue("mathematical")} times in a text file");

            //getting the name value from appsetting.json
            Console.WriteLine($"The name from the appsetting.json file is: {Configuration.GetSection("Position:Name").Value}");
        }

        private static void ConfigureServices(IServiceCollection serviceCollection)
        {
            // Add logging
            serviceCollection.AddSingleton(LoggerFactory.Create(builder =>
            {
                builder.AddEventLog();
            }));

            serviceCollection.AddLogging();

            // Build configuration
            Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetParent(AppContext.BaseDirectory).FullName)
                .AddJsonFile("appsetting.json", false)
                .Build();
        }
    }
}
