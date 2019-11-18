using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace RecipeAssignment.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Recipes.Any())
            {
                context.Recipes.AddRange(
                new Recipe
                {
                    RecipeName = "Chocolate Chip Cookies",
                    Ingredients = "1 cup butter softened, 1 cup white sugar, 2 eggs, 2 teaspoons vanilla extract, 1 teaspoon baking soda, 2 teaspoons hot water, 1/2 teaspoon salt, 3 cups all-purpose flour, 2 cups semisweet chocolate chips ",
                    Rating = "5",
                    Directions = "1. Preheat oven to 350 degrees F (175 degrees C). , 2. Cream together the butter, white sugar, and brown sugar until smooth. Beat in the eggs one at a time, then stir in the vanilla. Dissolve baking soda in hot water. Add to batter along with salt. Stir in flour, chocolate chips, and nuts. Drop by large spoonfuls onto ungreased pans , 3. Bake for about 10 minutes in the preheated oven, or until edges are nicely browned."
                });
                context.SaveChanges();
            }
         }
    }
}
