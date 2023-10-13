using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using GoodLookTie.Data;
using System;
using System.Linq;

namespace GoodLookTie.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GoodLookTieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<GoodLookTieContext>>()))
            {
                // Look for any movies.
                if (context.Tie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Tie.AddRange(
                    new Tie
                    {
                        Type = "Neck",
                        Material = "Silk",
                        Colour = "Red",
                        Origin = "Italy",
                        Price = 29.99M,
                        Occassion = "Party"
                    },

                    new Tie
                    {
                        Type = "Interlining",
                        Material = "Polyester",
                        Colour = "Blue",
                        Origin = "China",
                        Price = 19.99M,
                        Occassion = "Party"
                    },

                    new Tie
                    {
                        Type = "Rolled Edge",
                        Material = "Silk",
                        Colour = "Black",
                        Origin = "USA",
                        Price = 39.99M,
                        Occassion = "Casual"
                    },

                    new Tie
                    {
                        Type = "Tail",
                        Material = "Cotton",
                        Colour = "White",
                        Origin = "India",
                        Price = 24.99M,
                        Occassion = "Formal"
                    },
                    new Tie
                    {
                        Type = "Bar Tack",
                        Material = "Silk",
                        Colour = "Green",
                        Origin = "Japan",
                        Price = 34.99M,
                        Occassion = "Casual"
                    },
                    new Tie
                    {
                        Type = "Blade",
                        Material = "Polyester",
                        Colour = "Gray",
                        Origin = "China",
                        Price = 17.99M,
                        Occassion = "Party"
                    },
                    new Tie
                    {
                        Type = "Tipping",
                        Material = "Silk",
                        Colour = "Blue",
                        Origin = "Italy",
                        Price = 27.99M,
                        Occassion = "Casual"
                    },
                    new Tie
                    {
                        Type = "Margin",
                        Material = "Cotton",
                        Colour = "Black",
                        Origin = "USA",
                        Price = 21.99M,
                        Occassion = "Formal"
                    },
                    new Tie
                    {
                        Type = "Hem",
                        Material = "Silk",
                        Colour = "Purple",
                        Origin = "France",
                        Price = 31.99M,
                        Occassion = "Party"
                    },
                    new Tie
                    {
                        Type = "Slip Stitch",
                        Material = "Polyester",
                        Colour = "Red",
                        Origin = "China",
                        Price = 16.99M,
                        Occassion = "Casual"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
