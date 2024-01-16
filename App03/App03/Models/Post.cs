using System.ComponentModel.DataAnnotations;

namespace App03.Models
{
    public class Post
    {
        [Key]
        public int recipeId { get; set; }

        public string  recipeName { get; set; }

        public string recipeImage { get; set; }

        public  string category { get; set; }
        public string ingreidants { get; set;}

        public string instructions { get; set; }
    }
}
