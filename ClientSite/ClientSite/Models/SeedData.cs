using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ClientSite.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ClientContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ClientContext>>()))
            {
                //look for any movies.
                if (context.Client.Any())
                {
                    return; //DB has been seeded
                }

                context.Client.AddRange(
                    new Client
                    {
                        Title = "GECU",
                        Category = "Financial",
                        Website = "https://www.gecu.com/",
                        Image = "https://www.gecu.com/-/media/images/logos/gecu-logo-en-retina.png?h=63&la=en&w=200&hash=6AEFAD046FF850BA94FDA319A3A77EF83B1BEBC3"
                    },

                    new Client
                    {
                        Title = "Holiday Retirement",
                        Category = "Senior Living",
                        Website = "https://www.holidaytouch.com/",
                        Image = "https://hrcsitecore-holidaytouch-com.azureedge.net/HLDYWEB2/images/Logo.jpg?cbf=1"
                    },

                    new Client
                    {
                        Title = "Logix Federal Credit Union",
                        Category = "Financial",
                        Website = "https://www.logixbanking.com/",
                        Image = "https://s3-media2.fl.yelpcdn.com/buphoto/mrl8LIcTSw2uHl75eOiFXw/o.jpg"
                    },

                    new Client
                    {
                        Title = "Marcus & Milichap",
                        Category = "Real Estate",
                        Website = "https://www.marcusmillichap.com/",
                        Image = "https://www.apto.com/hs-fs/hubfs/Sales%20Pitch%20Deck%20Logos%20(Nov.%202017)/Marcus-Millichap-Logo-promo.jpg?width=595&name=Marcus-Millichap-Logo-promo.jpg"
                    },

                    new Client
                    {
                        Title = "Micron Technology, Inc",
                        Category = "Technology",
                        Website = "https://www.micron.com/",
                        Image = "https://cdn-news.warriortrading.com/wp-content/uploads/2018/05/19181009/Micron-Technology-Logo.png"
                    },

                    new Client
                    {
                        Title = "Patelco Credit Union",
                        Category = "Financial",
                        Website = "https://www.patelco.org/",
                        Image = "https://pbs.twimg.com/profile_images/843925798138535936/QJat_HZP_400x400.jpg"
                    },

                    new Client
                    {
                        Title = "Rogue Credit Union",
                        Category = "Financial",
                        Website = "https://www.roguecu.org/",
                        Image = "https://www.logosvgpng.com/wp-content/uploads/2018/06/rogue-credit-union-logo-vector.png"
                    },

                    new Client
                    {
                        Title = "SolarWorld USA",
                        Category = "Energy",
                        Website = "http://www.solarworld-usa.com/",
                        Image = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/97/SolarWorld_Real_Value_Logo_8565.jpg/220px-SolarWorld_Real_Value_Logo_8565.jpg"
                    },

                    new Client
                    {
                        Title = "Zodiac",
                        Category = "Consumer",
                        Website = "https://www.zodiacpoolsystems.com/en",
                        Image = "https://www.zodiacpoolsystems.com/~/media/website-assets/zodiac-corporate/global-landing-pages/logos/zodiac.png"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
