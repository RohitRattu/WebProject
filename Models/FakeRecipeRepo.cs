using System.Collections.Generic;
using System.Linq;

namespace RecipeAssignment.Models
{
    public class FakeRecipeRepo : IRecipeRepo
    {
        public IQueryable<Recipe> Recipes => new List<Recipe>
        {
            new Recipe()
            {
                RecipeName = "Bheja Fry",
                Ingredients = "Brain",
                Directions = "nohting",
                Rating = "5 Star",
                RatingReview = "Nothing to show rating "
            }
        }.AsQueryable<Recipe>();
    }
}