﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeAssignment.Models
{
    public class IRecipeRepo
    {
        private static List<Recipe> recipes = new List<Recipe>();

        public static IEnumerable<Recipe> Recipes
        {
            get
            {
                return recipes;

            }
         }

        public static void AddRecipe(Recipe recipe)
        {
            recipes.Add(recipe);
        }
    }
}
