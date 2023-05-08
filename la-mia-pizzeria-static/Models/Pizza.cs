using System.ComponentModel.DataAnnotations;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        [Required(ErrorMessage = "Please enter the id of the pizza.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name of the pizza.")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "The pizza name must be between 5 and 50 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the image URL of the pizza.")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Please enter a description of the pizza.")]
        [MinWords(5, ErrorMessage = "The description must contain at least 5 words.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter the price of the pizza.")]
        [Range(1, 100, ErrorMessage = "The price must be between 1 and 100.")]
        public double Price { get; set; }

        public bool IsNew { get; set; }

    }

    public class MinWordsAttribute : ValidationAttribute
    {
        public MinWordsAttribute(int minWords)
        {
            MinWords = minWords;
        }

        public int MinWords { get; }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string str && str.Split(' ').Length < MinWords)
            {
                return new ValidationResult(ErrorMessage);
            }

            return ValidationResult.Success;
        }
    }
}
