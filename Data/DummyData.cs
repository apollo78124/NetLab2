using Lab2_v3.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2_v3.Data
{
    public class DummyData
    {
        public static void Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();
                context.Database.EnsureCreated();
                //context.Database.Migrate();

                // Look for any teams.
                if (context.Provinces != null && context.Provinces.Any())
                {
                    return;   // DB has already been seeded
                }

                var provs = DummyData.GetProvinces();
                context.Provinces.AddRange(provs);
                context.SaveChanges();

                var cities = DummyData.GetCities();
                context.Cities.AddRange(cities);
                context.SaveChanges();
            }
        }

        public static List<City> GetCities()
        {
            List<City> citis = new List<City>() {
                new City() {
                    CityName="Vancouver",
                    Population=69,
                    ProvinceCode = "BC",
                },
                new City() {
                    CityName="Vancouver1",
                    Population=69,
                    ProvinceCode = "BC",
                },new City() {
                    CityName="Vancouver2",
                    Population=69,
                    ProvinceCode = "BC",
                },new City() {
                    CityName="Vancouver3",
                    Population=69,
                    ProvinceCode = "ON",
                },new City() {
                    CityName="Vancouver4",
                    Population=69,
                    ProvinceCode = "ON",
                },new City() {
                    CityName="Vancouver5",
                    Population=69,
                    ProvinceCode = "ON",
                },new City() {
                    CityName="Vancouver6",
                    Population=69,
                    ProvinceCode = "ON",
                },new City() {
                    CityName="Vancouver7",
                    Population=69,
                    ProvinceCode = "AB",
                },new City() {
                    CityName="Vancouveru8",
                    Population=69,
                    ProvinceCode = "AB",
                },new City() {
                    CityName="Vancouver9",
                    Population=69,
                    ProvinceCode = "AB",
                },

            };

            return citis;
        }

        public static List<Province> GetProvinces() {
            List<Province> provs = new List<Province>() {
                new Province {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                },
                new Province {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario",
                },
                new Province {
                    ProvinceCode = "AB",
                    ProvinceName = "Albert1a",
                },
            };

            return provs;
        }
    }
}
