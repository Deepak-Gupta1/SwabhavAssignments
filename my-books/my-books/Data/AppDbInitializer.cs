﻿using my_books.Data.Model;

namespace my_books.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope() )
            {
                var context=serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new Book()
                    {
                        Title = "1st Bokk Title",
                        Description = "1st Book Description",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre ="Biography",
                        Author="fist Author",
                        CoverUrl="https....",
                        DateAdded=DateTime.Now,
                    },
                    new Book()
                    {
                        Title = "2st Bokk Title",
                        Description = "2st Book Description",
                        IsRead = false,
                        Genre = "Biography",
                        Author = "fist Author",
                        CoverUrl = "https....",
                        DateAdded = DateTime.Now,
                    })  ;
                    context.SaveChanges();
                }
            }
        }
    }
}
