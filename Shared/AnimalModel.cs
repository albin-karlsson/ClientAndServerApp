using System.ComponentModel.DataAnnotations;

namespace Shared
{
    public class AnimalModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Type { get; set; }
    }
}
