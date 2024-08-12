using System.ComponentModel.DataAnnotations;

namespace CleanArchitectureBlazor.Domain.Price_Training
{
    public class Train
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Price { get; set; }
        public string? Category { get; set; }
    }
}
