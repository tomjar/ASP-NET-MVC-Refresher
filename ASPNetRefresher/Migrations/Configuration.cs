namespace ASPNetRefresher.Migrations
{
    using ASPNetRefresher.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Text;
    using TinyCsvParser;

    internal sealed class Configuration : DbMigrationsConfiguration<ASPNetRefresherDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ASPNetRefresherDbContext context)
        {
            //  This method will be called after migrating to the latest version.
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            // var _filePath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            var _filePath = "C:\\Users\\tom\\Documents\\GitHub\\ASP-NET-MVC-Refresher\\ASPNetRefresher\\TITANITES.csv";

            Console.WriteLine(_filePath);

            var csvParserOptions = new CsvParserOptions(true, ',');
            var csvMapper = new CsvTitaniteMapping();
            var tinyCsvParser = new CsvParser<Titanite>(csvParserOptions, csvMapper);

            try
            {
                var result = tinyCsvParser
                    .ReadFromFile(_filePath, Encoding.UTF8)
                    .ToList();

                result.ForEach(r =>
                {
                   if (r.IsValid)
                    {
                        context.Titanites.AddOrUpdate(new Titanite()
                        {
                          citation = r.Result.citation,
                          sample_name = r.Result.sample_name,
                          tectonic_setting = r.Result.tectonic_setting,
                          location = r.Result.location,
                          location_comment = r.Result.location_comment,
                          latitude_min = r.Result.latitude_min,
                          latitude_max = r.Result.latitude_max,
                          longitude_min = r.Result.longitude_min,
                          longitude_max = r.Result.longitude_max,
                          land_sea_sampling = r.Result.land_sea_sampling,
                          elevation_min = r.Result.elevation_min,
                          elevation_max = r.Result.elevation_max,
                          rock_name = r.Result.rock_name,
                          rock_texture = r.Result.rock_texture,
                          drilling_depth_min = r.Result.drilling_depth_min,
                          drilling_depth_max = r.Result.drilling_depth_max,
                          alteration = r.Result.alteration,
                          mineral = r.Result.mineral,
                          spot = r.Result.spot,
                          crystal = r.Result.crystal,
                          rim_core_mineral_grains = r.Result.rim_core_mineral_grains,
                          grain_size = r.Result.grain_size,
                          primary_secondary = r.Result.primary_secondary,
                          createdBy = "seed",
                          createdDate = DateTime.Now,
                          modifiedBy = "",
                          modifiedDate = null
                        });
                    }

                });
            }
            catch (FileNotFoundException fnfe)
            {
                throw fnfe;
            }
            finally
            {
                Console.WriteLine("all done");
            }

            base.Seed(context);
        }

    }
}
