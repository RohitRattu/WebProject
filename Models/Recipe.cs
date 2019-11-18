using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RecipeAssignment.Models
{
    public class Recipe
    {
        [Key]
        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public string Directions { get; set; }
        public string Rating { get; set; }
        public string RatingReview { get; set; }
    }
}
