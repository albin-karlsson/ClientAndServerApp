using System.ComponentModel.DataAnnotations;

namespace ClientApp.Models
{
    public class AnimalViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required!")]
        [MinLength(2, ErrorMessage = "Name must be at least 2 characters long!")]
        public string? Name { get; set; }
        [MinLength(2, ErrorMessage = "Type must be at least 2 characters long!")]
        public string? Type { get; set; }
    }
}
