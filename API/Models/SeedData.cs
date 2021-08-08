using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApiContext
                (serviceProvider.GetRequiredService<DbContextOptions<ApiContext>>()))
            {
                if (context.Pages.Any())
                {
                    return;
                }
                context.Pages.AddRange(
                    new Page
                    {
                        Name = "Home",
                        Slug = "home",
                        Content = "Home page"
                    },
                    new Page
                    {
                        Name = "About Us",
                        Slug = "About-Us",
                        Content = "About Us"
                    },
                    new Page
                    {
                        Name = "Services",
                        Slug = "Services",
                        Content = "Services page"
                    },
                    new Page
                    {
                        Name = "Contact",
                        Slug = "contact",
                        Content = "Contact page"
                    }

               );
                context.Categories.AddRange(
                    new Category
                    {
                        Name = "Fruits",
                        Slug = "Fruits"

                    },
                     new Category
                     {
                         Name = "T-Shirts",
                         Slug = "t-shirts"

                     }
                      );
                context.Products.AddRange(
                      new Product
                      {
                          Name = "White Shirt ",
                          CategoryId = 2,
                          Description= "A white t-shirt",
                          Image = " white_shirt.jpg",
                          Price = 2.99M

                      },
                      new Product
                      {
                          Name = "Blue Shirt ",
                          CategoryId = 2,
                          Description = "A Blue t-shirt",
                          Image = " Blue_shirt.jpg",
                          Price = 3.99M

                      },
                      new Product
                      {
                          Name = "Apples ",
                          CategoryId = 1,
                          Description = "A apple",
                          Image = " apple.jpg",
                          Price = 1.99M

                      },
                      new Product
                      {
                          Name = "Banans ",
                          CategoryId = 1,
                          Description = "A Banans",
                          Image = " Banans.jpg",
                          Price = 2.49M

                      },
                      new Product
                      {
                          Name = "Grey Shirt ",
                          CategoryId = 2,
                          Description = "A Grey t-shirt",
                          Image = " Blue_shirt.jpg",
                          Price = 13.99M

                      },
                       new Product
                       {
                           Name = "Lemon ",
                           CategoryId = 1,
                           Description = " Lemon",
                           Image = " Lemon.jpg",
                           Price = 51.99M

                       },
                      new Product
                      {
                          Name = "Grapefruit ",
                          CategoryId = 1,
                          Description = "A Grapefruit",
                          Image = " Grapefruit.jpg",
                          Price = 3.49M

                      },

                      new Product
                      {
                          Name = "Orange Shirt ",
                          CategoryId = 2,
                          Description = "A Orange t-shirt",
                          Image = " Orange_shirt.jpg",
                          Price = 13.99M

                      },
                      new Product
                      {
                          Name = "Purple Shirt ",
                          CategoryId = 2,
                          Description = "A Purple t-shirt",
                          Image = " Purple_shirt.jpg",
                          Price = 13.99M

                      },
                      new Product
                      {
                          Name = "Kiwi ",
                          CategoryId = 1,
                          Description = " Kiwi",
                          Image = " Kiwi.jpg",
                          Price = 21.99M

                      }

                    );
                context.SaveChanges();
            }

        }
    }
}
