using Autofac;
using DBS_Course_Work_3kurs.EF;
using DBS_Course_Work_3kurs.Repositories.Implementation;
using DBS_Course_Work_3kurs.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;

namespace DBS_Course_Work_3kurs
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            var Builder = new ContainerBuilder();
            Builder.RegisterType<BooksRepository>().As<IBooksRepository>();
            Builder.RegisterType<CustomersRepository>().As<ICustomersRepository>();
            Builder.RegisterType<DiscountsRepository>().As<IDiscountsRepository>();
            Builder.RegisterType<FinesRepository>().As<IFinesRepository>();
            Builder.RegisterType<LendingsRepository>().As<ILendingsRepository>();

            string connectionString = "Server = 127.0.0.1; Database = Library; User Id = root; Password = bober2467;";

            var dbContextOptions = new DbContextOptionsBuilder<LibraryDBContext>();
            
            dbContextOptions.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

            // Register AppDbContext with options directly
            Builder.Register(c => new LibraryDBContext(dbContextOptions.Options))
                   .As<LibraryDBContext>()
                   .InstancePerLifetimeScope();

            var container = Builder.Build();

            
            /*
            using (var scope = container.BeginLifetimeScope())
            {
                var dbContext = scope.Resolve<LibraryDBContext>();
                dbContext.Database.Migrate(); // Apply pending migrations
            }
            */
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
        /*
        public LibraryDBContext CreateDbContext(string[] args)
        {
            var configurationBuilder = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfigurationRoot configuration = configurationBuilder.Build();
            string connectionString = configuration.GetConnectionString("Storage");

            DbContextOptionsBuilder<LibraryDBContext> optionsBuilder = new DbContextOptionsBuilder<LibraryDBContext>()
                .UseMySQL(connectionString);

            return new LibraryDBContext(optionsBuilder.Options);
        }
        */
    }
}