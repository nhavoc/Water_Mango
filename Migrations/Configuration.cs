namespace PWM.Migrations
{
    using PWM.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PWM.Data.DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PWM.Data.DataContext context)
        {
            var plants = new[]
            {
                new Plant{Id=1,Name="Plant-1"},
                new Plant{Id=2,Name="Plant-2"},
                new Plant{Id=3,Name="Plant-3"},
                new Plant{Id=4,Name="Plant-4"},
                new Plant{Id=5,Name="Plant-5"},
            };

            context.Plants.AddOrUpdate(p => p.Id, plants);
        }
    }
}
