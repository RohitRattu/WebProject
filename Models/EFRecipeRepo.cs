using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace RecipeAssignment.Models
{
    public class EFRecipeRepo : IRecipeRepo
    {
        private ApplicationDbContext context;

        public EFRecipeRepo(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public new IQueryable<Recipe> Recipes => context.Recipes;
    }
}
